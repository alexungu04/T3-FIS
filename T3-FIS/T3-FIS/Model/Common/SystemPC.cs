using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public class SystemPC : Product
    {
        private SystemType Type;
        private List<Component> Components = new List<Component>();
        private int InventoryQuantity;
        private int OrderedQuantity;
        private int DeliveredQuantity;

        #region Constructors
        public SystemPC(string name, float price) : base(name, price)
        {

        }
        #endregion

        //public bool Equals(SystemPC other)
        //{
        //    bool result = Type.Equals(other.Type);

        //    foreach (Component component in Components)
        //    {
        //        if (!component.Any(x => x.Equals(other.))
        //        {
        //            return false;
        //        }
        //    }

        //    return result;
        //    return false;
        //}
    }
}
