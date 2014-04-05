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

        public static int EQUAL = 1;
        public static int LESS = 2;
        public static int GREATER = 3;
        public static int LESSOREQUAL = 4;
        public static int GREATEROREQUAL = 5;
        public static int ISELEMENT = 6;
        public static int ISCONTAIN = 7;
        public static int ISNOTELEMENT = 8;
        public static int ISNOTCONTAIN = 9;
        public static int ISNOTEQUAL = 10;
        public static int SUBSET = 11;
        public static int ININTERVAL = 12;
        
        private static Relation _relation;

        public static Relation relation
        {
            get
            {
                if (_relation != null) 
                    return _relation;
                _relation = new Relation();
                return _relation;
            }
        }

        public bool Check(Constraint input, int type) 
        {
            //TODO baraye bozorgo koochiki
            if (type == EQUAL)
                return IsEqual(input.thing1, input.thing2);
            if (type == LESS)
                return IsLess(input.thing1.ToArray()[0], input.thing2.ToArray()[0]);
            if (type == GREATER)
                return IsLess(input.thing2.ToArray()[0], input.thing1.ToArray()[0]);
            if (type == LESSOREQUAL)
                return !IsLess(input.thing2.ToArray()[0], input.thing1.ToArray()[0]);
            if (type == GREATEROREQUAL)
                return !IsLess(input.thing1.ToArray()[0], input.thing2.ToArray()[0]);
            if (type == ISELEMENT)
                return IsElement(input.thing1.ToArray()[0], input.thing2);
            if (type == ISCONTAIN)
                return IsElement(input.thing2.ToArray()[0], input.thing1);
            if (type == ISNOTELEMENT)
                return !IsElement(input.thing1.ToArray()[0], input.thing2);
            if (type == ISNOTCONTAIN)
                return !IsElement(input.thing2.ToArray()[0], input.thing1);
            if (type == ISNOTEQUAL)
                return IsEqual(input.thing1, input.thing2);
            
            return true;
        }
        
        public static bool apply(Constraint input,int type)
        {
           // if ( type == EQUAL)
            //    return Relation.

            if (type == SUBSET)
                return Relation.contain(input.thing2.ToList(),((Constthing)(input.thing1.ToArray()[0])).values);
            if (type == ININTERVAL)
                return (double)(((Constthing)(input.thing2.ToArray()[0])).GetValue()) <= (double)(((Constthing)(input.thing1.ToArray()[0])).GetValue()) &&
                    (double)(((Constthing)(input.thing2.ToArray()[1])).GetValue()) >= (double)(((Constthing)(input.thing1.ToArray()[0])).GetValue());
            return true;
        }
        public bool IsElement(Thing elem, ICollection<Thing> set) 
        {
            foreach (Thing item in set)
                if (item.IsEqual(elem))
                    return true;
            return false;
        }
        public bool IsSubset(ICollection<Thing> set1,ICollection<Thing> set2) 
        {
            foreach (Thing item in set1)
                if (!IsElement(item, set2))
                    return false;
            return true;
        }
        public bool IsEqual(ICollection<Thing> set1, ICollection<Thing> set2) 
        {
            return IsSubset(set1, set2) && IsSubset(set2, set1);
        }
        public bool IsLess(Thing thing1, Thing thing2) 
        {
            
            return thing1.IsLess(thing2);
        }

        public static bool contain(List<Thing> list,string key) 
        {
            foreach (Thing item in list)
                if (((Constthing)item).values.Equals(key))
                    return true;
            return false;
        }
    }
}
