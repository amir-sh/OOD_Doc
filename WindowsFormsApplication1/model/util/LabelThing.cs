using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.model.label;

namespace WindowsFormsApplication1.model.util
{
    public class LabelThing : Thing
    {
        [Key]
        public int id {get; set;}
        public AssignedLabel  assingnedlabel ;
    }
}
