using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map.Config
{
    [ConfigurationCollection(typeof(GeoProviderConfigurationElement), AddItemName = "GeoProvider", 
                                                                      CollectionType = ConfigurationElementCollectionType.BasicMap)]
    public class GeoProviderCollection : ConfigurationElementCollection
    {
        #region Public methods
        public void Add(GeoProviderConfigurationElement serviceConfig)
        {
            BaseAdd(serviceConfig);
        }

        public void Clear()
        {
            BaseClear();
        }

        public void Remove(GeoProviderConfigurationElement serviceConfig)
        {
            BaseRemove(serviceConfig.Type);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(String name)
        {
            BaseRemove(name);
        }
        #endregion

        #region Internal methods
        protected override ConfigurationElement CreateNewElement()
        {
            return new GeoProviderConfigurationElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((GeoProviderConfigurationElement)element).Type;
        }
        #endregion

        #region Properties
        public GeoProviderConfigurationElement this[int index]
        {
            get { return (GeoProviderConfigurationElement)BaseGet(index); }

            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);

                BaseAdd(index, value);
            }
        }
        #endregion
    }
}
