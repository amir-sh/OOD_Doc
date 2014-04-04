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
        public override bool Equals(object obj)
        {
            var thing = obj as Thing;
            if (thing == null || thing.id != id)
                return false;
            return true;
        }
    }
}
