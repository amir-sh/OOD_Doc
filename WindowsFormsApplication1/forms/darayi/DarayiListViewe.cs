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

namespace WindowsFormsApplication1.forms.darayi
{
    public partial class AssetListView : UserControl
    {
        public AssetListView()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox1.i56
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void  comboBox1_Load(object sender, EventArgs e)
        {
            string message = "کیر";
            MessageBox.Show(message, "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading);
            FormLoad.Refresh(comboBox1, DBManager.datacontext.Assets);
        }

        private void textBox1_Load(object sender, EventArgs e) 
        {
            FormLoad.SetAutoComplete(textBox1, DBManager.datacontext.Assets);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string message = "کیر";
            MessageBox.Show(message, "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
