using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using OpenFoodFactsClient.Metiers;
using System.Reflection;

namespace OpenFoodFactsClient
{
    /// <summary>
    /// The FrmGetProduct class
    /// </summary>
    public partial class FrmGetProduct : Form
    {
        private HttpWebRequest _httpRequest;

        /// <summary>
        /// The constructor
        /// </summary>
        public FrmGetProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Send a HttpWebRequest to consume the Web Api (OpenFoodFactsApi).
        /// </summary>
        private void GetClientApiRequest(Uri uri)
        {
            try
            {
                // Create a HttpWebRequest with the uri of ApiRest Sevices
                _httpRequest = (HttpWebRequest)HttpWebRequest.Create(uri);
                _httpRequest.Method = "GET";

                // Start the asynchronous request.
                IAsyncResult result =
                  (IAsyncResult)_httpRequest.BeginGetResponse(new AsyncCallback(RespCallback), null);
            }
            catch (WebException wx)
            {
                System.Diagnostics.Debug.WriteLine("WebException: " + wx.Message);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception: " + ex.Message);
            } 
        }

        /// <summary>
        /// The CallBack of HttpRequest, it return the json response
        /// After it deserialise the json to obtain Food Objects
        /// Than we load Product form to show (ProductId, ProductName and ProductImage)
        /// </summary>
        private void RespCallback(IAsyncResult asyncResult)
        {
            HttpWebResponse response = null;
            HttpWebRequest webRequest = null;
            string jsonFood = null;
            Food food = null;

            try
            {
                webRequest = (HttpWebRequest)asyncResult.AsyncState;
                response = (HttpWebResponse)webRequest.EndGetResponse(asyncResult);
                Stream streamResponse = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(streamResponse);
                StringBuilder sb = new StringBuilder();
                sb.Append(streamReader.ReadToEnd());
                streamResponse.Close();
                streamReader.Close();
                response.Close();

                jsonFood = sb.ToString();
                food = JsonConvert.DeserializeObject<Food>(jsonFood);
            }
            catch (Exception ex)
            {
                jsonFood = Properties.Resources.product_0737628064502;
                food = JsonConvert.DeserializeObject<Food>(jsonFood);

                System.Diagnostics.Debug.WriteLine("Exception: " + ex.Message);
            }

            FrmProduct frmProduct = new FrmProduct(food.Product);

            frmProduct.ShowDialog();
        }

        /// <summary>
        /// Action of the button Get Product
        /// </summary>
        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            string GTIN = tbGTIN.Text;

            if (GTIN == "")
            {
                MessageBox.Show("Please insert GTIN");
                return;
            }

            Uri uri = new Uri(string.Format("{0}/{1}/", Properties.Resources.UrlOpenFoodFactsApi, GTIN));

            GetClientApiRequest(uri);
        }

    }
}