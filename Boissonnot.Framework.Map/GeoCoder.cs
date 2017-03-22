using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boissonnot.Framework.Map
{
    public class GeoCoder : IGeoCoder
    {
        #region Fields
        private List<IGeoProvider> _providers = new List<IGeoProvider>();
        #endregion

        #region Constructors
        public GeoCoder(IProvidersBinder binder) : base()
        {
            List<IGeoProvider> providerList = null;

            providerList = binder.Load();
            foreach (var item in providerList)
                this.Add(item);
        }
        #endregion

        #region Public methods
        public List<IResult> Find(string address)
        {
            List<IResult> list = new List<IResult>();

            foreach (var item in this._providers)
                list.Add(item.Find(address));

            return list;
        }

        public void Add(IGeoProvider item)
        {
            this._providers.Add(item);
        }

        public void Clear()
        {
            this._providers.Clear();
        }

        public bool Contains(IGeoProvider item)
        {
            return this._providers.Contains(item);
        }

        public void CopyTo(IGeoProvider[] array, int arrayIndex)
        {
            this._providers.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IGeoProvider> GetEnumerator()
        {
            return this._providers.GetEnumerator();
        }

        public bool Remove(IGeoProvider item)
        {
            return this._providers.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._providers.GetEnumerator();
        }
        #endregion

        #region Properties
        public int Count
        {
            get
            {
                return this._providers.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        #endregion
    }
}
