using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    public interface IResult : ICoordinate
    {
        /// <summary>
        /// Indique si la recherche a fonctionné
        /// </summary>
        bool IsSuccess { get; set; }
    }
}
