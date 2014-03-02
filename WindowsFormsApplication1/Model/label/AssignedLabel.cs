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
    class AssignedLabel
    {
        [Key]
        public int id { get; set; }
        public Label label { get; set; }
        public ICollection<AssignedLabel> childrens { get; set; }
        public AssignedLabel Parent { get; set; }
        public Thing value { get; set; }
        public ICollection<Constraint> constraints { get; set; }

    }
}
