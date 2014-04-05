namespace WindowsFormsApplication1.forms.change
{
    partial class ChangeBarchasb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelTreeView = new System.Windows.Forms.TreeView();
            this.NewValCheckbox = new System.Windows.Forms.CheckedListBox();
            this.NewValTextbox = new System.Windows.Forms.TextBox();
            this.CurrentValTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectedLabelTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectLabelCombobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectAssetTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelTreeView);
            this.groupBox1.Controls.Add(this.NewValCheckbox);
            this.groupBox1.Controls.Add(this.NewValTextbox);
            this.groupBox1.Controls.Add(this.CurrentValTextbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SelectedLabelTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SelectLabelCombobox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SelectAssetTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(758, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تغییر وضیت برچسب های دارایی";
            // 
            // LabelTreeView
            // 
            this.LabelTreeView.Location = new System.Drawing.Point(172, 48);
            this.LabelTreeView.Name = "LabelTreeView";
            this.LabelTreeView.Size = new System.Drawing.Size(173, 227);
            this.LabelTreeView.TabIndex = 22;
            this.LabelTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LabelTreeView_AfterSelect);
            // 
            // NewValCheckbox
            // 
            this.NewValCheckbox.FormattingEnabled = true;
            this.NewValCheckbox.Location = new System.Drawing.Point(497, 307);
            this.NewValCheckbox.Name = "NewValCheckbox";
            this.NewValCheckbox.Size = new System.Drawing.Size(104, 76);
            this.NewValCheckbox.TabIndex = 21;
            // 
            // NewValTextbox
            // 
            this.NewValTextbox.Location = new System.Drawing.Point(497, 307);
            this.NewValTextbox.Name = "NewValTextbox";
            this.NewValTextbox.Size = new System.Drawing.Size(104, 29);
            this.NewValTextbox.TabIndex = 20;
            // 
            // CurrentValTextbox
            // 
            this.CurrentValTextbox.Location = new System.Drawing.Point(497, 246);
            this.CurrentValTextbox.Name = "CurrentValTextbox";
            this.CurrentValTextbox.Size = new System.Drawing.Size(105, 29);
            this.CurrentValTextbox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "وضعیت فعلی:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "وضعیت جدید:";
            // 
            // SelectedLabelTextbox
            // 
            this.SelectedLabelTextbox.Location = new System.Drawing.Point(497, 177);
            this.SelectedLabelTextbox.Name = "SelectedLabelTextbox";
            this.SelectedLabelTextbox.Size = new System.Drawing.Size(105, 29);
            this.SelectedLabelTextbox.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "برچسب انتخاب شده:";
            // 
            // SelectLabelCombobox
            // 
            this.SelectLabelCombobox.FormattingEnabled = true;
            this.SelectLabelCombobox.Items.AddRange(new object[] {
            "خوب",
            "بد",
            "متوسط"});
            this.SelectLabelCombobox.Location = new System.Drawing.Point(497, 106);
            this.SelectLabelCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectLabelCombobox.Name = "SelectLabelCombobox";
            this.SelectLabelCombobox.Size = new System.Drawing.Size(105, 29);
            this.SelectLabelCombobox.TabIndex = 14;
            this.SelectLabelCombobox.SelectedIndexChanged += new System.EventHandler(this.SelectLabelCombobox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "ثبت تغییرات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(658, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "برچسب ها:";
            // 
            // SelectAssetTextbox
            // 
            this.SelectAssetTextbox.Location = new System.Drawing.Point(497, 48);
            this.SelectAssetTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectAssetTextbox.Name = "SelectAssetTextbox";
            this.SelectAssetTextbox.Size = new System.Drawing.Size(105, 29);
            this.SelectAssetTextbox.TabIndex = 4;
            this.SelectAssetTextbox.Text = "پارک گلایل";
            this.SelectAssetTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectAssetTextbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "انتخاب دارایی:";
            // 
            // ChangeBarchasb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeBarchasb";
            this.Size = new System.Drawing.Size(766, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SelectAssetTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox SelectLabelCombobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SelectedLabelTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView LabelTreeView;
        private System.Windows.Forms.CheckedListBox NewValCheckbox;
        private System.Windows.Forms.TextBox NewValTextbox;
        private System.Windows.Forms.TextBox CurrentValTextbox;
    }
}
