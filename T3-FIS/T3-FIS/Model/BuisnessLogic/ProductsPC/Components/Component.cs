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
        /// <summary>
        /// Get the type and subtype of the component.
        /// </summary>
        public ProductType Type { get; private set; }

        #region Constructors
        public Component(string name, ProductType type) : base(name)
        {
            Type = type;
        }
        #endregion

        //public bool Equals(Component other)
        //{
        //    return Name == other.Name && Price == other.Price;
        //}
    }
}
