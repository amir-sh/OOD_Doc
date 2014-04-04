namespace WindowsFormsApplication1.forms.elsagh
{
    partial class ManageElsaghs
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
            this.label4 = new System.Windows.Forms.Label();
            this.AssignedLabelsCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DetachAssignedLabel = new System.Windows.Forms.Button();
            this.LabelValueTextbox = new System.Windows.Forms.TextBox();
            this.AssignLabelButton = new System.Windows.Forms.Button();
            this.LabelValueCheckbox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectLabelTextbox = new System.Windows.Forms.TextBox();
            this.LabelTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelGridView = new System.Windows.Forms.DataGridView();
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelConstraint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAttached = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectAssetTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AssignedLabelsCombobox);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SelectAssetTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(758, 505);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت الصاق برچسب به دارایی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "برچسب های الصاق شده:";
            // 
            // AssignedLabelsCombobox
            // 
            this.AssignedLabelsCombobox.FormattingEnabled = true;
            this.AssignedLabelsCombobox.Location = new System.Drawing.Point(50, 55);
            this.AssignedLabelsCombobox.Name = "AssignedLabelsCombobox";
            this.AssignedLabelsCombobox.Size = new System.Drawing.Size(121, 29);
            this.AssignedLabelsCombobox.TabIndex = 17;
            this.AssignedLabelsCombobox.SelectedValueChanged += new System.EventHandler(this.AssignedLabelsCombobox_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.DetachAssignedLabel);
            this.groupBox2.Controls.Add(this.LabelValueTextbox);
            this.groupBox2.Controls.Add(this.AssignLabelButton);
            this.groupBox2.Controls.Add(this.LabelValueCheckbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SelectLabelTextbox);
            this.groupBox2.Controls.Add(this.LabelTreeView);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LabelGridView);
            this.groupBox2.Location = new System.Drawing.Point(28, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 338);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الصاق برچسب";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "اعتبارسنجی";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DetachAssignedLabel
            // 
            this.DetachAssignedLabel.Location = new System.Drawing.Point(68, 118);
            this.DetachAssignedLabel.Name = "DetachAssignedLabel";
            this.DetachAssignedLabel.Size = new System.Drawing.Size(75, 30);
            this.DetachAssignedLabel.TabIndex = 12;
            this.DetachAssignedLabel.Text = "جداکردن برچسب";
            this.DetachAssignedLabel.UseVisualStyleBackColor = true;
            this.DetachAssignedLabel.Click += new System.EventHandler(this.DetachAssignedLabel_Click);
            // 
            // LabelValueTextbox
            // 
            this.LabelValueTextbox.Location = new System.Drawing.Point(457, 92);
            this.LabelValueTextbox.Name = "LabelValueTextbox";
            this.LabelValueTextbox.Size = new System.Drawing.Size(123, 29);
            this.LabelValueTextbox.TabIndex = 16;
            this.LabelValueTextbox.TextChanged += new System.EventHandler(this.LabelValueTextbox_TextChanged);
            this.LabelValueTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabelValueTextbox_KeyDown);
            // 
            // AssignLabelButton
            // 
            this.AssignLabelButton.Location = new System.Drawing.Point(68, 19);
            this.AssignLabelButton.Name = "AssignLabelButton";
            this.AssignLabelButton.Size = new System.Drawing.Size(75, 32);
            this.AssignLabelButton.TabIndex = 11;
            this.AssignLabelButton.Text = "الصاق برچسب";
            this.AssignLabelButton.UseVisualStyleBackColor = true;
            this.AssignLabelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelValueCheckbox
            // 
            this.LabelValueCheckbox.FormattingEnabled = true;
            this.LabelValueCheckbox.Location = new System.Drawing.Point(457, 72);
            this.LabelValueCheckbox.Name = "LabelValueCheckbox";
            this.LabelValueCheckbox.Size = new System.Drawing.Size(123, 76);
            this.LabelValueCheckbox.TabIndex = 15;
            this.LabelValueCheckbox.Visible = false;
            this.LabelValueCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.LabelValueCheckbox_ItemCheck);
            this.LabelValueCheckbox.SelectedIndexChanged += new System.EventHandler(this.LabelValueCheckbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "مقدار برچسب:";
            // 
            // SelectLabelTextbox
            // 
            this.SelectLabelTextbox.Location = new System.Drawing.Point(457, 22);
            this.SelectLabelTextbox.Name = "SelectLabelTextbox";
            this.SelectLabelTextbox.Size = new System.Drawing.Size(123, 29);
            this.SelectLabelTextbox.TabIndex = 13;
            this.SelectLabelTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectLabelTextbox_KeyDown);
            // 
            // LabelTreeView
            // 
            this.LabelTreeView.Location = new System.Drawing.Point(203, 22);
            this.LabelTreeView.Name = "LabelTreeView";
            this.LabelTreeView.RightToLeftLayout = true;
            this.LabelTreeView.Size = new System.Drawing.Size(206, 126);
            this.LabelTreeView.TabIndex = 1;
            this.LabelTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.LabelTreeView_NodeMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(603, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "انتخاب برچسب:";
            // 
            // LabelGridView
            // 
            this.LabelGridView.AllowUserToAddRows = false;
            this.LabelGridView.AllowUserToDeleteRows = false;
            this.LabelGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LabelGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LabelGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LabelGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabelName,
            this.LabelType,
            this.LabelConstraint,
            this.LabelValue,
            this.IsAttached});
            this.LabelGridView.Location = new System.Drawing.Point(18, 213);
            this.LabelGridView.Name = "LabelGridView";
            this.LabelGridView.RowHeadersWidth = 20;
            this.LabelGridView.Size = new System.Drawing.Size(665, 95);
            this.LabelGridView.TabIndex = 0;
            // 
            // LabelName
            // 
            this.LabelName.HeaderText = "نام زیر برچسب";
            this.LabelName.MinimumWidth = 2;
            this.LabelName.Name = "LabelName";
            // 
            // LabelType
            // 
            this.LabelType.HeaderText = "نوع برچسب";
            this.LabelType.Name = "LabelType";
            // 
            // LabelConstraint
            // 
            this.LabelConstraint.HeaderText = "محدودیت مقدار";
            this.LabelConstraint.Name = "LabelConstraint";
            // 
            // LabelValue
            // 
            this.LabelValue.HeaderText = "مقدار فعلی";
            this.LabelValue.Name = "LabelValue";
            // 
            // IsAttached
            // 
            this.IsAttached.HeaderText = "وضعیت الصاق";
            this.IsAttached.Name = "IsAttached";
            // 
            // SelectAssetTextbox
            // 
            this.SelectAssetTextbox.Location = new System.Drawing.Point(482, 55);
            this.SelectAssetTextbox.Name = "SelectAssetTextbox";
            this.SelectAssetTextbox.Size = new System.Drawing.Size(123, 29);
            this.SelectAssetTextbox.TabIndex = 9;
            this.SelectAssetTextbox.TextChanged += new System.EventHandler(this.SelectAssetTextbox_TextChanged);
            this.SelectAssetTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectAssetTextbox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "انتخاب دارایی:";
            // 
            // ManageElsaghs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageElsaghs";
            this.Size = new System.Drawing.Size(766, 510);
            this.Load += new System.EventHandler(this.SelectLabelTextbox_Load) + new System.EventHandler(this.SelectAssetTextbox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView LabelGridView;
        private System.Windows.Forms.TextBox SelectAssetTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView LabelTreeView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button AssignLabelButton;
        private System.Windows.Forms.TextBox SelectLabelTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox LabelValueCheckbox;
        private System.Windows.Forms.TextBox LabelValueTextbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelConstraint;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAttached;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DetachAssignedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AssignedLabelsCombobox;
    }
}
