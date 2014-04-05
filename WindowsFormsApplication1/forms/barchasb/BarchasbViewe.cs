using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLabel = WindowsFormsApplication1.model.label.Label;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.forms.Utility;

namespace WindowsFormsApplication1.forms.barchasb
{
    public partial class BarchasbViewe : UserControl
    {
        public BarchasbViewe()
        {
            InitializeComponent();
            FormLoad.SetAutoComplete(SelectLabelTextbox, MyLabel.SelectAllLabels());
        }
        private void PrepareDataGrid(MyLabel label)
        {
            
            LabelDataGridView.Rows.Clear();
            
            LabelDataGridView.Rows.Add();
            PrepareRow(LabelDataGridView.Rows[0], label);
            
        }

        private void PrepareRow(DataGridViewRow dataGridViewRow, MyLabel label)
        {
            dataGridViewRow.Cells["LabelName"].Value = label;
            dataGridViewRow.Cells["LabelState"].Value = label.GetStringType();
            dataGridViewRow.Cells["LabelConstraint"].Value = label.GetStringConstraint();
            dataGridViewRow.Cells["DefaultValue"].Value = label.defaultvalue;
        }
        private void MakeTreeView(MyLabel label)
        {
            LabelTreeView.Nodes.Clear();
            if (label != null)
            {
                var temp = new LabelNode(label);
                temp.MakeTree();
                LabelTreeView.Nodes.Add(temp);
            }
        }
        private void PrepareAssetListView(IQueryable<Asset> input)
        {
            var assets = input.ToArray();
            AssetListView.Items.Clear();
            for (int i = 0; i < assets.Length; i++) 
            {
                AssetListView.Items.Add(assets[i].ToString());
            }
        }

        private void SelectLabelTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                var labels = MyLabel.GetByName(SelectLabelTextbox.Text);
                if (labels.Count() == 0)
                    return;
                var label = labels.ToArray()[0];
                PrepareDataGrid(label);
                PrepareAssetListView(label.FindIncludingAsset());
            }
        }
    }
}
