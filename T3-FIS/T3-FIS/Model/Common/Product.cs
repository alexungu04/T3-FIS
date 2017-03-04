using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public float Price;

        #region Constructors
        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }
        #endregion

    }
}
