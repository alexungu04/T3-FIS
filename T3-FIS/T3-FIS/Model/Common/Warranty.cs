using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public class Warranty
    {
        private DateTime Date;
        private SystemPC DefectedSystem;
        private List<Component> DefectedComponents = new List<Component>();

        #region Constructors
        public Warranty()
        {

        }
        #endregion
    }
}
