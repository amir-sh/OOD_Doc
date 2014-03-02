using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.maintenance.function
{
    class ActionManager
    {
        [Key]
        public int id { get; set; }
        public ICollection<GeneralAction> actions { get; set; }
    }
}
