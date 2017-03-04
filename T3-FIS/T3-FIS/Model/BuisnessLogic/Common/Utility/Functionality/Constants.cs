using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3_FIS.Model.BuisnessLogic.Common
{
    public static class Constants
    {
        public static string ApplicationDirectoryPath = Application.StartupPath;
        public static string DataBaseDirectoryPath = Path.Combine(Application.StartupPath, "data", "dataBase");
    }
}
