using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.ProductsPC;

namespace T3_FIS.Model.Common
{
    class ProductOrder
    {
        /// <summary>
        /// Get a list of sellable products from the order.
        /// </summary>
        public List<ISellableProduct> Products { get; private set; } = new List<ISellableProduct>();
        /// <summary>
        /// Get the details of the order.
        /// </summary>
        public Message Details = new Message(MessageType.Unknown, "No Details.");
        /// <summary>
        /// Get the date of when the order has been placed.
        /// </summary>
        public DateTime Date { get; private set; }
        /// <summary>
        /// Get and set the delivery status of the order.
        /// </summary>
        public bool DeliveryStatus { get; set; }
        /// <summary>
        /// Get and set the payment status of the order.
        /// </summary>
        public bool PaymentStatus { get; set; }

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
        public void AddProduct(ISellableProduct product)
        {
            Products.Add(product);
        }

        /// <summary>
        /// Adds multiple products.
        /// </summary>
        /// <param name="products"></param>
        public void AddProducts(IEnumerable<ISellableProduct> products)
        {
            Products.AddRange(products);
        }
    }
}
