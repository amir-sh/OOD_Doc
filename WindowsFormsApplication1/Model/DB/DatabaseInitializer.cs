#region

using System.Data.Entity;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.model.DB;

#endregion

namespace WindowsFormsApplicatoin1.model.DB
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext> 
    {
        protected override void Seed(DatabaseContext context)
        {
            var asset1 = new Asset
            {
                uId = "alaki",
                name = "خیابان آزادی",
                date = System.DateTime.Today
                
            };

            var asset2 = new Asset
            {
                uId = "alaki",
                name = "خیابان جمهوری",
                date = System.DateTime.Today

            };

            context.Assets.Add(asset1);
            context.Assets.Add(asset2);
        }
    }
}