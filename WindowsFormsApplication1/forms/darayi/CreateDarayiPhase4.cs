using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.forms.darayi
{
    public partial class CreateDarayiPhase4 : UserControl
    {
        private Form1 form1;

        public CreateDarayiPhase4()
        {
            InitializeComponent();
        }

        public CreateDarayiPhase4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase3 userControl = new CreateDarayiPhase3(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            CreateDarayiPhase3 userControl = new CreateDarayiPhase3(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
