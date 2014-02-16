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
    public partial class CreateDarayiPhase2 : UserControl
    {
        private Form1 form1;

        public CreateDarayiPhase2()
        {
            InitializeComponent();
        }

        public CreateDarayiPhase2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase1 userControl = new CreateDarayiPhase1(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase3 userControl = new CreateDarayiPhase3(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase3 userControl = new CreateDarayiPhase3(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateDarayiPhase1 userControl = new CreateDarayiPhase1(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
