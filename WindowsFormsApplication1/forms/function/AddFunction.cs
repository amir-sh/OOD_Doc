using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAction = WindowsFormsApplication1.model.maintenance.function.Action;
using WindowsFormsApplication1.model.asset ;
using MyLAbel =WindowsFormsApplication1.model.label.Label;
using WindowsFormsApplication1.model.label;
using WindowsFormsApplication1.forms.Utility;
using WindowsFormsApplication1.forms.elsagh;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.DB;
using WindowsFormsApplication1.forms.Utility.Errors;

 //this.Load += new System.EventHandler(this.SelectAssetTextbox_Load) + new System.EventHandler(this.SubActionTextbox_Load);

namespace WindowsFormsApplication1.forms.function
{
    public partial class AddFunction : UserControl
    {
        public Asset curasset { get; set; }
        public AssignedLabel curassignedlabel { get; set; }
        public MyAction curaction { get; set; }
        
        public AddFunction()
        {
            InitializeComponent();
            ActionView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ActionView.MultiSelect = false;
            curaction = new MyAction();

        }

        private void MakeTreeView(AssignedLabel assignedlabel)
        {
            AssignedLabelTreeView.Nodes.Clear();
            if (assignedlabel != null)
            {
                var temp = new AssignedLabelNode(assignedlabel);
                temp.MakeTree();
                AssignedLabelTreeView.Nodes.Add(temp);
            }
        }

