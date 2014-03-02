using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.validation
{
    public class Relation
    {

        [Key]
        public int id { get; set; }
        public bool apply(int type, Constraint input)
        {
            return true;
        }
    }
}
