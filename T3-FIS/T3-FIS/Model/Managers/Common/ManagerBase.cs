using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_FIS.Model.Managers
{
    public abstract class ManagerBase
    {
        //private DataBaseOBJ DataBase;

        public ManagerBase()
        {
            LoadFromDB();
        }

        public void SaveToDB()
        {
            throw new NotImplementedException();
        }

        private void LoadFromDB()
        {
            throw new NotImplementedException();
        }
    }
}
