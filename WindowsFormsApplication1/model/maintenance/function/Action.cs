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
        public Action()
        {
            actions = new List<Action>();
            dateOfApplies = new List<System.DateTime>();
        }
        [Key]
        public int id { get; set; }
        public virtual ICollection<Action> actions { get; set; }
        public string name { get; set; }
        public virtual AssignedLabel label { get; set; }
        public virtual Constthing input { get; set; }
        public virtual ICollection<System.DateTime> dateOfApplies { get; set; }

    }
}
