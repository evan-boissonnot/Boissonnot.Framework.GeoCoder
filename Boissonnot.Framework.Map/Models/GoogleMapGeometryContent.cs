using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map.Models
{
    public class GoogleMapGeometryContent
    {
        #region Properties
        [JsonProperty("bounds")]
        public GoogleMapBound Bound { get; set; }

        [JsonProperty("location")]
        public Coordinate Location { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        [JsonProperty("viewport")]
        public GoogleMapBound ViewPort { get; set; }
        #endregion
    }
}
