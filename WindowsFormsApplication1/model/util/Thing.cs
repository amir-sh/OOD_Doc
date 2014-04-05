using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.util
{
   
    public class Thing
    {
        
        
        [Key]
        public int id {get; set;}
        public string name;
        
        [NotMapped]
        public static int NUM_INTEGER = 0;
        [NotMapped]
        public static int NUM_REAL = 1;
        [NotMapped]
        public static int STRING = 2;
        [NotMapped]
        public static int BOOLEAN = 3;

        public override bool Equals(object obj)
        {
            var thing = obj as Thing;
            if (thing == null || thing.id != id)
                return false;
            return true;
        }
        public override int GetHashCode()
        {
            return id;
        }
        public virtual bool IsEqual(Thing thing)
        {
            return true;
        }
        public virtual bool IsLess(Thing thing) 
        {
            return true;
        }
        public virtual string GetThingValue()
        {
            return "";
        }
        public virtual string GetStringType()
        {
            return "";
        }
        public virtual int GetType()
        {
            return 0;
        }
    }
}
