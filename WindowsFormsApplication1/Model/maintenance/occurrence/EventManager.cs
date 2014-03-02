using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.maintenance.occurrence
{
    class EventManager
    {
        [Key]
        public int id { get; set; }
        public ICollection<Event> events { get; set; }

    }
}
