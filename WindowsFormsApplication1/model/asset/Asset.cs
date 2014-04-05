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
            is_enabled = true;
        }
        
        [Key]
        public int id { get; set; }
        public string uId { get; set; }
        public string name { get; set; }
        public bool is_enabled { get; set; }
        public virtual  ICollection<Asset> parents { get; set; }
        public virtual ICollection<Asset> subAssets { get; set; }
        public virtual ICollection<FeatureThing> features { get; set; }
        public virtual ICollection<Constraint> constraints { get; set; }
        /*[NotMapped]
        public virtual IQueryable<AssignedLabel> labels 
        {
            get { return DBManager.datacontext.AssignedLabels.Where(label=> label.asset.id == this.id;}
        }*/
        
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
        public IQueryable<Asset> GetByNames(string name)
        {
            return DBManager.datacontext.Assets.Where(asset => asset.name == name);
        }
        public void RemoveSubAsset(Asset asset) 
        {
          
            subAssets.Remove(asset);
        }

        public void AddSubAsset(Asset childasset)
        {
            //TODO agar be onvane bache already hast 
            if(!subAssets.Contains(childasset))
                subAssets.Add(childasset);
        }

        public AssignedLabel FindAssignedLabel(Label curlabel)
        {
            foreach (AssignedLabel item in labels) 
            {
                if (item.label.id == curlabel.id)
                    return item;
            }
            return null;
            //var db = DBManager.datacontext;
            //return db.AssignedLabels.Where(assigned => assigned.label.id == curlabel.id).Intersect(this.labels);
            //.Where(assigned => this.labels.Contains(assigned));
        }

        public bool isAttached(AssignedLabel item)
        {

            foreach (AssignedLabel label in labels) 
            {
                if (item.id == label.id)
                    return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            var asset = obj as Asset;
            if (asset == null || asset.id != id)
                return false;
            return true;
        }

        public void Detach(AssignedLabel curassignedlabel)
        {
            curassignedlabel.Remove();
            //labels.Remove(curassignedlabel);
        }

        public static IQueryable<object> SelectAllAsset()
        {
            return DBManager.datacontext.Assets.Where(asset => asset.is_enabled == true);
        }
    }
}
