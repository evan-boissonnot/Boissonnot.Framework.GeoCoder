using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map.Config
{
    public class GeoProviderConfigurationElement : ConfigurationElement
    {
        #region Properties
        [ConfigurationProperty("Type", IsKey = true, IsRequired = true)]
        public string Type
        {
            get
            {
                return base["Type"] as string;
            }
        }

        [ConfigurationProperty("ApiKey", IsRequired = true)]
        public string ApiKey
        {
            get
            {
                return base["ApiKey"] as string;
            }
        }
        #endregion
    }
}
