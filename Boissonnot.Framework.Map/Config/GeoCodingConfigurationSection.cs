using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map.Config
{
    // Tips : http://stackoverflow.com/questions/3935331/how-to-implement-a-configurationsection-with-a-configurationelementcollection
    public class GeoCodingConfigurationSection : ConfigurationSection
    {
        #region Constants
        /// <summary>
        /// Accès à la clef dans le fichier de configuration
        /// </summary>
        public const string SECTION_KEY = "GeoCodingConfiguration";
        #endregion

        #region Properties
        [ConfigurationProperty("Providers", IsRequired = true)]
        public GeoProviderCollection Providers
        {
            get
            {
                return base["Providers"] as GeoProviderCollection;
            }
        }
        #endregion
    }
}
