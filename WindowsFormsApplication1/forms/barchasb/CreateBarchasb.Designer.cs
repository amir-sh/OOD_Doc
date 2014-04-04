namespace WindowsFormsApplication1.forms.barchasb
{
    partial class CreateBarchasb
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.CreateButton = new System.Windows.Forms.Button();
            this.DiscreteRbutton = new System.Windows.Forms.RadioButton();
            this.ContinuosRbutton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DiscreteGroup = new System.Windows.Forms.GroupBox();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.RemoveStateButton = new System.Windows.Forms.Button();
            this.RemoveStateCombobox = new System.Windows.Forms.ComboBox();
            this.AddedStateTextbox = new System.Windows.Forms.TextBox();
            this.AddStateButton = new System.Windows.Forms.Button();
            this.StatesListbox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IntGroup = new System.Windows.Forms.GroupBox();
            this.DefaultValTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxValTextbox = new System.Windows.Forms.TextBox();
            this.MinValTexbox = new System.Windows.Forms.TextBox();
            this.NewLabelTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderRadiobutton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DiscreteGroup.SuspendLayout();
            this.IntGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(298, 357);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 29);
            this.CreateButton.TabIndex = 11;
            this.CreateButton.Text = "ایجاد برچسب";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DiscreteRbutton
            // 
            this.DiscreteRbutton.AutoSize = true;
            this.DiscreteRbutton.Location = new System.Drawing.Point(520, 34);
            this.DiscreteRbutton.Margin = new System.Windows.Forms.Padding(2);
            this.DiscreteRbutton.Name = "DiscreteRbutton";
            this.DiscreteRbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DiscreteRbutton.Size = new System.Drawing.Size(63, 27);
            this.DiscreteRbutton.TabIndex = 13;
            this.DiscreteRbutton.TabStop = true;
            this.DiscreteRbutton.Text = "گسسته";
            this.DiscreteRbutton.UseVisualStyleBackColor = true;
            this.DiscreteRbutton.CheckedChanged += new System.EventHandler(this.DiscreteRbutton_CheckedChanged);
            // 
            // ContinuosRbutton
            // 
            this.ContinuosRbutton.AutoSize = true;
            this.ContinuosRbutton.Location = new System.Drawing.Point(522, 83);
            this.ContinuosRbutton.Margin = new System.Windows.Forms.Padding(2);
            this.ContinuosRbutton.Name = "ContinuosRbutton";
            this.ContinuosRbutton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContinuosRbutton.Size = new System.Drawing.Size(61, 27);
            this.ContinuosRbutton.TabIndex = 13;
            this.ContinuosRbutton.TabStop = true;
            this.ContinuosRbutton.Text = "پیوسته";
            this.ContinuosRbutton.UseVisualStyleBackColor = true;
            this.ContinuosRbutton.CheckedChanged += new System.EventHandler(this.ContinuosRbutton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "عدد شروع:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "عدد پایان:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.NewLabelTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(758, 505);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ایجاد برچسب";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "حالت عددی",
            "حالت گسسته"});
            this.checkedListBox1.Location = new System.Drawing.Point(88, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox1.Size = new System.Drawing.Size(93, 52);
            this.checkedListBox1.TabIndex = 38;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(293, 43);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(143, 27);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "برچسب تعریف گر دارایی";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DiscreteGroup);
            this.groupBox2.Controls.Add(this.IntGroup);
            this.groupBox2.Controls.Add(this.CreateButton);
            this.groupBox2.Location = new System.Drawing.Point(33, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 400);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حالت برچسب";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DiscreteGroup
            // 
            this.DiscreteGroup.Controls.Add(this.OrderRadiobutton);
            this.DiscreteGroup.Controls.Add(this.DownButton);
            this.DiscreteGroup.Controls.Add(this.UpButton);
            this.DiscreteGroup.Controls.Add(this.RemoveStateButton);
            this.DiscreteGroup.Controls.Add(this.RemoveStateCombobox);
            this.DiscreteGroup.Controls.Add(this.AddedStateTextbox);
            this.DiscreteGroup.Controls.Add(this.AddStateButton);
            this.DiscreteGroup.Controls.Add(this.StatesListbox);
            this.DiscreteGroup.Controls.Add(this.label7);
            this.DiscreteGroup.Controls.Add(this.label5);
            this.DiscreteGroup.Enabled = false;
            this.DiscreteGroup.Location = new System.Drawing.Point(36, 180);
            this.DiscreteGroup.Name = "DiscreteGroup";
            this.DiscreteGroup.Size = new System.Drawing.Size(608, 172);
            this.DiscreteGroup.TabIndex = 1;
            this.DiscreteGroup.TabStop = false;
            this.DiscreteGroup.Text = "حالت گسسته";
            this.DiscreteGroup.Enter += new System.EventHandler(this.DiscreteGroup_Enter);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(162, 79);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(67, 32);
            this.DownButton.TabIndex = 39;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(162, 25);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(67, 32);
            this.UpButton.TabIndex = 38;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // RemoveStateButton
            // 
            this.RemoveStateButton.Location = new System.Drawing.Point(321, 79);
            this.RemoveStateButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveStateButton.Name = "RemoveStateButton";
            this.RemoveStateButton.Size = new System.Drawing.Size(75, 32);
            this.RemoveStateButton.TabIndex = 28;
            this.RemoveStateButton.Text = "حذف ";
            this.RemoveStateButton.UseVisualStyleBackColor = true;
            this.RemoveStateButton.Click += new System.EventHandler(this.RemoveStateButton_Click);
            // 
            // RemoveStateCombobox
            // 
            this.RemoveStateCombobox.FormattingEnabled = true;
            this.RemoveStateCombobox.Items.AddRange(new object[] {
            "خوب",
            "بد",
            "متوسط"});
            this.RemoveStateCombobox.Location = new System.Drawing.Point(421, 82);
            this.RemoveStateCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveStateCombobox.Name = "RemoveStateCombobox";
            this.RemoveStateCombobox.Size = new System.Drawing.Size(100, 29);
            this.RemoveStateCombobox.TabIndex = 35;
            this.RemoveStateCombobox.SelectedIndexChanged += new System.EventHandler(this.RemoveStateCombobox_SelectedIndexChanged);
            // 
            // AddedStateTextbox
            // 
            this.AddedStateTextbox.Location = new System.Drawing.Point(421, 28);
            this.AddedStateTextbox.Name = "AddedStateTextbox";
            this.AddedStateTextbox.Size = new System.Drawing.Size(100, 29);
            this.AddedStateTextbox.TabIndex = 37;
            this.AddedStateTextbox.TextChanged += new System.EventHandler(this.AddedStateTextbox_TextChanged);
            // 
            // AddStateButton
            // 
            this.AddStateButton.Location = new System.Drawing.Point(320, 25);
            this.AddStateButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddStateButton.Name = "AddStateButton";
            this.AddStateButton.Size = new System.Drawing.Size(75, 32);
            this.AddStateButton.TabIndex = 21;
            this.AddStateButton.Text = "اضافه ";
            this.AddStateButton.UseVisualStyleBackColor = true;
            this.AddStateButton.Click += new System.EventHandler(this.AddStateButton_Click);
            // 
            // StatesListbox
            // 
            this.StatesListbox.FormattingEnabled = true;
            this.StatesListbox.ItemHeight = 21;
            this.StatesListbox.Items.AddRange(new object[] {
            ""});
            this.StatesListbox.Location = new System.Drawing.Point(27, 20);
            this.StatesListbox.Margin = new System.Windows.Forms.Padding(2);
            this.StatesListbox.Name = "StatesListbox";
            this.StatesListbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatesListbox.Size = new System.Drawing.Size(90, 88);
            this.StatesListbox.TabIndex = 25;
            this.StatesListbox.SelectedIndexChanged += new System.EventHandler(this.StatesListbox_SelectedIndexChanged);
            this.StatesListbox.DoubleClick += new System.EventHandler(this.StatesListbox_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "نام حالت:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "نام حالت:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // IntGroup
            // 
            this.IntGroup.Controls.Add(this.DefaultValTextbox);
            this.IntGroup.Controls.Add(this.label8);
            this.IntGroup.Controls.Add(this.MaxValTextbox);
            this.IntGroup.Controls.Add(this.DiscreteRbutton);
            this.IntGroup.Controls.Add(this.ContinuosRbutton);
            this.IntGroup.Controls.Add(this.label3);
            this.IntGroup.Controls.Add(this.MinValTexbox);
            this.IntGroup.Controls.Add(this.label4);
            this.IntGroup.Enabled = false;
            this.IntGroup.Location = new System.Drawing.Point(36, 29);
            this.IntGroup.Name = "IntGroup";
            this.IntGroup.Size = new System.Drawing.Size(608, 145);
            this.IntGroup.TabIndex = 0;
            this.IntGroup.TabStop = false;
            this.IntGroup.Text = "حالت عددی";
            this.IntGroup.Enter += new System.EventHandler(this.IntGroup_Enter);
            // 
            // DefaultValTextbox
            // 
            this.DefaultValTextbox.Location = new System.Drawing.Point(27, 34);
            this.DefaultValTextbox.Name = "DefaultValTextbox";
            this.DefaultValTextbox.Size = new System.Drawing.Size(85, 29);
            this.DefaultValTextbox.TabIndex = 22;
            this.DefaultValTextbox.TextChanged += new System.EventHandler(this.DefaultValTextbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "مقدار پیش فرض :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // MaxValTextbox
            // 
            this.MaxValTextbox.Location = new System.Drawing.Point(321, 83);
            this.MaxValTextbox.Name = "MaxValTextbox";
            this.MaxValTextbox.Size = new System.Drawing.Size(75, 29);
            this.MaxValTextbox.TabIndex = 20;
            this.MaxValTextbox.TextChanged += new System.EventHandler(this.MaxValTextbox_TextChanged);
            // 
            // MinValTexbox
            // 
            this.MinValTexbox.Location = new System.Drawing.Point(320, 34);
            this.MinValTexbox.Margin = new System.Windows.Forms.Padding(2);
            this.MinValTexbox.Name = "MinValTexbox";
            this.MinValTexbox.Size = new System.Drawing.Size(76, 29);
            this.MinValTexbox.TabIndex = 19;
            this.MinValTexbox.TextChanged += new System.EventHandler(this.MinValTexbox_TextChanged);
            // 
            // NewLabelTextbox
            // 
            this.NewLabelTextbox.Location = new System.Drawing.Point(507, 41);
            this.NewLabelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.NewLabelTextbox.Name = "NewLabelTextbox";
            this.NewLabelTextbox.Size = new System.Drawing.Size(117, 29);
            this.NewLabelTextbox.TabIndex = 32;
            this.NewLabelTextbox.TextChanged += new System.EventHandler(this.NewLabelTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "نام برچسب:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderRadiobutton
            // 
            this.OrderRadiobutton.AutoSize = true;
            this.OrderRadiobutton.Location = new System.Drawing.Point(458, 129);
            this.OrderRadiobutton.Name = "OrderRadiobutton";
            this.OrderRadiobutton.Size = new System.Drawing.Size(136, 27);
            this.OrderRadiobutton.TabIndex = 40;
            this.OrderRadiobutton.TabStop = true;
            this.OrderRadiobutton.Text = "حالات ترتیب دار باشند";
            this.OrderRadiobutton.UseVisualStyleBackColor = true;
            // 
            // CreateBarchasb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CreateBarchasb";
            this.Size = new System.Drawing.Size(766, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.DiscreteGroup.ResumeLayout(false);
            this.DiscreteGroup.PerformLayout();
            this.IntGroup.ResumeLayout(false);
            this.IntGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button CreateButton;
        protected System.Windows.Forms.RadioButton DiscreteRbutton;
        protected System.Windows.Forms.RadioButton ContinuosRbutton;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox NewLabelTextbox;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox RemoveStateCombobox;
        protected System.Windows.Forms.Button RemoveStateButton;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.ListBox StatesListbox;
        protected System.Windows.Forms.Button AddStateButton;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox MinValTexbox;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.GroupBox IntGroup;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox MaxValTextbox;
        protected System.Windows.Forms.GroupBox DiscreteGroup;
        protected System.Windows.Forms.TextBox AddedStateTextbox;
        protected System.Windows.Forms.TextBox DefaultValTextbox;
        protected System.Windows.Forms.Button DownButton;
        protected System.Windows.Forms.Button UpButton;
        protected System.Windows.Forms.RadioButton radioButton3;
        protected System.Windows.Forms.CheckedListBox checkedListBox1;
        protected System.Windows.Forms.RadioButton OrderRadiobutton;
    }
}
