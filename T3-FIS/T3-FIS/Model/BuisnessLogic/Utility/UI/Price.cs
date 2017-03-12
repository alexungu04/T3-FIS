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
        EUR = 2,
        USD = 3
    }

    public class Price
    {
        public float Value { get; private set; }

        /// <summary>
        /// Used to describe a price.
        /// </summary>
        public Price(float value)
        {
            Value = value;
        }

        /// <summary>
        /// Returns a formated string representing the price value in "RON".
        /// </summary>
        public override string ToString()
        {
            return String.Format("{0:0.00}", Value) + " RON" ;
        }

        /// <summary>
        /// Returns a formated string representing the price value in whatever currency type is provided.
        /// </summary>
        /// <param type="CurrencyType"></param>
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
                case CurrencyType.EUR:
                    return "EUR";
                default:
                    return "";
            }
        }
    }
}
