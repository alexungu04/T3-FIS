using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;

namespace T3_FIS.Model.Common
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public Guid ProductGuid = new Guid();
        public Price Price;

        #region Constructors
        public Product(string name, Price price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name, float price)
        {
            Name = name;
            Price = new Price(price);
        }
        #endregion

    }
}
