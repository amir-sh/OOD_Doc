using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.forms.Utility.Errors;
using WindowsFormsApplication1.forms.Utility;
using WindowsFormsApplication1.model.DB;
using MyLabel = WindowsFormsApplication1.model.label.Label;

namespace WindowsFormsApplication1.forms.barchasb
{
    public partial class UpdateLabel : WindowsFormsApplication1.forms.barchasb.CreateBarchasb
    {
        private MyLabel curlabel ;
        public UpdateLabel()
        {
            InitializeComponent();
            
        }


        protected override void CreateButton_Click(object sender, EventArgs e)
        {
            UpdateTheLabel();
        }

       
        private void NewLabelTextbox_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(NewLabelTextbox, DBManager.datacontext.Labels);
        }

        private void NewLabelTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                var labels = MyLabel.GetByName(NewLabelTextbox.Text).ToArray();
                if (labels.Length > 0)
                    curlabel = labels[0];
                PrepareFormWithLabel(curlabel);
            }
        }

        private void UpdateTheLabel() 
        {
            int labeltype = checkedListBox1.CheckedIndices.Contains(0) ? (DiscreteRbutton.Checked == true ? MyLabel.DISCRETENUMBER : MyLabel.CONTINUOUSNUMBER) :
                MyLabel.STRINGVAL;
            bool isdefiner = radioButton3.Checked;
            curlabel.type = labeltype;

            if (labeltype == MyLabel.STRINGVAL)
            {
                //valid boodan va pish farz check shavad
                //GeneralErrors.AccessDenied();
                List<string> temp = new List<string>();
                foreach (string item in StatesListbox.Items)
                    temp.Add(item);
                curlabel.SetValidValues(temp.ToArray());
                curlabel.is_ordered = OrderRadiobutton.Checked;
                //just for test


            }
            if (labeltype == MyLabel.CONTINUOUSNUMBER || labeltype == MyLabel.DISCRETENUMBER)
            {
                if (!IsIntReadyToCreate(labeltype))
                    return;
                string minvalue = MinValTexbox.Text;
                string maxvalue = MaxValTextbox.Text;
                curlabel.defaultvalue = DefaultValTextbox.Text;
                curlabel.Setminmaxvalues(minvalue, maxvalue);
                
            }
            PopUp.ShowSuccess(String.Format("برچسب {0} به روز رسانی شد",curlabel.name));
           
            DBManager.datacontext.SaveChanges();
        }
        private void PrepareFormWithLabel (MyLabel label)
        {
            var temp = NewLabelTextbox.Text;
            Reset();
            NewLabelTextbox.Text = temp;
            radioButton3.Checked = label.is_definer;
            if (label.type == MyLabel.STRINGVAL)
            {
                OrderRadiobutton.Checked = label.is_ordered;
                checkedListBox1.SetItemChecked(1, true);
                for (int i = 0; i < label.validvalues.thing2.Count(); i++)
                    StatesListbox.Items.Add(label.validvalues.thing2.ToArray()[i]);
            }
            else
            {
                checkedListBox1.SetItemChecked(0, true);
                MinValTexbox.Text = label.validvalues.thing2.ToArray()[0].values;
                MaxValTextbox.Text = label.validvalues.thing2.ToArray()[1].values;
                DefaultValTextbox.Text = label.defaultvalue;
                if (label.type == MyLabel.DISCRETENUMBER)
                    DiscreteRbutton.Checked = true;
                else
                    ContinuosRbutton.Checked = true;
            }
            
        }
    }
}
