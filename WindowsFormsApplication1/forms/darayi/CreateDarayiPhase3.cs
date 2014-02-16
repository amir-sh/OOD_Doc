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
    public partial class CreateDarayiPhase3 : UserControl
    {
        private Form1 form1;

        public CreateDarayiPhase3()
        {
            InitializeComponent();
        }

        public CreateDarayiPhase3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase2 userControl = new CreateDarayiPhase2(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase4 userControl = new CreateDarayiPhase4(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase4 userControl = new CreateDarayiPhase4(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateDarayiPhase2 userControl = new CreateDarayiPhase2(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }
    }
}
