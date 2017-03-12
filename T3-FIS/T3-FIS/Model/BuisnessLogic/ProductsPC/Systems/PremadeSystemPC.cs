using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;
using T3_FIS.Model.BuisnessLogic.ProductsPC;

namespace T3_FIS.Model.Common
{
    public class PremadeSystemPC : SystemPC, ISellableProduct
    {
        /// <summary>
        /// Get and set the inventory quantity.
        /// </summary>
        public int InventoryQuantity;
        /// <summary>
        /// Get and set the ordered quantity.
        /// </summary>
        public int OrderedQuantity;
        /// <summary>
        /// Get and set the delivered quantity.
        /// </summary>
        public int DeliveredQuantity;

        #region Constructors
        public PremadeSystemPC(string name, float price, ProductType sytemType, IEnumerable<Component> components) : base(name, price, sytemType, components)
        {
        }

        public PremadeSystemPC(string name, Price price, ProductType sytemType, IEnumerable<Component> components) : base(name, price, sytemType, components)
        {
        }
        #endregion

        /// <summary>
        /// Get the remainig stock quantity.
        /// </summary>
        public int InStockQuantity()
        {
            return InventoryQuantity - OrderedQuantity;
        }


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
