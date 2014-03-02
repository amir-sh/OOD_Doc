using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.label
{
    class LabelManager
    {
        [Key]
        public int id { get; set; }
        public ICollection<Label> labels { get; set; }
        public string attribute { get; set; }
    }
}
