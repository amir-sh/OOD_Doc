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
using WindowsFormsApplication1.model.DB;
using WindowsFormsApplication1.model.label;

using MyLabel = WindowsFormsApplication1.model.label.Label;

namespace WindowsFormsApplication1.forms.barchasb
{
    public partial class ComplexBarchasbManagement : UserControl
    {
        public MyLabel label { get; set; }
        
        public ComplexBarchasbManagement()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void SelectLabel_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(SelectLabel, DBManager.datacontext.Labels);
        }

        private void MakeTreeView()
        {
            treeView1.Nodes.Clear();
            if (label != null)
            {
                var temp = new LabelNode(label);
                temp.MakeTree();
                treeView1.Nodes.Add(temp);
            }
        }

        private void AddSublabel_Click(object sender, EventArgs e)
        {
            var labels = MyLabel.GetByName(textBox1.Text).ToArray();
            MyLabel childlabel;
            if (labels.Length == 0)
                return;
            childlabel = labels[0];
            var parentlabel = ((LabelNode)treeView1.SelectedNode);
            if (parentlabel != null)
            {
                if (parentlabel.label.Equals(childlabel))
                    return;

                parentlabel.label.AddSubLabel(childlabel);
                DBManager.datacontext.SaveChanges();
                MakeTreeView();
            }

        }

        private void RmSublabel_Click(object sender, EventArgs e)
        {
            var selected_sublabel = (MyLabel)RmLabelCmbox.SelectedItem;
            var templabel = ((LabelNode)treeView1.SelectedNode);

            if (selected_sublabel != null && templabel != null)
            {
                templabel.label.RemoveSubLabel(selected_sublabel);
                DBManager.datacontext.SaveChanges();
                MakeTreeView();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            FormLoad.Refresh(RmLabelCmbox, ((LabelNode)treeView1.SelectedNode).label.subLabels.ToArray());
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if ((LabelNode)e.Node.Parent == null) 
            {
                return;
            }
            (((LabelNode)e.Node.Parent).label).RemoveSubLabel(((LabelNode)e.Node).label);
            DBManager.datacontext.SaveChanges();
            MakeTreeView();
        }

        private void textBox1_Load(object sender, EventArgs e)
        {
            FormLoad.SetAutoComplete(textBox1, DBManager.datacontext.Labels);
        }

        private void SelectLabel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                
                var db = DBManager.datacontext;
                var labels = MyLabel.GetByName(SelectLabel.Text).ToArray();
                if (labels.Length > 0)
                    label = labels[0];
                MakeTreeView();

            }
        }

        

        
    }
}
