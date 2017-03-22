using System.Collections.Generic;

namespace Boissonnot.Framework.Map
{
    public interface IGeoCoder : ICollection<IGeoProvider>
    {
        /// <summary>
        /// Recherche la bonne position gps d'une adresse
        /// </summary>
        /// <param name="address">Adresse physique</param>
        /// <returns></returns>
        List<IResult> Find(string address);
    }
}