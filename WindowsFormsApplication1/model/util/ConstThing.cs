using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.DB;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApplication1.model.util
{
    public class Constthing  :Thing 
    {
        

        [NotMapped]
        public static int NUM_INTEGER=1;
        [NotMapped]
        public static int NUM_REAL=2;
        [NotMapped]
        public static int STRING=3;
        [NotMapped]
        public static int BOOLEAN = 4;
        const string seprator = ",,,";

        
        public string values { get; set; }
        public int type { get; set; }

        public object GetValue() 
        {
            if (type == STRING)
                return values;
            else if (type == BOOLEAN)
                return Boolean.Parse(values);
            else
                return Double.Parse(values);
        }
        public void AddState(string s) 
        {
            if (values != "")
                values += seprator + s;
            
            else 
                values += s ;
        }
        public List<string> GetListofValues(string temp = null)
        {
            int index = 0;
            List<string> listvalues = new List<string>();
            string value = temp == null ? values : temp;
            if (value == "")
                return listvalues;
            while(index != -1)
            {
                if(value.IndexOf(",",index) == -1)
                    listvalues.Add(value.Substring(index));
                else
                    listvalues.Add(value.Substring(index, value.IndexOf(",", index)));
                index = value.IndexOf(",", index);
            }
            return listvalues; 
        }
        public override string ToString()
        {
            string result=values;
            if (type == STRING) 
            {
                result=values.Replace(seprator, ",");
                if(values.IndexOf(",") != -1)
                    result = "{" + result + "}";
                
            }
            return result;
        }
        public Constthing() {
            type = 0;
            values = "";
        }
        public override bool Equals(object obj)
        {
            var constthing = obj as Constthing;
            if (constthing == null || constthing.id != id)
                return false;
            return true;
        }
        public Constthing(Object value, int ttype) 
        {
            this.type = ttype;
            //TODO
            //if (type == STRING) 
            //{
                values = (string)value;
            //}
        }
        Constthing(int bot, int top, Boolean connected)
        {
            values = bot.ToString() + seprator + top.ToString();
            /*if (connected)
                type = NUM_CONNECTED;
            else
                type = NUM_DISCERETE;*/
        }

        Constthing(ICollection<String> array)
        {
            //type = NUM_ARRAY;
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

        //TODO az values be meghdar biad
        public void SetValues(List<string> inputvalue)
        {
            values = "";
            foreach (string input in inputvalue) 
            {
                values += input;
                values += seprator;
            }
            if (inputvalue.Count() != 0)
            {
                values = values.Substring(0, values.Length - 3);
            }
            
        }

        public List<string> getListofValues(string input = null)
        {
            string temp = input == null ? values : input;
            int index = 0;
            List<string> listvalues = new List<string>();
            while (index != -1)
            {
                if (temp.IndexOf(seprator, index) == -1)
                    listvalues.Add(temp.Substring(index));
                else
                    listvalues.Add(temp.Substring(index, temp.IndexOf(seprator, index)));
                index = temp.IndexOf(seprator, index);
            }
            return listvalues;
        }


        public void AddToDB()
        {
            DBManager.datacontext.Constthings.Add(this);
            //DBManager.datacontext.SaveChanges();
        }
    }
}
