using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.maintenance.function;

namespace WindowsFormsApplication1.model.maintenance.occurrence
{
    public class Event
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public Action action { get; set; }
        public string description { get; set; }
    }
}
