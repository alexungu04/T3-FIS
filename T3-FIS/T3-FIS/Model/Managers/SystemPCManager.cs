using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.Common;

namespace T3_FIS.Model.Managers
{
    class SystemPCManager : IList<SystemPC>
    {
        private List<SystemPC> Systems = new List<SystemPC>();

        #region Constructors
        public SystemPCManager()
        {

        }
        #endregion

        #region IList Interface Methods
        public SystemPC this[int index] { get => ((IList<SystemPC>)Systems)[index]; set => ((IList<SystemPC>)Systems)[index] = value; }

        public int Count => ((IList<SystemPC>)Systems).Count;

        public bool IsReadOnly => ((IList<SystemPC>)Systems).IsReadOnly;

        public void Add(SystemPC item)
        {
            ((IList<SystemPC>)Systems).Add(item);
        }

        public void Clear()
        {
            ((IList<SystemPC>)Systems).Clear();
        }

        public bool Contains(SystemPC item)
        {
            return ((IList<SystemPC>)Systems).Contains(item);
        }

        public void CopyTo(SystemPC[] array, int arrayIndex)
        {
            ((IList<SystemPC>)Systems).CopyTo(array, arrayIndex);
        }

        public IEnumerator<SystemPC> GetEnumerator()
        {
            return ((IList<SystemPC>)Systems).GetEnumerator();
        }

        public int IndexOf(SystemPC item)
        {
            return ((IList<SystemPC>)Systems).IndexOf(item);
        }

        public void Insert(int index, SystemPC item)
        {
            ((IList<SystemPC>)Systems).Insert(index, item);
        }

        public bool Remove(SystemPC item)
        {
            return ((IList<SystemPC>)Systems).Remove(item);
        }

        public void RemoveAt(int index)
        {
            ((IList<SystemPC>)Systems).RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IList<SystemPC>)Systems).GetEnumerator();
        }
        #endregion
    }
}
