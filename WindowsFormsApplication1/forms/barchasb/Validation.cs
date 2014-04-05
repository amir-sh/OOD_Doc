using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.model.label;
using WindowsFormsApplication1.forms.elsagh;
using WindowsFormsApplication1.model.asset;
using WindowsFormsApplication1.forms.Utility;
using MyConstraint = WindowsFormsApplication1.model.validation.Constraint ;
using WindowsFormsApplication1.model.util;

namespace WindowsFormsApplication1.forms.barchasb
{
    public partial class Validation : UserControl
    {
        private AssignedLabel curassignedlabel = null;
        private MyConstraint constraint = null;
        private Asset curasset; 
        public Validation()
        {
            InitializeComponent();
            constraint = new MyConstraint();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddSubActionCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SelectLabelComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SelectLabelComboBox.SelectedItem != null)
            {
                curassignedlabel = (AssignedLabel)SelectLabelComboBox.SelectedItem;
                

                MakeTreeView();
            }
        }

        private void SelectAssetTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                var assets = Asset.GetByName(SelectAssetTextBox.Text);
                if (assets.Count() == 0)
                    return;
                var asset = assets.ToArray()[0];
                curasset = asset;
                FormLoad.Refresh(SelectLabelComboBox, asset.labels.ToArray());
            }
        }

        private void LabelTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            curassignedlabel = ((AssignedLabelNode)LabelTreeView.SelectedNode).label;
        }

        private ICollection<Thing> CurrentSet() 
        {
            return SelectSetCheckList.GetItemChecked(0) ? constraint.thing1 : constraint.thing2;
        }
        
        private DataGridView CurrentGrid() 
        {
            return SelectSetCheckList.GetItemChecked(0) ? dataGridView1 : dataGridView2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var currentset = CurrentSet();
            currentset.Add(CreateLabelThing());
            PrepareGrid();
        }

        private LabelThing CreateLabelThing() 
        {
            return new LabelThing { assignedlabel = curassignedlabel };
        }
        private void PrepareGrid() 
        {
            DataGridView datagrid = CurrentGrid();
            ICollection<Thing> things =CurrentSet();
            datagrid.Rows.Clear();
            if (things.Count() > 0)
            {
                for (int i = 0; i < things.Count; i++)
                {
                    datagrid.Rows.Add();
                    PrepareRow(datagrid,datagrid.Rows[i],things.ToArray()[i], i);
                }
            }
        }
        private void PrepareRow(DataGridView datagrid, DataGridViewRow row,Thing thing, int level) 
        {
            row.Cells["Level"].Value = level ;
            row.Cells["ValueType"].Value = thing.GetThingValue();
            row.Cells["Value"].Value = thing.GetThingValue();
            
            var labelthing = thing as LabelThing;
            if (labelthing != null) 
            {
                row.Cells["AssetName"].Value = labelthing.assignedlabel.asset;
                row.Cells["Type"].Value = "برچسب الصاق شده";
            }
            
            var featurething = thing as FeatureThing;
            if (featurething != null) 
            {
                row.Cells["AssetName"].Value = featurething.asset;
                row.Cells["Type"].Value = "ویژگی اولیه";
                
            }

            var constthing = thing as Constthing;
            if (constthing != null) 
            {
                row.Cells["Type"].Value = "مقدار ثابت";
            }
        }
        private FeatureThing CreateFeature() 
        {
            return (FeatureThing)SelectFeatureComboBox.SelectedItem;
        }

        private void SelectAssetTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) 
            {
                var assets = Asset.GetByName(SelectAssetTextBox.Text);
                if (assets.Count() == 0)
                    return;
                var asset = assets.ToArray()[0];
                curasset = asset;
                FormLoad.Refresh(SelectFeatureComboBox, asset.features.ToArray());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentset = CurrentSet();
            currentset.Add(CreateFeature());
            PrepareGrid();
        }

        private void SelectSetCheckList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var currentset = CurrentSet();
            currentset.Add(ConstValue());
            PrepareGrid();
        }

        private Thing ConstValue()
        {
            return new Thing();   
        }
        
    }
}
