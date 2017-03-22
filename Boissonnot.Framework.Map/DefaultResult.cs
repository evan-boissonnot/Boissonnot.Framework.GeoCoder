using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    public class DefaultResult : IResult
    {
        #region Constructors
        public DefaultResult()
        {
            this.IsSuccess = false;
        }
        #endregion

        #region Properties
        public bool IsSuccess { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
        #endregion
    }
}
