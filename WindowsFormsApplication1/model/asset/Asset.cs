using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.model.label;
using WindowsFormsApplication1.model.validation;

namespace WindowsFormsApplication1.model.asset
{
    public class Asset
    {
        [Key]
        public int id { get; set; }
        public string uId { get; set; }
        public string name { get; set; }
        public ICollection<Asset> subAssets { get; set; }
        public ICollection<Asset> parents { get; set; }
        public ICollection<Feature> features { get; set; }
        public ICollection<AssignedLabel> labels { get; set; }
        public DateTime date { get; set; }
     
    }
}
