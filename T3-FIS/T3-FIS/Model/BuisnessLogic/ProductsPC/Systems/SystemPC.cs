using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;
using T3_FIS.Model.BuisnessLogic.ProductsPC;

namespace T3_FIS.Model.Common
{
    public class SystemPC : Product, ISellableProduct
    {
        /// <summary>
        /// Get the type and subtype of the PC system.
        /// </summary>
        public ProductType Type { get; protected set; }
        /// <summary>
        /// Get a list of the PC's system components.
        /// </summary>
        public List<Component> Components { get; protected set; } = new List<Component>();
        protected Price Price;

        #region Constructors
        public SystemPC(string name, float price, ProductType sytemType, IEnumerable<Component> components) : base(name)
        {
            Components.AddRange(components);
            Price = new Price(price);
        }

        public SystemPC(string name, Price price, ProductType sytemType, IEnumerable<Component> components) : base(name)
        {
            Components.AddRange(components);
            Price = price;
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

        /// <summary>
        /// Get the name of the PC system.
        /// </summary>
        string ISellableProduct.Name { get { return Name; } set { } }
        /// <summary>
        /// Get the price of the PC system.
        /// </summary>
        Price ISellableProduct.Price { get { return Price; } set { } }
        /// <summary>
        /// Get the unique GUID of the PC system.
        /// </summary>
        Guid ISellableProduct.ProductGuid { get { return ProductGuid; } set { } }
    }
}
