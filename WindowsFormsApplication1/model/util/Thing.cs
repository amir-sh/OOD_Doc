using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.model.util
{
    public class Thing
    {
        const int NUM_CONNECTED=1;
        const int NUM_DISCERETE=2;
        const int NUM_ARRAY=3;
        const string seprator = ",,,";

        [Key]
        public int id { get; set; }
        public string values { get; set; }
        public int type { get; set; }

        Thing() {
            type = 0;
        }

        Thing(int bot, int top, Boolean connected)
        {
            values = bot.ToString() + seprator + top.ToString();
            if (connected)
                type = NUM_CONNECTED;
            else
                type = NUM_DISCERETE;
        }

        Thing(ICollection<String> array)
        {
            type = NUM_ARRAY;
            values = "";
            foreach (String part in array)
            {
                values += part + seprator;
            }
            if (array.Count() != 0)
            {
                values = values.Substring(0, values.Length - 3);
            }
        }

    }
}
