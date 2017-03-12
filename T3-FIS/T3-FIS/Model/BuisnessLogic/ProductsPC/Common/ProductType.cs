using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public class ProductType
    {
        /// <summary>
        /// Get a list of the types and subtypes of the product.
        /// </summary>
        public List<string> Types { get; private set; } = new List<string>();

        #region Constructors
        public ProductType(string type)
        {
            Types.Add(type);
        }
        
        public ProductType(IEnumerable<string> types)
        {
            Types.AddRange(types);
        }
        #endregion

        /// <summary>
        /// Adds a product type.
        /// </summary>
        /// <param name="product type"></param>
        public void AddSubtype(string type)
        {
            Types.Add(type);
        }

        /// <summary>
        /// Adds multiple product types.
        /// </summary>
        /// <param name="product types"></param>
        public void AddSubtypes(IEnumerable<string> types)
        {
            Types.AddRange(types);
        }

        //public bool Equals(SystemType type)
        //{
        //    bool result = (Name == type.Name);

        //    SubTypes.SequenceEqual(type.SubTypes);

        //    return result;
        //}
    }
}
