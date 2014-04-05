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
        

        
        const string seprator = ",,,";

        
        public string values { get; set; }
        public int type { get; set; }

        public override int GetType()
        {

            return type;
        }
        public override string GetThingValue()
        {
            return values;
        }
        public override bool IsEqual(Thing thing)
        {
            //TODO
            if (this.type != thing.GetType() && this.type + thing.GetType() < 2)
                return false;
            else if (this.type == Thing.BOOLEAN)
                return Boolean.Parse(values) == Boolean.Parse(thing.GetThingValue());
            else if (this.type == Thing.STRING)
                return isEqualList(getListofValues(), getListofValues(thing.GetThingValue()));
            else
                return Double.Parse(values) == Double.Parse(thing.GetThingValue());
        }
        public override string GetStringType()
        {
            if (type == STRING)
                return "مقدار رشته‌ای";
            if (type == NUM_REAL)
                return "مقدار اعشاری";
            if (type == NUM_INTEGER)
                return "مقدار صحیح";
            if (type == BOOLEAN)
                return "مقدار بولین";
            return "";
        }
        public override bool IsLess(Thing thing)
        {
            //TODO
            if (this.type == BOOLEAN)
                return false;
            if (this.type == STRING)
                return false;
            return Double.Parse(values) < Double.Parse(thing.GetThingValue());
        }
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
        public bool isEqualList(List<string> data1, List<string> data2) 
        {
            //TODO
            if (data1.Count() != data2.Count())
                return false;
            foreach (string item in data1)
                if (!data2.Contains(item))
                    return false;
            foreach (string item in data2)
                if (!data1.Contains(item))
                    return false;
            return true;
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
