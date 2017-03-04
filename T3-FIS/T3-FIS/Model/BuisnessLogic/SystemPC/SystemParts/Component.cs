using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public class Component : Product
    {
        #region Constructors
        public Component(string name, float price) : base(name, price)
        {
        }
        #endregion
        
        //public bool Equals(Component other)
        //{
        //    return Name == other.Name && Price == other.Price;
        //}
    }
}