        private void SelectAssetTextbox_Load(object sender, EventArgs e) 
        {
            FormLoad.SetAutoComplete(SelectAssetTextbox, DBManager.datacontext.Assets);
        }
        private void AddSimpleActionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddSimpleActionCheckbox.Checked == true)
            {
                AddSubActionCheckbox.Checked = false;
                AddSubActionGroupbox.Visible = false;
                AddSimpleActionGroupbox.Visible = true;
            }
            else
                AddSimpleActionGroupbox.Visible = false;
        }

        private void AddSubActionCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddSubActionCheckbox.Checked == true)
            {
                AddSimpleActionGroupbox.Visible = false;
                AddSimpleActionCheckbox.Checked = false;
                AddSubActionGroupbox.Visible = true;

            }
            else
                AddSubActionGroupbox.Visible = false;
        }
        private void PrepareDataGrid() 
        {
            ActionView.Rows.Clear();
            
            if (curaction.actions.Count > 0) 
            {
                for (int i = 0; i < curaction.actions.Count; i++) 
                {
                    ActionView.Rows.Add();
                    PrepareRow(curaction.actions.ToArray()[i], ActionView.Rows[i], i);
                }
            }
        }
        private void PrepareRow(MyAction act, DataGridViewRow row, int level)
        {
            
            row.Cells["Level"].Value = level;
            if (act.name == null)
            {
                row.Cells["AssetName"].Value = curasset;
                row.Cells["LabelName"].Value = act.label.label;
                //TODO
                row.Cells["Input"].Value = act.has_input?"دارد":"ندارد";
                row.Cells["NewState"].Value = act.newvalue ;

            }
            else 
            {
                row.Cells["SubAction"].Value = act.name; 
            }
        }

        private void AddSubActionButton_Click(object sender, EventArgs e)
        {
            var actions = MyAction.GetByName(SubActionTextbox.Text);
            if (actions.ToArray().Length>0) 
            {
                var action = actions.ToArray()[0];
                curaction.actions.Add(action);
                PrepareDataGrid();
                PrepareNumericUpDown(curaction.actions.Count);
            }
                
        }


        private void AddSimpleActionReset() 
        {
            foreach (Control item in AddSimpleActionGroupbox.Controls)
            {
                if(!item.Equals(SelectAssetTextbox))
                    FormLoad.Empty(true, item);
            }
            curassignedlabel = null;
        }
        private void SelectAssetTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {

                var assets = Asset.GetByName(SelectAssetTextbox.Text).ToArray();
                if (assets.Length > 0)
                    curasset = assets[0];
                else
                    return;
                AddSimpleActionReset();
                FormLoad.Refresh(AssignedLabelCombobox, curasset.labels.ToArray());
            }
        }

        private void AssignedLabelCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            curassignedlabel = (AssignedLabel) AssignedLabelCombobox.SelectedItem;
            MakeTreeView(curassignedlabel);
            if (curassignedlabel.label.IsMultipleChoice())
            {
                PrepareStateCheckbox(curassignedlabel.label);
                NewStateTextbox.Visible = false;
                StatesCheckbox.Visible = true;
            }
            else 
            {
                NewStateTextbox.Visible = true;
                StatesCheckbox.Visible = false;
            }

        }
        private void PrepareStateCheckbox(MyLAbel label) 
        {
            //TODO
            if (label.type != MyLAbel.STRINGVAL)
                return;
            var collection = label.validvalues.thing2;
            StatesCheckbox.Items.Clear();
            foreach (Constthing item in collection)
               StatesCheckbox.Items.Add(item);
            if (HasInputCheckbox.Checked) 
            {
                //TODO $ jaye voroodi
                var temp = new Constthing { type= Constthing.STRING,values = "ورودی" };
                StatesCheckbox.Items.Add(temp);
            }
        }

        private void AssignedLabelTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            curassignedlabel = ((AssignedLabelNode)AssignedLabelTreeView.SelectedNode).label;
            PrepareStateCheckbox(curassignedlabel.label);
        }

        
        private void HasInputCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (HasInputCheckbox.Checked)
            {
                NewStateTextbox.Enabled = false;
                StatesCheckbox.Enabled = true;
            }
            else
            {
                NewStateTextbox.Enabled = true;
                StatesCheckbox.Enabled = false;
            }
            PrepareStateCheckbox(curassignedlabel.label);
        }
        private void AddSimpleAction()
        {
            MyAction act = new MyAction();
            act.label = curassignedlabel;
            if(curassignedlabel.label.IsMultipleChoice())
            {
                foreach (var item in StatesCheckbox.CheckedItems)
                {
                    act.newvalue.AddState(item.ToString());
                }
            }
            else
            {
                var temp = new Constthing();
                act.SetValue(NewStateTextbox.Text);
            }
            act.has_input = HasInputCheckbox.Checked;
            curaction.actions.Add(act);
            PrepareDataGrid();
            PrepareNumericUpDown(curaction.actions.Count);
            
        }

        private void AddSubAction()
        {
            var actions = MyAction.GetByName(SubActionTextbox.Text).ToArray();
            MyAction cursubaction =null;
            if (actions.Length > 0)
                cursubaction = actions[0];
            else 
                return ;
            curaction.actions.Add(cursubaction);
            PrepareDataGrid();
            PrepareNumericUpDown(curaction.actions.Count);
        }


        private void SubActionTextbox_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(SubActionTextbox, MyAction.SelectAllAction().ToArray());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*var actions =MyAction.GetByName(ActionNameTextbox.Text).ToArray();
            var action = actions[0];
            PopUp.ShowError(action.actions.ToArray()[0].label.ToString());
            return;*/
            curaction.name = ActionNameTextbox.Text;
            curaction.AddToDB();
            FormLoad.SetAutoComplete(SubActionTextbox, MyAction.SelectAllAction().ToArray());
        }

        private void RemoveAction(int level) 
        {
            
            ICollection<MyAction> temp = new List<MyAction>();
            var actions = curaction.actions.ToArray();
            for (int i = 0; i < actions.Length; i++) 
            {
                if (i != level)
                    temp.Add(actions[i]);
            }
            curaction.actions = temp;
            PrepareDataGrid();
            PrepareNumericUpDown(curaction.actions.Count);
        }

        private void AddSimpleActionButton_Click(object sender, EventArgs e)
        {
            AddSimpleAction();
        }

        private void RemoveLevelButton_Click(object sender, EventArgs e)
        {
            int level = (int)RemoveLevelNumericUpDown.Value;
            RemoveAction(level);
        }
        private void PrepareNumericUpDown(int length) 
        {
            RemoveLevelNumericUpDown.Maximum = length -1;
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (ActionView.SelectedRows.Count > 0)
            {
                int level = (int)ActionView.SelectedRows[0].Cells["Level"].Value;
                UpLevel(level);
            }
        }

        private void UpLevel(int level)
        {
            if (level == 0)
                return;
            ICollection<MyAction> temp = new List<MyAction>();
            var actions = curaction.actions.ToArray();
            
            for (int i = 0; i < actions.Length; i++) 
            {
                if (i == level - 1)
                    temp.Add(actions[level]);
                else if( i== level)
                    temp.Add(actions[level-1]);
                else 
                    temp.Add(actions[i]);
            }
            curaction.actions = temp;
            PrepareDataGrid();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (ActionView.SelectedRows.Count > 0)
            {
                int level = (int)ActionView.SelectedRows[0].Cells["Level"].Value;
                DownLevel(level);
            }
        }

        private void DownLevel(int level)
        {
            
            ICollection<MyAction> temp = new List<MyAction>();
            var actions = curaction.actions.ToArray();
            
            if (level == actions.Length - 1)
                return;
            for (int i = 0; i < actions.Length; i++)
            {
                if (i == level + 1)
                    temp.Add(actions[level]);
                else if (i == level)
                    temp.Add(actions[level + 1]);
                else
                    temp.Add(actions[i]);
            }
            curaction.actions = temp;
            PrepareDataGrid();
        }

        

        

       
    }
}
