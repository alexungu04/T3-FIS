using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T3_FIS.Model.BuisnessLogic.Common.Utility;

namespace T3_FIS.Model.Common
{
    public class CustomSystemPC : SystemPC
    {
        #region Constructors
        public CustomSystemPC(string name, float price) : base(name, price)
        {
        }

        public CustomSystemPC(string name, Price price) : base(name, price)
        {
        }
        #endregion
    }
}
