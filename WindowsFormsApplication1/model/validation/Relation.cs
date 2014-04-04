using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.validation
{
    public class Relation
    {
        
        public static int SUBSET = 1;
        public static int ININTERVAL = 2;
        public Relation() 
        {
            
        }
        public static bool apply(Constraint input,int type)
        {

            if (type == SUBSET)
                return Relation.contain(input.thing2.ToList(),input.thing1.ToArray()[0].values);
            if (type == ININTERVAL)
                return (double)input.thing2.ToArray()[0].GetValue() <= (double)input.thing1.ToArray()[0].GetValue() &&
                    (double)input.thing2.ToArray()[1].GetValue() >= (double)input.thing1.ToArray()[0].GetValue();
            return true;
        }
        public static bool contain(List<Constthing> list,string key) 
        {
            foreach (Constthing item in list)
                if (item.values.Equals(key))
                    return true;
            return false;
        }
    }
}
