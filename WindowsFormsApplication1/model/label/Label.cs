using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.maintenance;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.validation;
using WindowsFormsApplication1.model.DB;
using MyConstraint = WindowsFormsApplication1.model.validation.Constraint;
using WindowsFormsApplication1.model.asset;

namespace WindowsFormsApplication1.model.label
{
    public class Label
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public bool is_ordered { get; set; }
        public bool is_definer { get; set; }
        public bool is_enabled { get; set; }
        public string defaultvalue { get; set; }
        
        
        public virtual ICollection<Label> subLabels { get; set; }
        public virtual ICollection<Label> parents { get; set; }
        //TODO mishe hazfesh kard
        public virtual ICollection<AssignedLabel> instanceLabels { get; set; }
        public virtual DateTime date { get; set; }
        public virtual MyConstraint validvalues{get;set;}
        

        [NotMapped]
        public Label Self 
        {
            get { return this; }
        }
        [NotMapped]
        public static int DISCRETENUMBER = 1;
        
        [NotMapped]
        public static int CONTINUOUSNUMBER = 2;
        
        [NotMapped]
        public static int STRINGVAL = 3;
        public Label()
        {
            
            is_definer = false;
            is_enabled = true;
            type = STRINGVAL;
            is_ordered = false;
            subLabels = new List<Label>();
            parents = new List<Label>();
            validvalues = new MyConstraint();
            instanceLabels = new List<AssignedLabel>();
            //validvalues = new Constraint();
        }

       
        //Just For Test 
        public IQueryable<Asset> FindIncludingAsset() 
        {
            var query = from a in DBManager.datacontext.Assets
                        join b in DBManager.datacontext.AssignedLabels on a.id equals b.id
                        where b.label.id == this.id
                        select a;
            return query;
                           
                            
           //             where 
           /* List<Asset> result = new List<Asset>;
            foreach (AssignedLabel item in instanceLabels)
                if(!result.Contains(item.asset))
                    result.Add(item.asset);
            return result;*/
                  
                                             
        }
        public static IQueryable <Label> SelectAllLabels ()
        {
            return DBManager.datacontext.Labels.Where(label => label.is_enabled == true);
        }
        public bool IsValid(string value) 
        {
            
            if (validvalues == null)
                return true;
            Constthing temp ;
            if (type == Label.STRINGVAL)

                temp = new Constthing { values = value, type = Constthing.STRING };
            
            else
                temp = new Constthing { values = value, type = Constthing.NUM_REAL };
            
            DBManager.datacontext.Constthings.Add(temp);
            validvalues.thing1.Add(temp);
            DBManager.datacontext.SaveChanges();
            return validvalues.isValid() ;

        }
        public override int GetHashCode()
        {

            return id;
        }
        public override bool Equals(object obj)
        {
            var label = obj as Label;
            if (label == null || label.id != id)
                return false;
            return true;
        }
        public void Remove(bool withassginedlabels,bool withsuperlabels) 
        {
            IQueryable<AssignedLabel> temp = null;
            var db = DBManager.datacontext ;
            int count;
            if (!withassginedlabels && !withsuperlabels)
                this.is_enabled = false;
            if (withassginedlabels) 
            {
                temp = db.AssignedLabels.Where(assigned => assigned.label.id == this.id);
                count = temp.ToArray().Length;
                for (int i = 0; i < count; i++)
                {
                    
                    temp.ToArray()[i].Remove();
                }
                var alaki = temp.ToArray().Count();
            }
            if (withsuperlabels) 
            {
                foreach (Label item in parents)
                    item.subLabels.Remove(this);
            }
            if(withassginedlabels && withsuperlabels)
                db.Labels.Remove(this);
            //TODO remove constraint
            //int counter = validvalues.thing2.Count;
            //TODO
            /*for (int i = 0; i < counter; i++)
                DBManager.datacontext.Constthings.Remove(validvalues.thing2.ToArray()[0]);
            counter = validvalues.thing1.Count;
            for (int i = 0; i < counter; i++)
                DBManager.datacontext.Constthings.Remove(validvalues.thing1.ToArray()[0]);*/
            


        }
        public void SetValidValues(string[] values)
        {
            
            //TODO null check shavad
            if (validvalues != null)
            {
                //TODO
                int counter = validvalues.thing2.Count;
                for (int i = 0; i < counter; i++)
                    DBManager.datacontext.Things.Remove(validvalues.thing2.ToArray()[0]);
                validvalues.thing2.Clear();
            }
            else
            {
                validvalues = new Constraint();
                
            }
            if (values.Length == 0)
                return;
            
            Constthing temp;
            foreach (string value in values)
            {
                temp = new Constthing(value, Constthing.STRING);
                validvalues.thing2.Add(temp);
                
            }
            validvalues.relation = Relation.SUBSET;
            validvalues.AddToDB();
            //DBManager.datacontext.constraints.Add(validvalues);
            //DBManager.datacontext.SaveChanges();
        }
        public static IQueryable<Label> GetByName(string name)
        {
            return DBManager.datacontext.Labels.Where(label => label.name == name);
        }

