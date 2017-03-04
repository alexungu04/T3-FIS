using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.BuisnessLogic.Common.Utility
{
    public enum CurrencyType
    {
        RON = 1,
        USD = 0
    }

    public class Price
    {
        public float Value;

        public Price(float value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return String.Format("{0:0.00}", Value) + " RON" ;
        }

        public string ToString(CurrencyType type)
        {
            return String.Format("{0:0.00}", Value) + " " + CurrencyStringMap(type);
        }

        private string CurrencyStringMap(CurrencyType type)
        {
            switch (type)
            {
                case CurrencyType.RON:
                    return "RON";
                case CurrencyType.USD:
                    return "USD";
                default:
                    return "";
            }
        }
    }
}
