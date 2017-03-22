using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map.Models
{
    public class GoogleMapResult
    {
        #region Properties
        [JsonProperty("results")]
        public GoogleMapResultList[] ResultList { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        public bool IsSuccess { get { return this.Status == "OK"; } }
        #endregion
    }
}
