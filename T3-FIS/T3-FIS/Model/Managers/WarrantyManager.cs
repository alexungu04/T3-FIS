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
    class WarrantyManager : ManagerBase, IList<Warranty>
    {
        private List<Warranty> Warranties = new List<Warranty>();
        private static WarrantyManager Manager = new WarrantyManager();

        #region Constructors
        private WarrantyManager()
        {
        }
        #endregion

        public WarrantyManager GetManager()
        {
            return Manager;
        }

        #region IList Interface Methods
        public Warranty this[int index] { get => ((IList<Warranty>)Warranties)[index]; set => ((IList<Warranty>)Warranties)[index] = value; }

        public int Count => ((IList<Warranty>)Warranties).Count;

        public bool IsReadOnly => ((IList<Warranty>)Warranties).IsReadOnly;

        public void Add(Warranty item)
        {
            ((IList<Warranty>)Warranties).Add(item);
        }

        public void Clear()
        {
            ((IList<Warranty>)Warranties).Clear();
        }

        public bool Contains(Warranty item)
        {
            return ((IList<Warranty>)Warranties).Contains(item);
        }

        public void CopyTo(Warranty[] array, int arrayIndex)
        {
            ((IList<Warranty>)Warranties).CopyTo(array, arrayIndex);
        }

        public IEnumerator<Warranty> GetEnumerator()
        {
            return ((IList<Warranty>)Warranties).GetEnumerator();
        }

        public int IndexOf(Warranty item)
        {
            return ((IList<Warranty>)Warranties).IndexOf(item);
        }

        public void Insert(int index, Warranty item)
        {
            ((IList<Warranty>)Warranties).Insert(index, item);
        }

        public bool Remove(Warranty item)
        {
            return ((IList<Warranty>)Warranties).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<Warranty>)Warranties).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<Warranty>)Warranties).GetEnumerator();
        }
        #endregion
    }
}
