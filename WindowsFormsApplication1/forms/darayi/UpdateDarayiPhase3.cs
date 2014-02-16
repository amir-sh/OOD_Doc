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
    public partial class UpdateDarayiPhase3 : UserControl
    {
        private Form1 form1;

        public UpdateDarayiPhase3()
        {
            InitializeComponent();
        }

        public UpdateDarayiPhase3(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDarayiPhase2 userControl = new UpdateDarayiPhase2(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDarayiPhase4 userControl = new UpdateDarayiPhase4(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateDarayiPhase2 userControl = new UpdateDarayiPhase2(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateDarayiPhase4 userControl = new UpdateDarayiPhase4(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }
    }
}
