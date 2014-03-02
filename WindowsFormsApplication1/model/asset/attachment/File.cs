using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.asset.attachment
{
    class File
    {
        [Key]
        public int id { get; set; }
        public string attribute1 { get; set; }
        public string attribute2 { get; set; }
    }
}