        public void AddSubLabel(Label childlabel)
        {
             //if (!subLabels.Contains(childlabel))
                subLabels.Add(childlabel);
        }


        public void RemoveSubLabel(Label label)
        {
            subLabels.Remove(label);
        }


        public override string ToString()
        {
            return name;
        }

        public void Setminmaxvalues(string minvalue, string maxvalue)
        {
            if (validvalues != null)
            {
                int temp = validvalues.thing2.Count;
                for (int i = 0; i < temp; i++ )
                    DBManager.datacontext.Things.Remove(validvalues.thing2.ToArray()[0]);
               
            }
            else 
            {
                validvalues = new Constraint();
                DBManager.datacontext.constraints.Add(validvalues);
            }

            Constthing mintemp, maxtemp;
            minvalue = minvalue.Trim();
            maxvalue = maxvalue.Trim();
            if (minvalue == "")
                minvalue = (-Math.Pow(2, 30)).ToString();
            if (maxvalue == "")
                maxvalue = (Math.Pow(2, 30)).ToString();
            
            mintemp = new Constthing { values = minvalue, type=Constthing.NUM_REAL };
            maxtemp = new Constthing { values = maxvalue, type =Constthing.NUM_REAL };
            DBManager.datacontext.Constthings.Add(mintemp);
            DBManager.datacontext.Constthings.Add(maxtemp);
            validvalues.thing2.Add(mintemp);
            validvalues.thing2.Add(maxtemp);
            
            validvalues.relation = Relation.ININTERVAL;
            DBManager.datacontext.SaveChanges();
        }

        public string GetStringType()
        {
            //just for test

            if (type == DISCRETENUMBER)
                return "عدد گسسته";
            else if (type == CONTINUOUSNUMBER)
                return "عدد پیوسته";
            else
                return "مقدار رشته ای";
            
        }

       

        public string GetStringConstraint()
        {
            if (type == STRINGVAL)
            {
                if (validvalues != null && validvalues.thing2.Count > 0)
                {
                    string result = "";
                    for (int i = 0; i < validvalues.thing2.Count; i++)
                        result += validvalues.thing2.ToArray()[i] + ",";
                    result = result.Substring(0, result.Length - 1);

                    return "زیرمجموعه ی" + "{" + result + "}" + "باشد";
                }
                else
                    return "";
            }
            else

                try
                {
                    return "در بازه ی" + "[" + validvalues.thing2.ToArray()[0] + "," + validvalues.thing2.ToArray()[1] + "]" + "باشد";
                }
                catch (Exception)
                {

                    return "";
                }
        }

        public  bool IsMultipleChoice()
        {
            return type == STRINGVAL && validvalues.thing2.Count > 0;
        }
    }
}
