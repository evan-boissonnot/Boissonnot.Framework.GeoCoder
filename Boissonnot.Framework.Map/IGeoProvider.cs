using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    public interface IGeoProvider
    {
        /// <summary>
        /// Recherche une position GPS suivant une adresse
        /// </summary>
        /// <param name="address">Adresse physique (avec rue, code postal, ville)</param>
        /// <returns></returns>
        IResult Find(string address);

        /// <summary>
        /// Clef d'activation pour appeler l'api
        /// </summary>
        string Key { get; set; }
    }
}
