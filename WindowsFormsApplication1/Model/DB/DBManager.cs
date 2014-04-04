#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WindowsFormsApplicatoin1.model.DB;


#endregion

namespace WindowsFormsApplication1.model.DB
{
    public class DBManager
    {
        private static DatabaseContext _datacontext;

        public static DatabaseContext datacontext
        {
            get
            {
                if (_datacontext != null) return _datacontext;

                Database.SetInitializer(new DatabaseInitializer());
                _datacontext = new DatabaseContext();
                
                var dbExists = _datacontext.Database.Exists();

                if (dbExists)
                {
                    //UpgradeScript();
                }


           /*     if (!dbExists)
                    Database.SetInitializer(new DatabaseInitializer());
                else
                    Database.SetInitializer<DatabaseContext>(null); */
                return _datacontext;
            }
        }
    }
}
