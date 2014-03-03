using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.validation
{
    public class Constraint
    {
        public Constraint()
        {
            thing1 = new List<Constthing>();
            thing2 = new List<Constthing>();
        }
        [Key]
        public int id { get; set; }
        public virtual ICollection<Constthing> thing1 { get; set; }
        public virtual ICollection<Constthing> thing2 { get; set; }
        public virtual Relation relation { get; set; }
    }
}
