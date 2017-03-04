using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    class ProductOrder
    {
        private List<Product> Products = new List<Product>();

        public Message Details = new Message(MessageType.Unknown, "No Details.");
        public DateTime Date { get; private set; }
        public bool DeliveryStatus { get; private set; }
        public bool PaymentStatus { get; private set; }

        #region Constructors
        public ProductOrder(DateTime date)
        {
            Date = date;
        }
        #endregion

        /// <summary>
        /// Adds a product.
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        /// <summary>
        /// Adds multiple products.
        /// </summary>
        /// <param name="products"></param>
        public void AddProducts(IEnumerable<Product> products)
        {
            Products.AddRange(products);
        }
    }
}
