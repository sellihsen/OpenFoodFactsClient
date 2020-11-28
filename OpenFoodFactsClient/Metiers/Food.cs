using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace OpenFoodFactsClient.Metiers
{
    /// <summary>
    /// Food class.
    /// Contains Food's propretises.
    /// </summary>
    public partial class Food
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("status_verbose")]
        public string StatusVerbose { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }
    }
}
