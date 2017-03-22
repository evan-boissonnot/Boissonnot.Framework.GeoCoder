using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    // Tips : https://developers.google.com/maps/documentation/geocoding/intro?csw=1
    public class GoogleMapGeoProvider : IGeoProvider
    {
        #region Constants
        /// <summary>
        /// Url dynamique d'appel à la carto
        /// </summary>
        private const string MAP_URL = "https://maps.googleapis.com/maps/api/geocode/json?address={0}&key={1}";
        #endregion

        #region Public methods
        public IResult Find(string address)
        {
            string url = MAP_URL;
            IResult result = new DefaultResult();

            address = address.Replace(" ", "+");
            url = string.Format(url, address, this.Key);

            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string contentResult = reader.ReadToEnd();
                    Models.GoogleMapResult content = JsonConvert.DeserializeObject<Models.GoogleMapResult>(contentResult);

                    result.IsSuccess = content.IsSuccess;
                    if(result.IsSuccess)
                    {
                        result.Latitude = content.ResultList[0].GeometryContent.Location.Latitude;
                        result.Longitude = content.ResultList[0].GeometryContent.Location.Longitude;
                    }
                }
            }

            return result;
        }
        #endregion

        #region Properties
        public string Key
        {
            get; set;
        }
        #endregion
    }
}
