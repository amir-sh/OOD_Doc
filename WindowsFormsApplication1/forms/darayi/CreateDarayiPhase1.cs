using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.forms;

namespace WindowsFormsApplication1.forms.darayi
{
    public partial class CreateDarayiPhase1 : UserControl
    {
        private Form1 form1;

        public CreateDarayiPhase1()
        {
            InitializeComponent();
        }

        public CreateDarayiPhase1(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase2 userControl=new CreateDarayiPhase2(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }
    }
}
