using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;
using T3_FIS.Model.BuisnessLogic.ProductsPC;

namespace T3_FIS.Model.Common
{
    public class PromotionalPackage : Product, ISellableProduct
    {
        private float PriceReduction;
        private List<ISellableProduct> Systems = new List<ISellableProduct>();

        #region Constructors
        public PromotionalPackage(string name, float priceReduction, IEnumerable<ISellableProduct> products) : base(name)
        {
            Systems.AddRange(products);
            PriceReduction = priceReduction;
        }

        #endregion

        /// <summary>
        /// Get the name of the package.
        /// </summary>
        string ISellableProduct.Name { get { return Name; } set { } }
        /// <summary>
        /// Get the price of all the system that the package contains with price reduction applied.
        /// </summary>
        Price ISellableProduct.Price { get { return new Price((Systems.Sum(x => x.Price.Value) * (100 - PriceReduction)) / 100); ; } set { } }
        /// <summary>
        /// Get the unque GUID of the package.
        /// </summary>
        Guid ISellableProduct.ProductGuid { get { return ProductGuid; } set { } }
    }
}
