using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;

namespace T3_FIS.Model.Common
{
    public class PromotionalPackage : Product
    {
        private float PriceReduction;
        private List<SystemPC> Systems = new List<SystemPC>();

        #region Constructors
        public PromotionalPackage(string name, float price) : base(name, price)
        {
        }

        public PromotionalPackage(string name, Price price) : base(name, price)
        {
        }
        #endregion
    }
}
