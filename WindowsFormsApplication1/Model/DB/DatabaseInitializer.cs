#region

using System.Data.Entity;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.model.DB;
using WindowsFormsApplication1.model.label;
using WindowsFormsApplication1.model.maintenance.function;
using WindowsFormsApplication1.model.util;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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
            var assignedlabel = new AssignedLabel(label1);
            var assignedlabel1 = new AssignedLabel(label1);
            var action1 = new Action { name = "fuck" };
            var action2 = new Action();
            var action3 = new Action();
            var action4 = new Action();

            //assignedlabel.children.Add(assignedlabel1);
            action1.label = assignedlabel;
           // action2.label = assignedlabel1;
            
          //  action3.actions.Add(action1);
          //  action3.actions.Add(action2);
          //  action4.actions.Add(action1);
          //  action3.actions.Add(action4);
            label1.validvalues.thing2.Add(new Constthing("salam",Constthing.STRING));
            label1.validvalues.thing2.Add(new Constthing("salamati", Constthing.STRING));
            asset3.subAssets.Add(asset1);
            asset1.subAssets.Add(asset4);
            label4.subLabels.Add(label1);
            context.AssignedLabels.Add(assignedlabel);
            context.AssignedLabels.Add(assignedlabel1);
            context.GeneralActions.Add(action1);
            //context.SaveChanges();
            //context.AssignedLabels.Remove(assignedlabel);
            //context.GeneralActions.Remove(action1);
            context.Assets.Add(asset1);
            context.Assets.Add(asset2);
            context.Assets.Add(asset3);
            context.Assets.Add(asset4);

            
            context.Labels.Add(label1);
            context.Labels.Add(label2);
            context.Labels.Add(label3);
            context.Labels.Add(label4);
            context.SaveChanges();
            //assignedlabel.Remove();
            label1.Remove(true);
           
            context.SaveChanges();
        }
    }
}