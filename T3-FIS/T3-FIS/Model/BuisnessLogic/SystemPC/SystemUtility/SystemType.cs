using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Common
{
    public class SystemType
    {
        private List<string> Types = new List<string>();

        #region Constructors
        public SystemType(string type)
        {
            Types.Add(type);
        }

        public SystemType(IEnumerable<string> types)
        {
            Types.AddRange(types);
        }
        #endregion

        public void AddSubtype(string type)
        {
            Types.Add(type);
        }

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
