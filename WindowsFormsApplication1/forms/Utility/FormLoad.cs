using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.model.util;
namespace WindowsFormsApplication1.forms.Utility
{
    public class FormLoad
    {
       
    
    
        public static void SetEnable(bool enable, params Control[] controls)
        {
            foreach (var control in controls)
                control.Enabled = enable;
        }

        public static void Empty(bool complete = true,params Control[] controls)
        {
            foreach (var control in controls)
            {
                var combobox = control as ComboBox;
                if (combobox != null)
                    EmptyComboBox(combobox,complete);

                var checkList = control as CheckedListBox;
                if (checkList != null)
                {
                    EmptyCheckedListBox(checkList,complete);
                }
                var checkBox = control as CheckBox;
                if (checkBox != null)
                {
                    EmptyCheckBox(checkBox,complete);
                    continue;
                }
                var listBox = control as ListBox;
                if (listBox != null)
                    EmptyListBox(listBox,complete);
                
                var treeview = control as TreeView;
                if (treeview != null)
                    EmptyTreeView(treeview,complete);
                
                var radiobutton =control as RadioButton;
                if(radiobutton != null )
                    EmptyRadioButton(radiobutton,complete);

                var textbox = control as TextBox;
                if(textbox !=null)
                    EmptyControl(textbox);
            }
        }

        private static void EmptyRadioButton(RadioButton radiobutton, bool complete)
        {
            radiobutton.Checked = false;
        }

        private static void EmptyTreeView(TreeView treeview,bool complete = true)
        {

            treeview.Nodes.Clear();
        }

        private static void EmptyControl(Control control,bool complete=true)
        {
            control.Text = "";
        }

        private static void EmptyCheckBox(CheckBox checkBox,bool complete=true)
        {
            checkBox.Checked = false;
        }

        private static void EmptyListBox(ListBox listBox,bool complete=true)
        {
            listBox.SelectedItems.Clear();
            listBox.SelectedIndices.Clear();
            listBox.ClearSelected();
            if (complete)
                listBox.Items.Clear();
        }

        private static void EmptyComboBox(ComboBox comboBox,bool complete=true)
        {
            comboBox.SelectedItem = null;
            comboBox.SelectedIndex = -1;
            if (complete)
                comboBox.Items.Clear();
        }

        private static void EmptyCheckedListBox(CheckedListBox checkListBox, bool complete = true)
        {
            checkListBox.SelectedItems.Clear();
            checkListBox.SelectedIndices.Clear();
            checkListBox.ClearSelected();
            if (complete)
                checkListBox.Items.Clear();
        }

        /*private static void EmptyDateTimePicker(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Checked = false;
            dateTimePicker.Value = DateTimeManager.Today;
        }*/

        public static void Refresh(ListBox listBox, Object[] init)
        {
            Empty(false,listBox);
            listBox.Items.Clear();
            listBox.Items.AddRange(init);
        }

        public static void Refresh(ListBox listBox, IQueryable<Object> queryable)
        {
            if (queryable != null)
                Refresh(listBox, queryable.ToArray());
        }


        public static void Refresh(ComboBox comboBox, Object[] init)
        {
            Empty(false,comboBox);
            comboBox.Items.Clear();
            if (init != null && init.Length != 0)
                comboBox.Items.AddRange(init);
        }

      
        public static void SetAutoComplete(TextBox textbox, IQueryable<Object> queryable) 
        {

            if (queryable != null )
                SetAutoComplete(textbox, queryable.ToArray()) ;
        
        }
        public static void Refresh(ComboBox comboBox, IQueryable<Object> queryable) 
        {
            if (queryable != null)
                Refresh(comboBox, queryable.ToArray());
        }
        public static void Refresh(ComboBox comboBox, List<Object> queryable)
        {
            if (queryable != null)
                Refresh(comboBox, queryable.ToArray());
        }
        public static void SetAutoComplete(TextBox textbox, Object [] init) 
        {
            if (init != null)
            {
                var source = new AutoCompleteStringCollection();
                source.Add("سلام");
                for (int i =0 ; i< init.Length ; i++)
                    source.Add(init[i].ToString());
               
                textbox.AutoCompleteCustomSource = source;
                textbox.AutoCompleteMode = AutoCompleteMode.Suggest;
                textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                
                //textbox.AutoCompleteSource = AutoCompleteSource.ListItems;
                //textbox.Auto
            }
        }
        
        public static void Refresh(CheckedListBox checkedListBox, Object[] init)
        {
            Empty(false,checkedListBox);
            checkedListBox.Items.Clear();
            checkedListBox.Items.AddRange(init);
            checkedListBox.Refresh();
        }

        public static void Refresh(CheckBox checkBox, Boolean init)
        {
            Empty(false,checkBox);
            checkBox.Checked = init;
        }

        public static void Refresh(DateTimePicker timePicker, DateTime dateTime)
        {
            Empty(false,timePicker);
            timePicker.Value = dateTime;
        }

        public static void RemoveItems(params ComboBox[] comboBoxes)
        {
            Empty(false,comboBoxes);
            foreach (var comboBox in comboBoxes)
                comboBox.Items.Clear();
        }

        public static void RemoveItems(params ListBox[] listBoxes)
        {
            Empty(false,listBoxes);
            foreach (var listBox in listBoxes)
                listBox.Items.Clear();
        }

        public static void SetCheckboxList(CheckedListBox Checkbox, ICollection<Thing> collection)
        {
            Checkbox.Items.Clear();
            foreach (Thing item in collection)
                Checkbox.Items.Add((Constthing)item);
        }
    }
}