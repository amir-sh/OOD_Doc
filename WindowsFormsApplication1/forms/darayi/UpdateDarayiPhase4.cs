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
    public partial class UpdateDarayiPhase4 : UserControl
    {
        private Form1 form1;

        public UpdateDarayiPhase4()
        {
            InitializeComponent();
        }

        public UpdateDarayiPhase4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateDarayiPhase3 userControl = new UpdateDarayiPhase3(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            UpdateDarayiPhase3 userControl = new UpdateDarayiPhase3(form1);
            form1.ResetAndAddToPrimaryPanel(userControl);
        }
    }
}
