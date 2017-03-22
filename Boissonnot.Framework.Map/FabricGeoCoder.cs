using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    public static class FabricGeoCoder
    {
        #region Public methods
        /// <summary>
        /// Charge un geocoder
        /// </summary>
        /// <param name="binder">Binder des géo-providers</param>
        /// <returns></returns>
        public static IGeoCoder Prepare(IProvidersBinder binder)
        {
            return new GeoCoder(binder);
        }
        #endregion
    }
}
