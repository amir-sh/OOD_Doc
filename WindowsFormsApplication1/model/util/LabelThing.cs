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
        
        
        public virtual AssignedLabel assignedlabel { get; set; }
        public override string GetThingValue()
        {
            return assignedlabel.value.GetThingValue();
        }
        public override int GetType()
        {
            return assignedlabel.value.GetType();
        }

        public override bool IsLess(Thing thing)
        {
            return this.assignedlabel.value.IsLess(thing);
        }
        public override bool IsEqual(Thing thing)
        {
            return assignedlabel.value.IsEqual(thing);
        }
        public override string GetStringType()
        {
            return assignedlabel.value.GetStringType();
        }
    }
}
