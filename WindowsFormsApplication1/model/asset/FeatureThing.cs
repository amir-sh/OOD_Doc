using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.model.asset
{
    public class Feature
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public Constthing value {get; set;}
    }
}
