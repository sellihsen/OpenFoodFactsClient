using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenFoodFactsClient.Metiers;

namespace OpenFoodFactsClient
{
    /// <summary>
    /// The FrmProduct class
    /// </summary>
    public partial class FrmProduct : Form
    {
        private Product _product;

        /// <summary>
        /// The constructor
        /// </summary>
        public FrmProduct(Product product)
        {
            _product = product;
            InitializeComponent();
        }

        /// <summary>
        /// The FrmProduct Load event
        /// </summary>
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            lbProductId.Text = _product.ProductId;
            lbProductName.Text = _product.ProductName;

            try
            {
                pbProductImage.Image = new Bitmap(_product.ImageFrontThumbUrl.AbsoluteUri);
            }
            catch (Exception ex)
            {
                pbProductImage.Image = Properties.Resources.product_image;

                System.Diagnostics.Debug.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}