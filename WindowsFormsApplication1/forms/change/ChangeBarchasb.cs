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
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.model.label;
using WindowsFormsApplication1.forms.elsagh ;
using MyLabel = WindowsFormsApplication1.model.label.Label;
using WindowsFormsApplication1.model.util;
using WindowsFormsApplication1.model.DB;
namespace WindowsFormsApplication1.forms.change
{
    public partial class ChangeBarchasb : UserControl
    {
        public AssignedLabel curassignedlabel { get; set; }
        public ChangeBarchasb()
        {
            InitializeComponent();
        }

        private void TriggerValueBox(bool active)
        {
            NewValCheckbox.Enabled = active;
            NewValTextbox.Enabled = !active;
        }

        private void SelectAssetTextbox_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(SelectAssetTextbox, Asset.SelectAllAsset());
        }

        private void SelectAssetTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            IQueryable<Asset> assets;
            Asset asset;
            if (e.KeyCode == Keys.Return)
            {
                assets = Asset.GetByName(SelectAssetTextbox.Text);
                if (assets.Count() == 0)
                    return;
                asset = assets.ToArray()[0];
                FormLoad.Refresh(SelectLabelCombobox, asset.labels.ToArray());
            }
        }

        private void PrepareAssginedLabel(AssignedLabel label) 
        {
            SelectedLabelTextbox.Text = label.label.ToString();
            CurrentValTextbox.Text = label.value.ToString();
            if (label.label.IsMultipleChoice())
            {
                PrepareStateCheckbox(label.label);
                TriggerValueBox(true);

            }
            else
            {
                TriggerValueBox(false);
            }
            PrepareStateCheckbox(label.label);
        }
        private void SelectLabelCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            curassignedlabel = (AssignedLabel)SelectLabelCombobox.SelectedItem;
            MakeTreeView(curassignedlabel);
            PrepareAssginedLabel(curassignedlabel);
            
        }
        private void MakeTreeView(AssignedLabel assignedlabel)
        {
            LabelTreeView.Nodes.Clear();
            if (assignedlabel != null)
            {
                var temp = new AssignedLabelNode(assignedlabel);
                temp.MakeTree();
                LabelTreeView.Nodes.Add(temp);
            }
        }
        
        private void PrepareStateCheckbox(MyLabel label)
        {
            //TODO
            if (label.type != MyLabel.STRINGVAL)
                return;
            var collection = label.validvalues.thing2;
            NewValCheckbox.Items.Clear();
            foreach (Constthing item in collection)
                NewValCheckbox.Items.Add(item);
            
        }

        private void LabelTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            curassignedlabel = ((AssignedLabelNode)LabelTreeView.SelectedNode).label;
            PrepareAssginedLabel(curassignedlabel);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curassignedlabel.label.IsMultipleChoice())
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < NewValCheckbox.Items.Count; i++)
                {
                    if (NewValCheckbox.GetItemChecked(i))
                        temp.Add(NewValCheckbox.Items[i].ToString());
                }
                curassignedlabel.value.SetValues(temp);
            }
            else 
            {
                curassignedlabel.value.SetValues(curassignedlabel.value.getListofValues(NewValTextbox.Text));
            }
            DBManager.datacontext.SaveChanges();
        }

    }
}
