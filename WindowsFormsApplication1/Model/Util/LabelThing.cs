using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WindowsFormsApplication1.Model.AssetManagement;
using WindowsFormsApplication1.Model.LabelManagement;

namespace WindowsFormsApplication1.Model.Util
{
    class LabelThing : Thing
    {
        [Key]
        public int id {get; set;}
        public virtual LabelInstance assingnedlabel ;
    }
}
