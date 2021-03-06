﻿using System;
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
        /// <summary>
        /// Returns the application directory path as a string.
        /// </summary>
        public static string ApplicationDirectoryPath = Application.StartupPath;

        /// <summary>
        /// Returns the connection string used for the application's database.
        /// </summary>
        public static string DataBaseConnectionString; /* = TBD */
    }
}
