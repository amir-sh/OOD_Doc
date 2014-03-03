using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.asset
{
    public class FeatureThing
    {
        [Key]
        public int id { get; set; }
        public virtual string name { get; set; }
        public virtual Asset asset { get; set; }
        public virtual Constthing value {get; set;}
    }
}
