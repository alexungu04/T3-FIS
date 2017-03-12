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
        /// <summary>
        /// Get the name of the product.
        /// </summary>
        protected string Name { get; private set; }
        /// <summary>
        /// Get the product guid, which is unique to all instances of the product.
        /// </summary>
        protected Guid ProductGuid { get; private set; } = new Guid();

        #region Constructors
        public Product(string name)
        {
            Name = name;
        }
        #endregion

    }
}
