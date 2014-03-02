using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.asset
{
    class AssetManager
    {
        [Key]
        public int id { get; set; }
        public ICollection<Asset> assets { get; set; }
    }
}
