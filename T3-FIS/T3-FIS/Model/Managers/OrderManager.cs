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
    class OrderManager : ManagerBase, IList<ProductOrder>
    {
        private List<ProductOrder> Orders = new List<ProductOrder>();
        private static OrderManager Manager = new OrderManager();

        #region Constructors
        private OrderManager()
        {
        }   
        #endregion

        public OrderManager GetManager()
        {
            return Manager;
        }

        #region IList Interface Methods
        public ProductOrder this[int index] { get => ((IList<ProductOrder>)Orders)[index]; set => ((IList<ProductOrder>)Orders)[index] = value; }

        public int Count => ((IList<ProductOrder>)Orders).Count;

        public bool IsReadOnly => ((IList<ProductOrder>)Orders).IsReadOnly;

        public void Add(ProductOrder item)
        {
            ((IList<ProductOrder>)Orders).Add(item);
        }

        public void Clear()
        {
            ((IList<ProductOrder>)Orders).Clear();
        }

        public bool Contains(ProductOrder item)
        {
            return ((IList<ProductOrder>)Orders).Contains(item);
        }

        public void CopyTo(ProductOrder[] array, int arrayIndex)
        {
            ((IList<ProductOrder>)Orders).CopyTo(array, arrayIndex);
        }

        public IEnumerator<ProductOrder> GetEnumerator()
        {
            return ((IList<ProductOrder>)Orders).GetEnumerator();
        }

        public int IndexOf(ProductOrder item)
        {
            return ((IList<ProductOrder>)Orders).IndexOf(item);
        }

        public void Insert(int index, ProductOrder item)
        {
            ((IList<ProductOrder>)Orders).Insert(index, item);
        }

        public bool Remove(ProductOrder item)
        {
            return ((IList<ProductOrder>)Orders).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<ProductOrder>)Orders).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<ProductOrder>)Orders).GetEnumerator();
        }
        #endregion
    }
}
