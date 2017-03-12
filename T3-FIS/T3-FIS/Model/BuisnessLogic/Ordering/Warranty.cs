using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public class Warranty
    {
        /// <summary>
        /// Get the date of the warranty
        /// </summary>
        public DateTime Date { get; private set; }
        /// <summary>
        /// Get the defected system
        /// </summary>
        public SystemPC DefectedSystem { get; private set; }
        /// <summary>
        /// Get a list containing the defective components
        /// </summary>
        public List<Component> DefectedComponents { get; private set; } = new List<Component>();

        #region Constructors
        public Warranty(DateTime date, SystemPC defectedSystem, IEnumerable<Component> defectedComponents)
        {
            Date = date;
            DefectedSystem = defectedSystem;
            DefectedComponents.AddRange(defectedComponents);
        }
        #endregion
    }
}
