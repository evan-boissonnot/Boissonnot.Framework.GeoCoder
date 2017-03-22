using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map.Models
{
    public class GoogleMapResultList
    {
        #region Properties
        [JsonProperty("address_components")]
        public List<GoogleMapAddressComponent> Items { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("geometry")]
        public GoogleMapGeometryContent GeometryContent { get; set; }

        [JsonProperty("partial_match")]
        public bool IsPartialMatch { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("types")]
        public string[] TypeList { get; set; }
        #endregion
    }
}
