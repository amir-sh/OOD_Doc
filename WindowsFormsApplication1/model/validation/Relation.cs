using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.validation
{
    class Relation
    {
        [Key]
        public int id { get; set; }
        public ICollection<Thing> thing1 { get; set; }
        public ICollection<Thing> thing2 { get; set; }
        public int type { get; set; }
    }
}
