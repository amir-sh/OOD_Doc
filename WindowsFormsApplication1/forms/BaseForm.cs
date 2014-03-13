using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.forms;
using WindowsFormsApplication1.forms.darayi;
using WindowsFormsApplication1.forms.barchasb;
using WindowsFormsApplication1.forms.elsagh;
using WindowsFormsApplication1.forms.settings;
using WindowsFormsApplication1.forms.history;
using WindowsFormsApplication1.forms.function;
using WindowsFormsApplication1.forms.report;
using WindowsFormsApplication1.forms.events;
using WindowsFormsApplication1.forms.change;
using WindowsFormsApplication1.model;
using System.Data.Common;
using WindowsFormsApplication1.model.asset;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            ResetPrimaryPanel();   
            
        }

        private void AddToPrimaryPanel(UserControl control)
        {
            splitContainer1.Panel2.Controls.Add(control);
        }

        public void ResetAndAddToPrimaryPanel(UserControl control)
        {
            ResetPrimaryPanel();
            AddToPrimaryPanel(control);
        }

        private void ResetPrimaryPanel()
        {
            splitContainer1.Panel2.Controls.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }


        private void داراییToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           Application.Exit();

        }

        private void ایجادداراییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDarayiPhase1 userControl=new CreateDarayiPhase1(this);
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void حذفداراییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveDarayi userControl = new RemoveDarayi();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void بروزرسانیداراییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDarayiPhase1 userControl = new UpdateDarayiPhase1(this);
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مشاهدهلیستداراییهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssetListView userControl = new AssetListView();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مشاهدهداراییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarayiViewe userControl = new DarayiViewe();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void ایجادبرچسبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBarchasb userControl = new CreateBarchasb();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void حذفبرچسبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveBarchasb userControl = new RemoveBarchasb();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void بروزرسانیبرچسبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBarchasb userControl = new UpdateBarchasb();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مدیریتبرچسبمرکبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplexBarchasbManagement userControl = new ComplexBarchasbManagement();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مدیریتداراییمرکبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplexDarayiManagement userControl = new ComplexDarayiManagement();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مشاهدهلیستبرچسبهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarchasbListViewe userControl = new BarchasbListViewe();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مشاهدهیکبرچسبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarchasbViewe userControl = new BarchasbViewe();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مدیریتالصاقبرچسببهداراییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageElsaghs userControl = new ManageElsaghs();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBarchasb userControl = new ChangeBarchasb();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void گزارشگیریبراساسبرچسبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportBarchasb userControl = new ReportBarchasb();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void گزارشگیریبراساسداراییToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDarayi userControl = new ReportDarayi();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void گزارشگیریبراساسیکعملخاصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportFunction userControl = new ReportFunction();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void گزارشگیریسریزمانیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportTimeSerries userControl = new ReportTimeSerries();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مشاهدهسابقهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagement userControl = new HistoryManagement();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مدیریتنقطهمبناToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseHistory userControl = new BaseHistory();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void بازگرداندنیکداراییبهیکسابقهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManagement userControl = new HistoryManagement();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مشاهدهلیستعملیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تعریفرخدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefineEvent userControl = new DefineEvent();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void گزارشوقوعرخدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunEvent userControl = new RunEvent();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void تعریفعملیاتجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFunction userControl = new AddFunction();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void حذفعملیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFunction userControl = new RemoveFunction();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مدیریتعملیاتمرکبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFunction userControl = new AddFunction();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void اعمالعملیاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyFunction userControl = new ApplyFunction();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void مدیریترخدادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEvent userControl = new ManageEvent();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void تنظیمسیستمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigBarchasbTimeSerries userControl = new ConfigBarchasbTimeSerries();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void محاسبهمختصاتمکانیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigDarayiTimeSerries userControl = new ConfigDarayiTimeSerries();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void رمزهایعبورToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Passwords userControl = new Passwords();
            ResetAndAddToPrimaryPanel(userControl);
        }

        private void سابقهToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
