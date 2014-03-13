using System;
using WindowsFormsApplication1.model;
namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.داراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ایجادداراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفداراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بروزرسانیداراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتداراییمرکبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهلیستداراییهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهداراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.برچسبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ایجادبرچسبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفبرچسبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بروزرسانیبرچسبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتبرچسبمرکبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهلیستبرچسبهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهیکبرچسبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتالصاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتالصاقبرچسببهداراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتتغییرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشگیریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشگیریبراساسبرچسبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشگیریبراساسداراییToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشگیریبراساسیکعملخاصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشگیریسریزمانیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سابقهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهسابقهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بازگرداندنیکداراییبهیکسابقهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتنقطهمبناToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدهلیستعملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعریفعملیاتجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفعملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتعملیاتمرکبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اعمالعملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رخدادToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریترخدادToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیماتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تنظیمسیستمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.محاسبهمختصاتمکانیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.رمزهایعبورToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, -1);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(848, 514);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.داراییToolStripMenuItem,
            this.برچسبToolStripMenuItem,
            this.مدیریتالصاقToolStripMenuItem,
            this.ثبتتغییرToolStripMenuItem,
            this.گزارشگیریToolStripMenuItem,
            this.سابقهToolStripMenuItem,
            this.عملیاتToolStripMenuItem,
            this.رخدادToolStripMenuItem,
            this.تنظیماتToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(74, 514);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // داراییToolStripMenuItem
            // 
            this.داراییToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ایجادداراییToolStripMenuItem,
            this.حذفداراییToolStripMenuItem,
            this.بروزرسانیداراییToolStripMenuItem,
            this.مدیریتداراییمرکبToolStripMenuItem,
            this.مشاهدهلیستداراییهاToolStripMenuItem,
            this.مشاهدهداراییToolStripMenuItem});
            this.داراییToolStripMenuItem.Name = "داراییToolStripMenuItem";
            this.داراییToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.داراییToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.داراییToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.داراییToolStripMenuItem.Text = "دارایی";
            this.داراییToolStripMenuItem.Click += new System.EventHandler(this.داراییToolStripMenuItem_Click);
            // 
            // ایجادداراییToolStripMenuItem
            // 
            this.ایجادداراییToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ایجادداراییToolStripMenuItem.Name = "ایجادداراییToolStripMenuItem";
            this.ایجادداراییToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.ایجادداراییToolStripMenuItem.Text = "ایجاد دارایی";
            this.ایجادداراییToolStripMenuItem.Click += new System.EventHandler(this.ایجادداراییToolStripMenuItem_Click);
            // 
            // حذفداراییToolStripMenuItem
            // 
            this.حذفداراییToolStripMenuItem.Name = "حذفداراییToolStripMenuItem";
            this.حذفداراییToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.حذفداراییToolStripMenuItem.Text = "حذف دارایی";
            this.حذفداراییToolStripMenuItem.Click += new System.EventHandler(this.حذفداراییToolStripMenuItem_Click);
            // 
            // بروزرسانیداراییToolStripMenuItem
            // 
            this.بروزرسانیداراییToolStripMenuItem.Name = "بروزرسانیداراییToolStripMenuItem";
            this.بروزرسانیداراییToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.بروزرسانیداراییToolStripMenuItem.Text = "بروزرسانی دارایی";
            this.بروزرسانیداراییToolStripMenuItem.Click += new System.EventHandler(this.بروزرسانیداراییToolStripMenuItem_Click);
            // 
            // مدیریتداراییمرکبToolStripMenuItem
            // 
            this.مدیریتداراییمرکبToolStripMenuItem.Name = "مدیریتداراییمرکبToolStripMenuItem";
            this.مدیریتداراییمرکبToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.مدیریتداراییمرکبToolStripMenuItem.Text = "مدیریت دارایی مرکب";
            this.مدیریتداراییمرکبToolStripMenuItem.Click += new System.EventHandler(this.مدیریتداراییمرکبToolStripMenuItem_Click);
            // 
            // مشاهدهلیستداراییهاToolStripMenuItem
            // 
            this.مشاهدهلیستداراییهاToolStripMenuItem.Name = "مشاهدهلیستداراییهاToolStripMenuItem";
            this.مشاهدهلیستداراییهاToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.مشاهدهلیستداراییهاToolStripMenuItem.Text = "مشاهده لیست دارایی ها";
            this.مشاهدهلیستداراییهاToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهلیستداراییهاToolStripMenuItem_Click);
            // 
            // مشاهدهداراییToolStripMenuItem
            // 
            this.مشاهدهداراییToolStripMenuItem.Name = "مشاهدهداراییToolStripMenuItem";
            this.مشاهدهداراییToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.مشاهدهداراییToolStripMenuItem.Text = "مشاهده دارایی";
            this.مشاهدهداراییToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهداراییToolStripMenuItem_Click);
            // 
            // برچسبToolStripMenuItem
            // 
            this.برچسبToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ایجادبرچسبToolStripMenuItem,
            this.حذفبرچسبToolStripMenuItem,
            this.بروزرسانیبرچسبToolStripMenuItem,
            this.مدیریتبرچسبمرکبToolStripMenuItem,
            this.مشاهدهلیستبرچسبهاToolStripMenuItem,
            this.مشاهدهیکبرچسبToolStripMenuItem});
            this.برچسبToolStripMenuItem.Name = "برچسبToolStripMenuItem";
            this.برچسبToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.برچسبToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.برچسبToolStripMenuItem.Text = "برچسب";
            // 
            // ایجادبرچسبToolStripMenuItem
            // 
            this.ایجادبرچسبToolStripMenuItem.Name = "ایجادبرچسبToolStripMenuItem";
            this.ایجادبرچسبToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.ایجادبرچسبToolStripMenuItem.Text = "ایجاد برچسب";
            this.ایجادبرچسبToolStripMenuItem.Click += new System.EventHandler(this.ایجادبرچسبToolStripMenuItem_Click);
            // 
            // حذفبرچسبToolStripMenuItem
            // 
            this.حذفبرچسبToolStripMenuItem.Name = "حذفبرچسبToolStripMenuItem";
            this.حذفبرچسبToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.حذفبرچسبToolStripMenuItem.Text = "حذف برچسب";
            this.حذفبرچسبToolStripMenuItem.Click += new System.EventHandler(this.حذفبرچسبToolStripMenuItem_Click);
            // 
            // بروزرسانیبرچسبToolStripMenuItem
            // 
            this.بروزرسانیبرچسبToolStripMenuItem.Name = "بروزرسانیبرچسبToolStripMenuItem";
            this.بروزرسانیبرچسبToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.بروزرسانیبرچسبToolStripMenuItem.Text = "بروزرسانی برچسب";
            this.بروزرسانیبرچسبToolStripMenuItem.Click += new System.EventHandler(this.بروزرسانیبرچسبToolStripMenuItem_Click);
            // 
            // مدیریتبرچسبمرکبToolStripMenuItem
            // 
            this.مدیریتبرچسبمرکبToolStripMenuItem.Name = "مدیریتبرچسبمرکبToolStripMenuItem";
            this.مدیریتبرچسبمرکبToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.مدیریتبرچسبمرکبToolStripMenuItem.Text = "مدیریت برچسب مرکب";
            this.مدیریتبرچسبمرکبToolStripMenuItem.Click += new System.EventHandler(this.مدیریتبرچسبمرکبToolStripMenuItem_Click);
            // 
            // مشاهدهلیستبرچسبهاToolStripMenuItem
            // 
            this.مشاهدهلیستبرچسبهاToolStripMenuItem.Name = "مشاهدهلیستبرچسبهاToolStripMenuItem";
            this.مشاهدهلیستبرچسبهاToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.مشاهدهلیستبرچسبهاToolStripMenuItem.Text = "مشاهده لیست برچسب ها";
            this.مشاهدهلیستبرچسبهاToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهلیستبرچسبهاToolStripMenuItem_Click);
            // 
            // مشاهدهیکبرچسبToolStripMenuItem
            // 
            this.مشاهدهیکبرچسبToolStripMenuItem.Name = "مشاهدهیکبرچسبToolStripMenuItem";
            this.مشاهدهیکبرچسبToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.مشاهدهیکبرچسبToolStripMenuItem.Text = "مشاهده یک برچسب";
            this.مشاهدهیکبرچسبToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهیکبرچسبToolStripMenuItem_Click);
            // 
            // مدیریتالصاقToolStripMenuItem
            // 
            this.مدیریتالصاقToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتالصاقبرچسببهداراییToolStripMenuItem});
            this.مدیریتالصاقToolStripMenuItem.Name = "مدیریتالصاقToolStripMenuItem";
            this.مدیریتالصاقToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.مدیریتالصاقToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.مدیریتالصاقToolStripMenuItem.Text = "مدیریت الصاق";
            // 
            // مدیریتالصاقبرچسببهداراییToolStripMenuItem
            // 
            this.مدیریتالصاقبرچسببهداراییToolStripMenuItem.Name = "مدیریتالصاقبرچسببهداراییToolStripMenuItem";
            this.مدیریتالصاقبرچسببهداراییToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.مدیریتالصاقبرچسببهداراییToolStripMenuItem.Text = "مدیریت الصاق برچسب به دارایی";
            this.مدیریتالصاقبرچسببهداراییToolStripMenuItem.Click += new System.EventHandler(this.مدیریتالصاقبرچسببهداراییToolStripMenuItem_Click);
            // 
            // ثبتتغییرToolStripMenuItem
            // 
            this.ثبتتغییرToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem});
            this.ثبتتغییرToolStripMenuItem.Name = "ثبتتغییرToolStripMenuItem";
            this.ثبتتغییرToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.ثبتتغییرToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.ثبتتغییرToolStripMenuItem.Text = "ثبت تغییر";
            // 
            // ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem
            // 
            this.ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem.Name = "ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem";
            this.ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem.Text = "ثبت تغییر وضعیت برچسب های دارایی";
            this.ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem.Click += new System.EventHandler(this.ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem_Click);
            // 
            // گزارشگیریToolStripMenuItem
            // 
            this.گزارشگیریToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.گزارشگیریبراساسبرچسبToolStripMenuItem,
            this.گزارشگیریبراساسداراییToolStripMenuItem,
            this.گزارشگیریبراساسیکعملخاصToolStripMenuItem,
            this.گزارشگیریسریزمانیToolStripMenuItem});
            this.گزارشگیریToolStripMenuItem.Name = "گزارشگیریToolStripMenuItem";
            this.گزارشگیریToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.گزارشگیریToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.گزارشگیریToolStripMenuItem.Text = "گزارش گیری";
            // 
            // گزارشگیریبراساسبرچسبToolStripMenuItem
            // 
            this.گزارشگیریبراساسبرچسبToolStripMenuItem.Name = "گزارشگیریبراساسبرچسبToolStripMenuItem";
            this.گزارشگیریبراساسبرچسبToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.گزارشگیریبراساسبرچسبToolStripMenuItem.Text = "گزارش گیری بر اساس برچسب";
            this.گزارشگیریبراساسبرچسبToolStripMenuItem.Click += new System.EventHandler(this.گزارشگیریبراساسبرچسبToolStripMenuItem_Click);
            // 
            // گزارشگیریبراساسداراییToolStripMenuItem
            // 
            this.گزارشگیریبراساسداراییToolStripMenuItem.Name = "گزارشگیریبراساسداراییToolStripMenuItem";
            this.گزارشگیریبراساسداراییToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.گزارشگیریبراساسداراییToolStripMenuItem.Text = "گزارش گیری بر اساس دارایی";
            this.گزارشگیریبراساسداراییToolStripMenuItem.Click += new System.EventHandler(this.گزارشگیریبراساسداراییToolStripMenuItem_Click);
            // 
            // گزارشگیریبراساسیکعملخاصToolStripMenuItem
            // 
            this.گزارشگیریبراساسیکعملخاصToolStripMenuItem.Name = "گزارشگیریبراساسیکعملخاصToolStripMenuItem";
            this.گزارشگیریبراساسیکعملخاصToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.گزارشگیریبراساسیکعملخاصToolStripMenuItem.Text = "گزارش گیری بر اساس یک عمل خاص";
            this.گزارشگیریبراساسیکعملخاصToolStripMenuItem.Click += new System.EventHandler(this.گزارشگیریبراساسیکعملخاصToolStripMenuItem_Click);
            // 
            // گزارشگیریسریزمانیToolStripMenuItem
            // 
            this.گزارشگیریسریزمانیToolStripMenuItem.Name = "گزارشگیریسریزمانیToolStripMenuItem";
            this.گزارشگیریسریزمانیToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.گزارشگیریسریزمانیToolStripMenuItem.Text = "گزارش گیری سری زمانی";
            this.گزارشگیریسریزمانیToolStripMenuItem.Click += new System.EventHandler(this.گزارشگیریسریزمانیToolStripMenuItem_Click);
            // 
            // سابقهToolStripMenuItem
            // 
            this.سابقهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهسابقهToolStripMenuItem,
            this.بازگرداندنیکداراییبهیکسابقهToolStripMenuItem,
            this.مدیریتنقطهمبناToolStripMenuItem});
            this.سابقهToolStripMenuItem.Name = "سابقهToolStripMenuItem";
            this.سابقهToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.سابقهToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.سابقهToolStripMenuItem.Text = "سابقه";
            this.سابقهToolStripMenuItem.Click += new System.EventHandler(this.سابقهToolStripMenuItem_Click);
            // 
            // مشاهدهسابقهToolStripMenuItem
            // 
            this.مشاهدهسابقهToolStripMenuItem.Name = "مشاهدهسابقهToolStripMenuItem";
            this.مشاهدهسابقهToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.مشاهدهسابقهToolStripMenuItem.Text = "مشاهده سابقه دارایی";
            this.مشاهدهسابقهToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهسابقهToolStripMenuItem_Click);
            // 
            // بازگرداندنیکداراییبهیکسابقهToolStripMenuItem
            // 
            this.بازگرداندنیکداراییبهیکسابقهToolStripMenuItem.Name = "بازگرداندنیکداراییبهیکسابقهToolStripMenuItem";
            this.بازگرداندنیکداراییبهیکسابقهToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.بازگرداندنیکداراییبهیکسابقهToolStripMenuItem.Text = "بازگرداندن یک دارایی به یک سابقه";
            this.بازگرداندنیکداراییبهیکسابقهToolStripMenuItem.Click += new System.EventHandler(this.بازگرداندنیکداراییبهیکسابقهToolStripMenuItem_Click);
            // 
            // مدیریتنقطهمبناToolStripMenuItem
            // 
            this.مدیریتنقطهمبناToolStripMenuItem.Name = "مدیریتنقطهمبناToolStripMenuItem";
            this.مدیریتنقطهمبناToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.مدیریتنقطهمبناToolStripMenuItem.Text = "مدیریت نقطه مبنا";
            this.مدیریتنقطهمبناToolStripMenuItem.Click += new System.EventHandler(this.مدیریتنقطهمبناToolStripMenuItem_Click);
            // 
            // عملیاتToolStripMenuItem
            // 
            this.عملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهلیستعملیاتToolStripMenuItem,
            this.تعریفعملیاتجدیدToolStripMenuItem,
            this.حذفعملیاتToolStripMenuItem,
            this.مدیریتعملیاتمرکبToolStripMenuItem,
            this.اعمالعملیاتToolStripMenuItem});
            this.عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            this.عملیاتToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.عملیاتToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.عملیاتToolStripMenuItem.Text = "عملیات";
            // 
            // مشاهدهلیستعملیاتToolStripMenuItem
            // 
            this.مشاهدهلیستعملیاتToolStripMenuItem.Name = "مشاهدهلیستعملیاتToolStripMenuItem";
            this.مشاهدهلیستعملیاتToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.مشاهدهلیستعملیاتToolStripMenuItem.Text = "مشاهده لیست عملیات";
            this.مشاهدهلیستعملیاتToolStripMenuItem.Click += new System.EventHandler(this.مشاهدهلیستعملیاتToolStripMenuItem_Click);
            // 
            // تعریفعملیاتجدیدToolStripMenuItem
            // 
            this.تعریفعملیاتجدیدToolStripMenuItem.Name = "تعریفعملیاتجدیدToolStripMenuItem";
            this.تعریفعملیاتجدیدToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.تعریفعملیاتجدیدToolStripMenuItem.Text = "تعریف عملیات جدید";
            this.تعریفعملیاتجدیدToolStripMenuItem.Click += new System.EventHandler(this.تعریفعملیاتجدیدToolStripMenuItem_Click);
            // 
            // حذفعملیاتToolStripMenuItem
            // 
            this.حذفعملیاتToolStripMenuItem.Name = "حذفعملیاتToolStripMenuItem";
            this.حذفعملیاتToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.حذفعملیاتToolStripMenuItem.Text = "حذف عملیات";
            this.حذفعملیاتToolStripMenuItem.Click += new System.EventHandler(this.حذفعملیاتToolStripMenuItem_Click);
            // 
            // مدیریتعملیاتمرکبToolStripMenuItem
            // 
            this.مدیریتعملیاتمرکبToolStripMenuItem.Name = "مدیریتعملیاتمرکبToolStripMenuItem";
            this.مدیریتعملیاتمرکبToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.مدیریتعملیاتمرکبToolStripMenuItem.Text = "مدیریت عملیات مرکب";
            this.مدیریتعملیاتمرکبToolStripMenuItem.Click += new System.EventHandler(this.مدیریتعملیاتمرکبToolStripMenuItem_Click);
            // 
            // اعمالعملیاتToolStripMenuItem
            // 
            this.اعمالعملیاتToolStripMenuItem.Name = "اعمالعملیاتToolStripMenuItem";
            this.اعمالعملیاتToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.اعمالعملیاتToolStripMenuItem.Text = "اعمال عملیات";
            this.اعمالعملیاتToolStripMenuItem.Click += new System.EventHandler(this.اعمالعملیاتToolStripMenuItem_Click);
            // 
            // رخدادToolStripMenuItem
            // 
            this.رخدادToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریترخدادToolStripMenuItem});
            this.رخدادToolStripMenuItem.Name = "رخدادToolStripMenuItem";
            this.رخدادToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.رخدادToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.رخدادToolStripMenuItem.Text = "رخداد";
            // 
            // مدیریترخدادToolStripMenuItem
            // 
            this.مدیریترخدادToolStripMenuItem.Name = "مدیریترخدادToolStripMenuItem";
            this.مدیریترخدادToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.مدیریترخدادToolStripMenuItem.Text = "مدیریت رخداد";
            this.مدیریترخدادToolStripMenuItem.Click += new System.EventHandler(this.مدیریترخدادToolStripMenuItem_Click);
            // 
            // تنظیماتToolStripMenuItem
            // 
            this.تنظیماتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تنظیمسیستمToolStripMenuItem,
            this.محاسبهمختصاتمکانیToolStripMenuItem,
            this.رمزهایعبورToolStripMenuItem});
            this.تنظیماتToolStripMenuItem.Name = "تنظیماتToolStripMenuItem";
            this.تنظیماتToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.تنظیماتToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.تنظیماتToolStripMenuItem.Text = "تنظیمات";
            // 
            // تنظیمسیستمToolStripMenuItem
            // 
            this.تنظیمسیستمToolStripMenuItem.Name = "تنظیمسیستمToolStripMenuItem";
            this.تنظیمسیستمToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.تنظیمسیستمToolStripMenuItem.Text = "زمان محاسبه وضعیت برچسب ها";
            this.تنظیمسیستمToolStripMenuItem.Click += new System.EventHandler(this.تنظیمسیستمToolStripMenuItem_Click);
            // 
            // محاسبهمختصاتمکانیToolStripMenuItem
            // 
            this.محاسبهمختصاتمکانیToolStripMenuItem.Name = "محاسبهمختصاتمکانیToolStripMenuItem";
            this.محاسبهمختصاتمکانیToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.محاسبهمختصاتمکانیToolStripMenuItem.Text = "محاسبه مختصات مکانی";
            this.محاسبهمختصاتمکانیToolStripMenuItem.Click += new System.EventHandler(this.محاسبهمختصاتمکانیToolStripMenuItem_Click);
            // 
            // رمزهایعبورToolStripMenuItem
            // 
            this.رمزهایعبورToolStripMenuItem.Name = "رمزهایعبورToolStripMenuItem";
            this.رمزهایعبورToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.رمزهایعبورToolStripMenuItem.Text = "رمزهای عبور";
            this.رمزهایعبورToolStripMenuItem.Click += new System.EventHandler(this.رمزهایعبورToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(71, 35);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 513);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "سامانه شهرداری";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem داراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ایجادداراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفداراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem برچسبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتالصاقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتتغییرToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشگیریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سابقهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رخدادToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تنظیماتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بروزرسانیداراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتداراییمرکبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهلیستداراییهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهداراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ایجادبرچسبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفبرچسبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بروزرسانیبرچسبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبرچسبمرکبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهلیستبرچسبهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهیکبرچسبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتالصاقبرچسببهداراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتتغییروضعیتبرچسبهایداراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشگیریبراساسبرچسبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشگیریبراساسداراییToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشگیریبراساسیکعملخاصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهسابقهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بازگرداندنیکداراییبهیکسابقهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهلیستعملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعریفعملیاتجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفعملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتعملیاتمرکبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اعمالعملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تنظیمسیستمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشگیریسریزمانیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتنقطهمبناToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریترخدادToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem محاسبهمختصاتمکانیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem رمزهایعبورToolStripMenuItem;

    }
}

