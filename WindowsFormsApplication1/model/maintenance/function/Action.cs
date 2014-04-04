using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.label;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.DB;

namespace WindowsFormsApplication1.model.maintenance.function
{
    public class Action
    {
        public Action()
        {
            actions = new List<Action>();
            dateOfApplies = new List<System.DateTime>();
            is_enable = true;
            newvalue = new Constthing();
            input = null;
            has_input = false;
        }
        
        [Key]
        public int id { get; set; }
        public virtual ICollection<Action> actions { get; set; }
        public virtual ICollection<Action> superactions { get; set; }
        public string name { get; set; }
        public bool has_input;
        public virtual AssignedLabel label { get; set; }
        //TODO
        
        public virtual Constthing newvalue { get; set; }
        public virtual Constthing input { get; set; }
        public virtual ICollection<System.DateTime> dateOfApplies { get; set; }
        public bool is_enable { get; set; }
        public  static IQueryable<Action> GetByName(string name)
        {
            return DBManager.datacontext.GeneralActions.Where(action => action.name == name && action.is_enable == true );
        }

        public void SetValue(string temp) 
        {
            newvalue.SetValues(newvalue.GetListofValues(temp ));
        }
        public void setValue(List<string> values)
        {
          //TODO
        }
        public override string ToString()
        {

            return name == null ? "" : name;
        }
        public static IQueryable<Action> SelectAllAction() 
        {
            return DBManager.datacontext.GeneralActions.Where(action => action.is_enable == true && action.name != null);
        }
        public void AddToDB() 
        {
            DBManager.datacontext.GeneralActions.Add(this);
            DBManager.datacontext.SaveChanges();
        }

        public  void Apply()
        {
            label.value.values = newvalue.values;
        }
    }
}
