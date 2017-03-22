using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    public interface IProvidersBinder
    {
        /// <summary>
        /// Charge la liste des binders 
        /// </summary>
        /// <returns></returns>
        List<IGeoProvider> Load();
    }
}
