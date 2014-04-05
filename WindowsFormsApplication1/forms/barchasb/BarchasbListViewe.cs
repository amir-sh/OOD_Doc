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
namespace WindowsFormsApplication1.forms.barchasb
{
    public partial class BarchasbListViewe : UserControl
    {
        public BarchasbListViewe()
        {
            InitializeComponent();
        }

        private void PrepareDataGrid(IQueryable<MyLabel> input) 
        {
            var labels = input.ToArray();
            LabelDataGridView.Rows.Clear();
            for (int i = 0; i < labels.Length; i++) 
            {
                LabelDataGridView.Rows.Add();
                PrepareRow(LabelDataGridView.Rows[i], labels[i]);
            }
        }

        private void PrepareRow(DataGridViewRow dataGridViewRow, MyLabel label)
        {
            dataGridViewRow.Cells["LabelName"].Value = label;
            dataGridViewRow.Cells["LabelState"].Value = label.GetStringType();
            dataGridViewRow.Cells["LabelConstraint"].Value = label.GetStringConstraint();
            string temp="";
            foreach (MyLabel item in label.subLabels)
                temp += ","+item.ToString();
            if(temp=="")
                temp = "ندارد";
            else
                temp = temp.Substring(1);
            dataGridViewRow.Cells["SubLabels"].Value = temp;
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
