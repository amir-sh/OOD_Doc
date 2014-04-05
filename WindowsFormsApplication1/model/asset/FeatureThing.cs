using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.asset
{
    public class FeatureThing : Thing
    {

        public virtual string name { get; set; }
        public virtual Asset asset { get; set; }
        public virtual Constthing value {get; set;}


        public override string ToString()
        {
            return name;
        }
        public override string GetStringType()
        {
            return value.GetStringType();
        }
        public override int GetType()
        {
            return value.GetType();
        }
        public override bool IsLess(Thing thing)
        {
            return value.IsLess(thing);
        }
        public override string GetThingValue()
        {
            return value.GetThingValue(); 
        }
        public override bool IsEqual(Thing thing)
        {
            return value.IsEqual(thing);
        }
    }
}
