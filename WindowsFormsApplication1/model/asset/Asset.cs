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
        public Asset()
        {
            subAssets = new List<Asset>();
            parents = new HashSet<Asset>();
            features = new List<FeatureThing>();
            constraints = new List<Constraint>();
            labels = new List<AssignedLabel>();
        }
        
        [Key]
        public int id { get; set; }
        public string uId { get; set; }
        public string name { get; set; }
        public virtual  ICollection<Asset> parents { get; set; }
        public virtual ICollection<Asset> subAssets { get; set; }
        public virtual ICollection<FeatureThing> features { get; set; }
        public virtual ICollection<Constraint> constraints { get; set; }
        public virtual ICollection<AssignedLabel> labels { get; set; }
        public virtual DateTime date { get; set; }

    }
}
