using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;

namespace T3_FIS.Model.Common
{
    public class Component : Product
    {
        #region Constructors
        public Component(string name, float price) : base(name, price)
        {
        }

        public Component(string name, Price price) : base(name, price)
        {
        }
        #endregion

        //public bool Equals(Component other)
        //{
        //    return Name == other.Name && Price == other.Price;
        //}
    }
}
