using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.maintenance;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.validation;

namespace WindowsFormsApplication1.model.label
{
    public class Label
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Label> subLabels { get; set; }
        public ICollection<Label> parents { get; set; }
        public ICollection<AssignedLabel> instanceLabels { get; set; }
        public DateTime date { get; set; }
        public ICollection<Constraint> constraints { get; set; }
    }
}
