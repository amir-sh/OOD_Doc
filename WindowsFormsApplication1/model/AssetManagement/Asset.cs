using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model.LabelManagement;
using WindowsFormsApplication1.Model.AssetManagement.Attachment;

namespace WindowsFormsApplication1.Model.AssetManagement
{
    public class Asset
    {
        [Key]
        public int id { get; set; }
        public string uId { get; set; }
        public string name { get; set; }
        public Asset parent { get; set; }
        public virtual ICollection<Feature> features { get; set; }
        public virtual  ICollection<File> files { get; set; }
        public virtual ICollection<LabelInstance> labelInstances { get; set; }
        
    }
}
