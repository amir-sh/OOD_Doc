using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.forms.Utility.Errors;
using WindowsFormsApplication1.forms.Utility;
using WindowsFormsApplication1.model.DB;
using MyLabel = WindowsFormsApplication1.model.label.Label;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.forms.barchasb;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.label;


//this.Load += new System.EventHandler(this.SelectLabelTextbox_Load) + new System.EventHandler(this.SelectAssetTextbox_Load);

namespace WindowsFormsApplication1.forms.elsagh
{
    public partial class ManageElsaghs : UserControl
    {
        public ManageElsaghs()
        {
            InitializeComponent();
            LabelGridView.Rows.Add();
            DataGridViewComboBoxColumn LabelValue = new DataGridViewComboBoxColumn();
            LabelValue.HeaderText = "مقدار برچسب";
            LabelValue.Name = "LabelValue";

            //DataGridViewTextBoxColumn LabelValue2 = new DataGridViewTextBoxColumn();
            //LabelValue2.ValueType = 
            
            //LabelGridView.Columns.Add(LabelValue);
            //RefreshCombobox(LabelValue, DBManager.datacontext.Labels.ToArray());
            
            
        }
        public Asset curasset { get; set; }
        public MyLabel curlabel{get;set;}
        public AssignedLabel curassignedlabel { get; set; }
        private void RefreshCombobox(DataGridViewComboBoxColumn col, object [] init) 
        {
            col.ValueMember = "Self";
            col.DisplayMember = "name";
            col.Items.Clear();
            if (init != null && init.Length != 0)
                col.Items.AddRange(init);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopUp.ShowSuccess("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Is null check shavad TODO
            if (GeneralErrors.IsNull(curasset, "دارایی"))
                return;
            //Test
            //GeneralErrors.IsNull(curlabel, "برچسب");
            if (GeneralErrors.IsNull(curassignedlabel, "برچسب"))
                return;
            if (!curasset.isAttached(curassignedlabel))
            {
                //TODO
                curasset.labels.Add(curassignedlabel);
                curassignedlabel.AddToDB();
                DBManager.datacontext.SaveChanges();
                PopUp.ShowSuccess("برچسب الصاق شد");
            }
            else
            {
                PopUp.ShowWarning("برچسب هم اکنون الصاق شده است");
            }
            FormLoad.Refresh(AssignedLabelsCombobox, curasset.labels.ToArray());
        }

        private void SelectAssetTextbox_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(SelectAssetTextbox, DBManager.datacontext.Assets);
        }

        private void SelectLabelTextbox_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(SelectLabelTextbox, DBManager.datacontext.Labels);
        }

