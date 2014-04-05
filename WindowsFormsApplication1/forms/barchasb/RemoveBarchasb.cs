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
using WindowsFormsApplication1.forms.Utility;
using WindowsFormsApplication1.forms.Utility.Errors;
using WindowsFormsApplication1.model.DB;

namespace WindowsFormsApplication1.forms.barchasb
{
    public partial class RemoveBarchasb : UserControl
    {
        public RemoveBarchasb()
        {
            InitializeComponent();
            FormLoad.SetAutoComplete(SelectLabelTextBox, DBManager.datacontext.Labels);

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyLabel label;
            var labels = MyLabel.GetByName(SelectLabelTextBox.Text);
            if (labels.Count() == 0)
                return;
            label = labels.ToArray()[0];
            label.Remove(checkBox1.Checked,checkBox2.Checked);
            PopUp.ShowSuccess(string.Format("برچسب {0} با موفقیت حذف شد",label.ToString()));

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    

       
    }
}
