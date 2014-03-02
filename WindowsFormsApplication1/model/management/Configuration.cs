using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.management
{
    public class Configuration
    {
        [Key]
        public int id { get; set; }
        public string managerPassword { get; set; }
        public string employeePassword { get; set; }
        public string backerPassword { get; set; }
    }
}
