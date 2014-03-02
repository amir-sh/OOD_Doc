using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.maintenance.function
{
    class GeneralAction
    {
        [Key]
        public int id { get; set; }
        public ICollection<Action> actions { get; set; }
        public string name { get; set; }
        public ICollection<GeneralAction> history { get; set; }
        public System.DateTime date { get; set; }

    }
}
