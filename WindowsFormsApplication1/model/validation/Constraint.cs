using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.DB;

namespace WindowsFormsApplication1.model.validation
{
    public class Constraint
    {
        //TODO
        public Constraint()
        {
            thing1 = new List<Thing>();
            thing2 = new List<Thing>();
        }
        [Key]
        public int id { get; set; }
        public virtual ICollection<Thing> thing1 { get; set; }
        public virtual ICollection<Thing> thing2 { get; set; }
        public int relation { get; set; }

        public bool isValid()
        {
            return Relation.apply(this,relation);
        }
        public void AddToDB() 
        {
            
            foreach (Constthing item in thing1)
                item.AddToDB();
            foreach (Constthing item in thing2)
                item.AddToDB();
            DBManager.datacontext.constraints.Add(this);
            DBManager.datacontext.SaveChanges();
        }
    }
}
