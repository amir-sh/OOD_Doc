using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.forms.Utility;
using WindowsFormsApplication1.forms.Utility.Errors;
using WindowsFormsApplication1.model.DB;
using MyLabel = WindowsFormsApplication1.model.label.Label;

//TODO
//meghdar pish farz baraye strign
namespace WindowsFormsApplication1.forms.barchasb
{
    public partial class CreateBarchasb : UserControl
    {
        public CreateBarchasb()
        {
            InitializeComponent();
        }
        protected virtual void Reset() 
        {
            FormLoad.Empty(true, NewLabelTextbox, MinValTexbox, MaxValTextbox, DefaultValTextbox, StatesListbox, ContinuosRbutton, DiscreteRbutton,
                radioButton3, AddedStateTextbox, RemoveStateCombobox);
            FormLoad.Empty(false, checkedListBox1);

        }
        private void UpButton_Click(object sender, EventArgs e)
        {
            int currentindex = StatesListbox.SelectedIndex;
            Object temp = StatesListbox.Items[currentindex] ;
            if (currentindex > 0) 
            {
                StatesListbox.Items[currentindex]  =    StatesListbox.Items[currentindex-1];
                StatesListbox.Items[currentindex-1] = temp ;
            }
                
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int otherindex = 1-e.Index ;
            var currnetstate = checkedListBox1.GetItemCheckState(e.Index) ;
            var relatedgroup = e.Index == 1 ? DiscreteGroup : IntGroup;

            if (currnetstate == CheckState.Unchecked)
            {
                relatedgroup.Enabled = true;
                checkedListBox1.SetItemCheckState(otherindex, CheckState.Unchecked);
            }
            else
                relatedgroup.Enabled = false;
            
        }

        private void DiscreteRbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (DiscreteRbutton.Checked)
                ContinuosRbutton.Checked = false;
        }

        private void ContinuosRbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (ContinuosRbutton.Checked)
                DiscreteRbutton.Checked = false;
        }

        private bool AddState(string state) 
        {
            if (state == null)
                return false;
            if (!StatesListbox.Items.Contains(state))
            {
                StatesListbox.Items.Add(state);
                RefreshcomboBox();
                return true;
            }
            return false;
        }
        private bool RemoveState(string state) 
        {
            StatesListbox.Items.Remove(state);
            RefreshcomboBox();
            return true;
        }
        private void AddStateButton_Click(object sender, EventArgs e)
        {
            var state = AddedStateTextbox.Text;
            AddState(state);

        }
        private void RefreshcomboBox() 
        {
            List<Object> temp = new List<Object>();
            foreach (Object item in StatesListbox.Items)
                temp.Add(item);
            FormLoad.Refresh(RemoveStateCombobox, temp.ToArray());
        }

        private void RemoveStateButton_Click(object sender, EventArgs e)
        {
            var removedstate = RemoveStateCombobox.SelectedItem;
            RemoveState(removedstate.ToString());
        }

        private void StatesListbox_DoubleClick(object sender, EventArgs e)
        {
            var currentstate = StatesListbox.SelectedItem;
            if (currentstate != null)
                RemoveState(currentstate.ToString()); 
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            int currentindex = StatesListbox.SelectedIndex;
            Object temp = StatesListbox.Items[currentindex];
            if (currentindex < StatesListbox.Items.Count-1)
            {
                StatesListbox.Items[currentindex] = StatesListbox.Items[currentindex + 1];
                StatesListbox.Items[currentindex + 1] = temp;
            }
        }

        protected bool IsDiscreteReadyToCreate() 
        {
            //TODO
            return true;
        }
        protected bool IsIntReadyToCreate(int labeltype= -1) 
        {
            //TODO 
            // valid boodane default value check shavad
            
            int count =(DiscreteRbutton.Checked==true ? 1 : 0) + (ContinuosRbutton.Checked==true ? 1 : 0);
            if (GeneralErrors.IsZero(count, "وضعیت عددی"))
                return false;
            if (labeltype == MyLabel.CONTINUOUSNUMBER)
            {
                if (!DomainSpecErrors.IsDouble(MinValTexbox.Text, "مقدار کمینه") ||
                !DomainSpecErrors.IsDouble(MaxValTextbox.Text, "مقدار بیشینه") ||
                !DomainSpecErrors.IsDouble(DefaultValTextbox.Text, "مقدار پیش فرض"))
                    return false;
            }
            if (labeltype == MyLabel.DISCRETENUMBER)
            {
                if (
                !DomainSpecErrors.IsInteger(MinValTexbox.Text, "مقدار کمینه") ||
                !DomainSpecErrors.IsInteger(MaxValTextbox.Text, "مقدار بیشینه") ||
                !DomainSpecErrors.IsInteger(DefaultValTextbox.Text, "مقدار پیش فرض"))
                    return false;
            }

            return true;
        }
        protected bool IsReadyToCreate() 
        {
            if (GeneralErrors.IsEmptyField(NewLabelTextbox.Text, "نام برچسب", ""))
                return false;
            if (GeneralErrors.IsZero(checkedListBox1.CheckedItems.Count, "حالت برای مقدار برچسب"))
                return false;
            if (checkedListBox1.CheckedIndices.Contains(0))
                return IsIntReadyToCreate();
            else 
                return IsDiscreteReadyToCreate();
            
        }
        private void CreateLabel() 
        {
            string labelname = NewLabelTextbox.Text;
            int labeltype = checkedListBox1.CheckedIndices.Contains(0) ? (DiscreteRbutton.Checked == true ? MyLabel.DISCRETENUMBER : MyLabel.CONTINUOUSNUMBER) :
                MyLabel.STRINGVAL;
            bool isdefiner = radioButton3.Checked;
            
            var label = new MyLabel
            {
                name = labelname,
                type = labeltype,
                is_definer = isdefiner,
                date = System.DateTime.Today
            };
            
            if (labeltype == MyLabel.STRINGVAL)
            {
                //GeneralErrors.AccessDenied();
                List<string> temp = new List<string>();
                foreach (string item in StatesListbox.Items)
                    temp.Add(item);
                label.SetValidValues(temp.ToArray());
                label.is_ordered = OrderRadiobutton.Checked;
                //just for test
                
                
            }
            if (labeltype == MyLabel.CONTINUOUSNUMBER || labeltype == MyLabel.DISCRETENUMBER) 
            {
                if(!IsIntReadyToCreate(labeltype))
                    return ;
                string minvalue = MinValTexbox.Text;
                string maxvalue = MaxValTextbox.Text;
                label.defaultvalue = DefaultValTextbox.Text;
                label.Setminmaxvalues(minvalue, maxvalue);
            }
            PopUp.ShowSuccess("label is created");
            DBManager.datacontext.Labels.Add(label);
            DBManager.datacontext.SaveChanges();
            
        }
        protected virtual void CreateButton_Click(object sender, EventArgs e)
        {
            //TODO
           
            if(!IsReadyToCreate())
                return ;
            CreateLabel();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DiscreteGroup_Enter(object sender, EventArgs e)
        {

        }

        private void RemoveStateCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddedStateTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IntGroup_Enter(object sender, EventArgs e)
        {

        }

        private void DefaultValTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MaxValTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinValTexbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewLabelTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
