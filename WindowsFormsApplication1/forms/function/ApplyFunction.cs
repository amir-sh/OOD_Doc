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
using WindowsFormsApplication1.model.DB;
using WindowsFormsApplication1.forms.Utility;


//this.Load += new System.EventHandler(this.SelectAssetText_Load);
namespace WindowsFormsApplication1.forms.function
{
    public partial class ApplyFunction : UserControl
    {
        public MyAction curaction {get;set;}
        public ApplyFunction()
        {
            InitializeComponent();
            ActionDataGridView.MultiSelect = false;
            ActionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //TODO age beshe row ro dorst kard behtare 
        private void PrepareRow(MyAction act,int level,bool is_end= false )
        {

           // DataGridViewRow result = new DataGridViewRow();
           // result.DefaultCellStyle = ActionDataGridView.DefaultCellStyle;
            ActionDataGridView.Rows.Add();
            DataGridViewRow result = ActionDataGridView.Rows[level];
            result.ReadOnly = true;
            
            result.Cells["Level"].Value = level;
            if (is_end == true) 
            {
                result.Cells["ActionID"].Value = -1;
                result.Frozen = true ;
                result.DefaultCellStyle.BackColor = Color.CadetBlue;
                result.Cells["SubAction"].Value = "اتمام " + act.name;
            }
            else if (act.name == null)
            {
                result.Cells["AssetName"].Value = act.label.asset;
                result.Cells["LabelName"].Value = act.label.label;
                result.Cells["Input"].Value = act.has_input ? "دارد" : "ندارد";
                result.Cells["NewState"].Value = act.has_input ? "ورودی" : act.newvalue.ToString();
                result.Cells["ActionID"].Value = act.id;
            }
            else 
            {
                result.Cells["ActionID"].Value = act.id;
                result.Frozen = true;
                result.Cells["SubAction"].Value = "شروع "+act.name;
            }
            
        }
        private int PrepareDataGridView(MyAction act, int level) 
        {
            if (level == 0)
            {
                PrepareRow(act, level, false);
                level++;
            }
            if (act.name == null)
            {
               PrepareRow(act, level, false);
               return level + 1;
            }
            else 
            {
                var actions = act.actions.ToArray();
                for (int i = 0; i < actions.Length; i++) 
                {
                    level =PrepareDataGridView(actions[i], level);
                    if (actions[i].name != null)
                    {
                        PrepareRow(new MyAction { name = actions[i].name }, level, true);
                        level++;
                    }
                }
               PrepareRow(new MyAction { name = act.name }, level, true);
               level++;
            }
            return level;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            MyAction temp = MyAction.GetByName(SelectAssetTextbox.Text).ToArray()[0];
            PrepareDataGridView(temp, 0);
        }

        private Control CurrentValueBox() 
        {
            if (StatesCheckbox.Visible) 
                return StatesCheckbox ; 
            else
                return StatesTextbox; 
        }
        private void FocusValueBoxControl(Control control1,Control control2) 
        {
            control1.Visible = true;
            control2.Visible = false;
        }
        private void ActionDataGridView_SelectionChanged(object sender, EventArgs e)
        {
           // return;
            DataGridViewRow temp ;
            TriggerValueBox(false);
            if (ActionDataGridView.SelectedRows.Count > 0)
                temp = ActionDataGridView.SelectedRows[0];
            else return;

            if (temp.Cells["ActionID"].Value == null)
                return;
            if((int)(temp.Cells["ActionID"].Value )== -1)
                return ;
            
            MyAction act = DBManager.datacontext.GeneralActions.Find((int)(temp.Cells["ActionID"].Value));
            
            if (act.name != null)
                return;
            //TODO
            TriggerValueBox(!act.has_input);
            if (act.label.label.IsMultipleChoice())
            {
                FocusValueBoxControl(StatesCheckbox, StatesTextbox);
                FormLoad.SetCheckboxList(StatesCheckbox, act.label.GetValidValues());
            }
            else 
            {
                FocusValueBoxControl(StatesTextbox, StatesCheckbox);
            }
            curaction = act;
        }
        private void TriggerValueBox (bool active)
        {
            StatesCheckbox.Enabled = active ;
            StatesTextbox.Enabled = active ;
        }

        private void StatesCheckbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < StatesCheckbox.Items.Count; i++)
            {
                if (StatesCheckbox.GetItemChecked(i) && i != e.Index)
                    temp.Add(StatesCheckbox.Items[i].ToString());
            }
            if (!StatesCheckbox.GetItemChecked(e.Index))
                temp.Add(StatesCheckbox.Items[e.Index].ToString());
            curaction.newvalue.SetValues(temp);
            SetValueForActionGridView(curaction);
            
        }

        private DataGridViewRow FindActionByID(int id) 
        {
            for (int i = 0; i < ActionDataGridView.Rows.Count; i++)
                if ((int)ActionDataGridView.Rows[i].Cells["ActionID"].Value == id)
                    return ActionDataGridView.Rows[i];
            return null; 
        }
        private void StatesTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            curaction.newvalue.SetValues(curaction.newvalue.GetListofValues(StatesTextbox.Text));
            SetValueForActionGridView(curaction);
        }
        private void SetValueForActionGridView(MyAction act) 
        {
            DataGridViewRow temp = FindActionByID(act.id);
            if (temp == null)
                return;
            temp.Cells["NewState"].Value = act.newvalue.ToString();
        }

        private void SelectAssetText_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(SelectAssetTextbox, MyAction.SelectAllAction());
        }

        private void SelectAssetTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                var actions = MyAction.GetByName(SelectAssetTextbox.Text).ToArray();
                if (actions.Length > 0)
                    PrepareDataGridView(actions[0], 0);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActionDataGridView.Rows.Count == 0)
                return;
            var action = DBManager.datacontext.GeneralActions.Find((int)ActionDataGridView.Rows[0].Cells["ActionID"].Value);
            var table= ActionDataGridView.Rows ;
            MyAction tempaction;
            for (int i = 0; i < table.Count; i++) 
            {
                //TODO amaliate morakab khodash anjam shavad
                if ((int)table[i].Cells["ActionID"].Value == -1 ||table[i].Cells["SubAction"].Value != null)
                    continue;
                tempaction = DBManager.datacontext.GeneralActions.Find((int)table[i].Cells["ActionID"].Value);
                tempaction.Apply();
            }
            DBManager.datacontext.SaveChanges();
        }

    }
}
