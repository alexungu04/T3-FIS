using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;

namespace T3_FIS.Model.BuisnessLogic.ProductsPC
{
    public interface ISellableProduct
    {
        /// <summary>
        /// Used to describe the name of the product.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Used to describe the price of the product.
        /// </summary>
        Price Price { get; set; }
        /// <summary>
        /// Used to describe the unique GUID of the product.
        /// </summary>
        Guid ProductGuid { get; set; }
    }
}
