﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.model.maintenance;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.validation;
using WindowsFormsApplication1.model.DB;
namespace WindowsFormsApplication1.model.label
{
    public class Label
    {
        public Label()
        {
            subLabels = new List<Label>();
            parents = new List<Label>();
            instanceLabels = new List<AssignedLabel>();
            constraints = new List<Constraint>();
        }
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Label> subLabels { get; set; }
        public virtual ICollection<Label> parents { get; set; }
        public virtual ICollection<AssignedLabel> instanceLabels { get; set; }
        public virtual DateTime date { get; set; }
        public virtual ICollection<Constraint> constraints { get; set; }


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
    }
}
