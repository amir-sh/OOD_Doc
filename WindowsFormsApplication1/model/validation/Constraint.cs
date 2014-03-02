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
        [Key]
        public int id { get; set; }
        public ICollection<Constthing> thing1 { get; set; }
        public ICollection<Constthing> thing2 { get; set; }
        public Relation relation { get; set; }
    }
}