        private void SelectAssetTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                var db = DBManager.datacontext;
                var assets = Asset.GetByName(SelectAssetTextbox.Text).ToArray();
                if (assets.Length > 0)
                {
                    curasset = assets[0];
                    FormLoad.Refresh(AssignedLabelsCombobox, curasset.labels.ToArray());
                }

            }
        }

        private void SelectLabelTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (curasset == null)
                {
                    PopUp.ShowWarning("لطفا ابتدا دارایی را انتخاب کنید");
                    return;
                }
                var db = DBManager.datacontext;
                var labels = MyLabel.GetByName(SelectLabelTextbox.Text).ToArray();
                
                if (labels.Length > 0)
                    curlabel = labels[0];
                //TODO
                //bool kir = curasset.isAttached(new AssignedLabel());
                curassignedlabel = curasset.FindAssignedLabel(curlabel);
                if (curassignedlabel == null)
                    curassignedlabel = new AssignedLabel(curlabel);
                PrepareDataGridView(curassignedlabel);
                MakeTreeView();
                
            }
        }
        private void MakeTreeView() 
        {
            LabelTreeView.Nodes.Clear();
            if (curassignedlabel != null)
            {
                var temp = new AssignedLabelNode(curassignedlabel);
                temp.MakeTree();
                LabelTreeView.Nodes.Add(temp);
            }
        }
        private void PrepareAfterDetach()
        {
            LabelTreeView.Nodes.Clear();
            SelectLabelTextbox.ResetText();
            curlabel = null;
            curassignedlabel = null;
            LabelGridView.Rows.Remove(LabelGridView.Rows[0]);
            LabelGridView.Rows.Add();
            LabelValueCheckbox.ResetText();
            LabelValueTextbox.ResetText();
        }
        private void PrepareDataGridView(AssignedLabel assignedlabel)
        {
            LabelGridView.Rows[0].Cells["LabelName"].Value = assignedlabel.label.name ;
            LabelGridView.Rows[0].Cells["LabelType"].Value = assignedlabel.label.GetStringType();
            LabelGridView.Rows[0].Cells["LabelConstraint"].Value = assignedlabel.label.GetStringConstraint();
            LabelGridView.Rows[0].Cells["LabelValue"].Value = assignedlabel.value.ToString();
            var parentassignedlabel = assignedlabel.FindRoot();
            if (curasset.isAttached(parentassignedlabel))
                LabelGridView.Rows[0].Cells["IsAttached"].Value = "الصاق شده";
            else
                LabelGridView.Rows[0].Cells["IsAttached"].Value = "الصاق نشده";

            if (assignedlabel.label.type == MyLabel.STRINGVAL && assignedlabel.label.validvalues.thing2.Count > 0)
            {
                LabelValueCheckbox.Visible = true;
                LabelValueTextbox.Visible = false;
                FormLoad.SetCheckboxList(LabelValueCheckbox, assignedlabel.label.validvalues.thing2);
            }
            else 
            {
                LabelValueCheckbox.Visible = false;
                LabelValueTextbox.Visible = true;
                
            }
            
            
        }

        private void LabelTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            PrepareDataGridView(((AssignedLabelNode)e.Node).label);
        }

        

        private void LabelValueCheckbox_ItemCheck(object sender,  ItemCheckEventArgs e)
        {
            List<string> temp = new List<string> () ;
            for(int i=0 ; i<LabelValueCheckbox.Items.Count;i++) 
            {
                if(LabelValueCheckbox.GetItemChecked(i) && i!= e.Index)
                    temp.Add(LabelValueCheckbox.Items[i].ToString());
            }
            if(!LabelValueCheckbox.GetItemChecked(e.Index))
                temp.Add(LabelValueCheckbox.Items[e.Index].ToString());

            //TODO  selected node null nabashad
            if (LabelTreeView.SelectedNode != null)
            {
                AssignedLabel currentlabel = ((AssignedLabelNode)LabelTreeView.SelectedNode).label ;
                currentlabel.setValue(temp);
                LabelGridView.Rows[0].Cells["LabelValue"].Value = currentlabel.value.ToString();
                if (curasset != null)
                {
                    if (curasset.isAttached(currentlabel.FindRoot()))
                        DBManager.datacontext.SaveChanges();
                }
            }
        }

        private List<string> GetListofValues(string temp)
        {
            int index = 0;
            List<string> listvalues = new List<string>();
            while(index != -1)
            {
                if(temp.IndexOf(",",index) == -1)
                    listvalues.Add(temp.Substring(index));
                else
                    listvalues.Add(temp.Substring(index, temp.IndexOf(",", index)));
                index = temp.IndexOf(",", index);
            }
            return listvalues;
        }
        private void LabelValueTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                string temp = LabelValueTextbox.Text;
                   
                
                if (LabelTreeView.SelectedNode != null)
                {
                    AssignedLabel currentlabel = ((AssignedLabelNode)LabelTreeView.SelectedNode).label;
                    var listvalues =GetListofValues(temp);
                    currentlabel.setValue(listvalues);
                    LabelGridView.Rows[0].Cells["LabelValue"].Value = currentlabel.value.ToString();
                    if (curasset != null)
                    {
                        if (curasset.isAttached(currentlabel.FindRoot()))
                            DBManager.datacontext.SaveChanges();
                    }
                }
            }
        }

        private void DetachAssignedLabel_Click(object sender, EventArgs e)
        {

            if (GeneralErrors.IsNull(curassignedlabel, "برچسب الصاق شده"))
                return;
            if (curasset.isAttached(curassignedlabel))
            {
                curasset.Detach(curassignedlabel);
                DBManager.datacontext.SaveChanges();
                PopUp.ShowSuccess("برچسب جدا شد");
                PrepareAfterDetach();
            }
            else
            {
                PopUp.ShowWarning("برچسب هم اکنون الصاق نشده است");
            }
            //TODO
            FormLoad.Refresh(AssignedLabelsCombobox, curasset.labels.ToArray());
        }

        private void SelectAssetTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssignedLabelsCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AssignedLabelsCombobox.SelectedItem != null)
            {
                curassignedlabel = (AssignedLabel)AssignedLabelsCombobox.SelectedItem;
                PrepareDataGridView((AssignedLabel)AssignedLabelsCombobox.SelectedItem);
               
                MakeTreeView();
            }
        }

        private void LabelValueTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelValueCheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
        
    }
}
