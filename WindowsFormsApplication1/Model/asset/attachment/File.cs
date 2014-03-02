using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.asset.attachment
{
    public class File
    {
        [Key]
        public int id { get; set; }
        public string address { get; set; }
        public string name { get; set; }
    }
}
