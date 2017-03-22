using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    public class ConfigurationProvidersBinder : IProvidersBinder
    {
        #region Public methods
        public List<IGeoProvider> Load()
        {
            List<IGeoProvider> list = new List<IGeoProvider>();
            Config.GeoCodingConfigurationSection config = null;

            config = System.Configuration.ConfigurationManager.GetSection(Config.GeoCodingConfigurationSection.SECTION_KEY) as Config.GeoCodingConfigurationSection;
            foreach (var item in config.Providers)
            {
                Config.GeoProviderConfigurationElement element = item as Config.GeoProviderConfigurationElement;
                Type currentType = Type.GetType(element.Type);

                IGeoProvider provider = Activator.CreateInstance(currentType) as IGeoProvider;

                if (provider != null)
                {
                    provider.Key = element.ApiKey;
                    list.Add(provider);
                }
            }

            return list;
        }
        #endregion
    }
}
