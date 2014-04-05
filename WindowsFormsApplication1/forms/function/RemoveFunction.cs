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

namespace WindowsFormsApplication1.forms.function
{
    public partial class RemoveFunction : UserControl
    {
        private MyAction curaction;
        public RemoveFunction()
        {
            InitializeComponent();
            FormLoad.SetAutoComplete(RemoveActionTextbox, MyAction.SelectAllAction());
        }
        private void PrepareRow(MyAction act, int level, bool is_end = false)
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
                result.Frozen = true;
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
                result.Cells["SubAction"].Value = "شروع " + act.name;
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
                    level = PrepareDataGridView(actions[i], level);
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

        private void RemoveActionTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                var actions = MyAction.GetByName(RemoveActionTextbox.Text).ToArray();
                if (actions.Length > 0)
                {
                    curaction = actions[0];
                    PrepareDataGridView(actions[0], 0);
                
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            curaction.Remove();
            DBManager.datacontext.SaveChanges();
        }

        
    }
}
