using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;
using T3_FIS.Model.BuisnessLogic.ProductsPC;

namespace T3_FIS.Model.Common
{
    public class Peripheral : Component, ISellableProduct
    {
        /// <summary>
        /// Get the type and subtype of the peripheral.
        /// </summary>
        public ProductType Type { get; private set; }
        private Price Price { get; set; }

        #region Constructors
        public Peripheral(string name, ProductType type, Price price) : base(name, type)
        {
            Type = type;
            Price = price;
        }

        public Peripheral(string name, ProductType type, float price) : base(name, type)
        {
            Type = type;
            Price = new Price(price);
        }
        #endregion

        //public bool Equals(Component other)
        //{
        //    return Name == other.Name && Price == other.Price;
        //}

        /// <summary>
        /// Get the name of the peripheral.
        /// </summary>
        string ISellableProduct.Name { get { return Name; } set { } }
        /// <summary>
        /// Get the price of the peripheral.
        /// </summary>
        Price ISellableProduct.Price { get { return Price; } set { } }
        /// <summary>
        /// Get the unieuq GUID of the peripheral.
        /// </summary>
        Guid ISellableProduct.ProductGuid { get { return ProductGuid; } set { } }
    }
}
