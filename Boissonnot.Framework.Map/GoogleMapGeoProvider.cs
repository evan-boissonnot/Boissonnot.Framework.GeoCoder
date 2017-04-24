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
            ((HttpWebRequest)request).UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/57.0.2987.133 Safari/537.36";

            WebHeaderCollection headerList = request.Headers;
            headerList.Add("Accept-Language", "fr-FR,fr;q=0.8,en-US;q=0.6,en;q=0.4");

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string contentResult = reader.ReadToEnd();
                    Models.GoogleMapResult content = JsonConvert.DeserializeObject<Models.GoogleMapResult>(contentResult);

                    result.IsSuccess = content.IsSuccess;
                    if(result.IsSuccess)
                    {
                        int lastIndex = content.ResultList.Length - 1;

                        result.Latitude = content.ResultList[lastIndex].GeometryContent.Location.Latitude;
                        result.Longitude = content.ResultList[lastIndex].GeometryContent.Location.Longitude;
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
