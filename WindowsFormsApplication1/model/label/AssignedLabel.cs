using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.validation;
using WindowsFormsApplication1.model.DB;
using WindowsFormsApplication1.model.asset ;

namespace WindowsFormsApplication1.model.label
{
    public class AssignedLabel
    {
        public AssignedLabel() 
        {
            children = new List<AssignedLabel>();
            constraints = new List<Constraint>();
            value = new Constthing();
        }       
        public AssignedLabel(Label input)
        {
            children= new List<AssignedLabel>();
            constraints = new List<Constraint>();
            label = input ;
            AssignedLabel temp ;
            foreach (Label templabel in label.subLabels)
            {
                temp = new AssignedLabel(templabel);
                children.Add(temp);
                temp.Parent = this;
            }
          
            value = new Constthing("", label.type);
        }
        public void AddToDB()
        {
            //TODO
            //foreach (AssignedLabel temp in children)
            //    temp.AddToDB();
            DBManager.datacontext.AssignedLabels.Add(this);
            
            //value.AddToDB();
            DBManager.datacontext.SaveChanges();
        }
        public void setValue(List<string> values) 
        {
            if (value == null)
            {
                value = new Constthing(values, label.type);
                //DBManager.datacontext.Constthings.Add(value);
            }
            else
                value.SetValues(values);
            //DBManager.datacontext.SaveChanges();
        }

        public override string ToString()
        {
            return label.ToString();
        }
        public Asset FindAsset() 
        {
            return FindRoot().asset;
        }
        public ICollection<Thing> GetValidValues() 
        {
            return label.validvalues.thing2;
        }
        [Key]
        public int id { get; set; }
        public virtual Label label { get; set; }
        public virtual ICollection<AssignedLabel> children { get; set; }
        public virtual AssignedLabel Parent { get; set; }
        public virtual Asset asset { get; set; }
        public virtual Constthing value { get; set; }
        public virtual ICollection<Constraint> constraints { get; set; }

        //TODO
        public void Remove() 
        {
            var db = DBManager.datacontext;
            //var myaction = db.GeneralActions.First(action => action.label.id == this.id);
            db.GeneralActions.RemoveRange(db.GeneralActions.Where(action => action.label.id == this.id));
            int temp = children.Count;
            for (int i = 0; i < temp; i++)
                children.ToArray()[0].Remove();
           
            db.Constthings.Remove(this.value);
            db.AssignedLabels.Remove(this);
            //TODO constraint

            //db.SaveChanges();
            
        }
        public AssignedLabel FindRoot()
        {
            if (Parent == null)
                return this;
            return Parent.FindRoot();
        }
        public override bool Equals(object obj)
        {
            var assignedlabel = obj as AssignedLabel;
            if (assignedlabel == null || assignedlabel.id != id)
                return false;
            return true;
        }
    }
}
