using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.ProductsPC;
using T3_FIS.Model.Common;

namespace T3_FIS.Model.Managers
{
    class ProductManager : ManagerBase, IList<ISellableProduct>
    {
        private List<ISellableProduct> Systems = new List<ISellableProduct>();
        private static ProductManager Manager = new ProductManager();

        #region Constructors
        private ProductManager()
        {
        }
        #endregion

        public ProductManager GetManager()
        {
            return Manager;
        }

        #region IList Interface Methods
        public ISellableProduct this[int index] { get => ((IList<ISellableProduct>)Systems)[index]; set => ((IList<ISellableProduct>)Systems)[index] = value; }

        public int Count => ((IList<ISellableProduct>)Systems).Count;

        public bool IsReadOnly => ((IList<ISellableProduct>)Systems).IsReadOnly;

        public void Add(ISellableProduct item)
        {
            ((IList<ISellableProduct>)Systems).Add(item);
        }

        public void Clear()
        {
            ((IList<ISellableProduct>)Systems).Clear();
        }

        public bool Contains(ISellableProduct item)
        {
            return ((IList<ISellableProduct>)Systems).Contains(item);
        }

        public void CopyTo(ISellableProduct[] array, int arrayIndex)
        {
            ((IList<ISellableProduct>)Systems).CopyTo(array, arrayIndex);
        }

        public IEnumerator<ISellableProduct> GetEnumerator()
        {
            return ((IList<ISellableProduct>)Systems).GetEnumerator();
        }

        public int IndexOf(ISellableProduct item)
        {
            return ((IList<ISellableProduct>)Systems).IndexOf(item);
        }

        public void Insert(int index, ISellableProduct item)
        {
            ((IList<ISellableProduct>)Systems).Insert(index, item);
        }

        public bool Remove(ISellableProduct item)
        {
            return ((IList<ISellableProduct>)Systems).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<ISellableProduct>)Systems).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<ISellableProduct>)Systems).GetEnumerator();
        }
        #endregion
    }
}
