using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map.Models
{
    public class GoogleMapBound
    {
        #region Properties
        [JsonProperty("northeast")]
        public Coordinate Northeast { get; set; }

        [JsonProperty("southwest")]
        public Coordinate Southwest { get; set; }
        #endregion
    }
}
