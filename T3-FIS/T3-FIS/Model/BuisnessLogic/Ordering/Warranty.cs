using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public class Warranty
    {
        public DateTime Date { get; private set; }
        public SystemPC DefectedSystem { get; private set; }
        public List<Component> DefectedComponents { get; private set; } = new List<Component>();

        #region Constructors
        public Warranty(DateTime date, SystemPC defectedSystem, IEnumerable<Component> defectedComponents)
        {

        }
        #endregion
    }
}
