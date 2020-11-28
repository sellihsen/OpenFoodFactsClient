using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenFoodFactsClient.Metiers
{
    /// <summary>
    /// Product class.
    /// Contains Product's propretises.
    /// </summary>
    public partial class Product
    {
        [JsonProperty("id")]
        public string ProductId { get; set; }

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("image_front_thumb_url")]
        public Uri ImageFrontThumbUrl { get; set; }

        [JsonProperty("image_front_url")]
        public Uri ImageFrontUrl { get; set; }
    }
}
