using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Model.AssetManagement
{
    public class Feature
    {
        [Key]
        public int id { get; set; }
        public Asset asset { get; set; }

    }
}
