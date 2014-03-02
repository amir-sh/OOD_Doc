using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.label;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.maintenance.function
{
    public class Action
    {
        [Key]
        public int id { get; set; }
        public ICollection<Action> actions { get; set; }
        public string name { get; set; }
        public AssignedLabel label;
        public Constthing input;
        public ICollection<System.DateTime> dateofapplies { get; set; }

    }
}
