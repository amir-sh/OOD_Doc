#region

using System.Data.Entity;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.model.DB;
using WindowsFormsApplication1.model.label;
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
            var asset3 = new Asset
            {
                uId = "alaki",
                name = "دارایی های خیابان ازادی",
                date = System.DateTime.Today

            };
            var asset4 = new Asset
            {
                uId = "alaki",
                name = "پلیس خیابان آزادی",
                date = System.DateTime.Today

            };
            var label1 = new Label
            {
                name = "خیابان آزادی",
                date = System.DateTime.Today

            };

            var label2 = new Label
            {
                
                name = "خیابان جمهوری",
                date = System.DateTime.Today

            };
            var label3 = new Label
            {
                name = "دارایی های خیابان ازادی",
                date = System.DateTime.Today

            };
            var label4 = new Label
            {
                
                name = "پلیس خیابان آزادی",
                date = System.DateTime.Today

            };
            asset3.subAssets.Add(asset1);
            asset1.subAssets.Add(asset4);

            context.Assets.Add(asset1);
            context.Assets.Add(asset2);
            context.Assets.Add(asset3);
            context.Assets.Add(asset4);

            context.Labels.Add(label1);
            context.Labels.Add(label2);
            context.Labels.Add(label3);
            context.Labels.Add(label4);

        }
    }
}