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
using WindowsFormsApplication1.model.DB;
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

        public override string ToString()
        {
            return name;
        }

        public static IQueryable <Asset> GetByName(string name)
        {
            return DBManager.datacontext.Assets.Where(asset => asset.name == name);
        }
        public void RemoveSubAsset(Asset asset) 
        {
          //  name = "کیر";
            subAssets.Remove(asset);
        }

        public void AddSubAsset(Asset childasset)
        {
            //TODO agar be onvane bache already hast 
            if(!subAssets.Contains(childasset))
                subAssets.Add(childasset);
        }
    }
}
