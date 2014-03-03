using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.validation;

namespace WindowsFormsApplication1.model.label
{
    public class AssignedLabel
    {
        public AssignedLabel()
        {
            childrens= new List<AssignedLabel>();
            constraints = new List<Constraint>();
        }
        [Key]
        public int id { get; set; }
        public virtual Label label { get; set; }
        public virtual ICollection<AssignedLabel> childrens { get; set; }
        public virtual AssignedLabel Parent { get; set; }
        public virtual Constthing value { get; set; }
        public virtual ICollection<Constraint> constraints { get; set; }

    }
}
