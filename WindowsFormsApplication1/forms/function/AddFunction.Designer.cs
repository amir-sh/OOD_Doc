namespace WindowsFormsApplication1.forms.function
{
    partial class AddFunction
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
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.ActionView = new System.Windows.Forms.DataGridView();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.AddSubActionGroupbox = new System.Windows.Forms.GroupBox();
            this.SubActionTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddSubActionButton = new System.Windows.Forms.Button();
            this.AddSubActionCheckbox = new System.Windows.Forms.CheckBox();
            this.RemoveActionGroupbox = new System.Windows.Forms.GroupBox();
            this.RemoveLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.RemoveLevelButton = new System.Windows.Forms.Button();
            this.AddSimpleActionCheckbox = new System.Windows.Forms.CheckBox();
            this.AddSimpleActionGroupbox = new System.Windows.Forms.GroupBox();
            this.HasInputCheckbox = new System.Windows.Forms.CheckBox();
            this.NewStateTextbox = new System.Windows.Forms.TextBox();
            this.AssignedLabelTreeView = new System.Windows.Forms.TreeView();
            this.StatesCheckbox = new System.Windows.Forms.CheckedListBox();
            this.SelectAssetTextbox = new System.Windows.Forms.TextBox();
            this.AddSimpleActionButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AssignedLabelCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ActionNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionView)).BeginInit();
            this.AddSubActionGroupbox.SuspendLayout();
            this.RemoveActionGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveLevelNumericUpDown)).BeginInit();
            this.AddSimpleActionGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DownButton);
            this.groupBox1.Controls.Add(this.UpButton);
            this.groupBox1.Controls.Add(this.ActionView);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.AddSubActionGroupbox);
            this.groupBox1.Controls.Add(this.AddSubActionCheckbox);
            this.groupBox1.Controls.Add(this.RemoveActionGroupbox);
            this.groupBox1.Controls.Add(this.AddSimpleActionCheckbox);
            this.groupBox1.Controls.Add(this.AddSimpleActionGroupbox);
            this.groupBox1.Controls.Add(this.ActionNameTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(759, 507);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن عملیات";
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(191, 401);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(60, 33);
            this.DownButton.TabIndex = 13;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(191, 365);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(60, 30);
            this.UpButton.TabIndex = 13;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // ActionView
            // 
            this.ActionView.AllowUserToAddRows = false;
            this.ActionView.AllowUserToDeleteRows = false;
            this.ActionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.SubAction,
            this.AssetName,
            this.LabelName,
            this.Input,
            this.NewState});
            this.ActionView.Location = new System.Drawing.Point(261, 322);
            this.ActionView.Name = "ActionView";
            this.ActionView.Size = new System.Drawing.Size(491, 150);
            this.ActionView.TabIndex = 26;
            // 
            // Level
            // 
            this.Level.HeaderText = "مرحله";
            this.Level.Name = "Level";
            // 
            // SubAction
            // 
            this.SubAction.HeaderText = "زیر عملیات";
            this.SubAction.Name = "SubAction";
            // 
            // AssetName
            // 
            this.AssetName.HeaderText = "دارایی";
            this.AssetName.Name = "AssetName";
            // 
            // LabelName
            // 
            this.LabelName.HeaderText = "برچسب";
            this.LabelName.Name = "LabelName";
            // 
            // Input
            // 
            this.Input.HeaderText = "ورودی";
            this.Input.Name = "Input";
            // 
            // NewState
            // 
            this.NewState.HeaderText = "وضعیت جدید";
            this.NewState.Name = "NewState";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(17, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 40);
            this.button5.TabIndex = 25;
            this.button5.Text = "ثبت عملیات";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AddSubActionGroupbox
            // 
            this.AddSubActionGroupbox.Controls.Add(this.SubActionTextbox);
            this.AddSubActionGroupbox.Controls.Add(this.label6);
            this.AddSubActionGroupbox.Controls.Add(this.AddSubActionButton);
            this.AddSubActionGroupbox.Location = new System.Drawing.Point(261, 84);
            this.AddSubActionGroupbox.Name = "AddSubActionGroupbox";
            this.AddSubActionGroupbox.Size = new System.Drawing.Size(491, 232);
            this.AddSubActionGroupbox.TabIndex = 20;
            this.AddSubActionGroupbox.TabStop = false;
            this.AddSubActionGroupbox.Text = "اضافه کردن زیر عملیات";
            this.AddSubActionGroupbox.Visible = false;
            // 
            // SubActionTextbox
            // 
            this.SubActionTextbox.Location = new System.Drawing.Point(148, 76);
            this.SubActionTextbox.Name = "SubActionTextbox";
            this.SubActionTextbox.Size = new System.Drawing.Size(119, 29);
            this.SubActionTextbox.TabIndex = 12;
            this.SubActionTextbox.TextChanged += new System.EventHandler(this.SubActionTextbox_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = " عملیات:";
            // 
            // AddSubActionButton
            // 
            this.AddSubActionButton.Location = new System.Drawing.Point(219, 155);
            this.AddSubActionButton.Name = "AddSubActionButton";
            this.AddSubActionButton.Size = new System.Drawing.Size(75, 29);
            this.AddSubActionButton.TabIndex = 0;
            this.AddSubActionButton.Text = "اضافه";
            this.AddSubActionButton.UseVisualStyleBackColor = true;
            this.AddSubActionButton.Click += new System.EventHandler(this.AddSubActionButton_Click);
            // 
            // AddSubActionCheckbox
            // 
            this.AddSubActionCheckbox.AutoSize = true;
            this.AddSubActionCheckbox.Location = new System.Drawing.Point(363, 56);
            this.AddSubActionCheckbox.Name = "AddSubActionCheckbox";
            this.AddSubActionCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddSubActionCheckbox.Size = new System.Drawing.Size(139, 27);
            this.AddSubActionCheckbox.TabIndex = 23;
            this.AddSubActionCheckbox.Text = "اضافه کردن زیر عملیات";
            this.AddSubActionCheckbox.UseVisualStyleBackColor = true;
            this.AddSubActionCheckbox.CheckedChanged += new System.EventHandler(this.AddSubActionCheckbox_CheckedChanged);
            // 
            // RemoveActionGroupbox
            // 
            this.RemoveActionGroupbox.Controls.Add(this.RemoveLevelNumericUpDown);
            this.RemoveActionGroupbox.Controls.Add(this.label17);
            this.RemoveActionGroupbox.Controls.Add(this.RemoveLevelButton);
            this.RemoveActionGroupbox.Location = new System.Drawing.Point(17, 84);
            this.RemoveActionGroupbox.Name = "RemoveActionGroupbox";
            this.RemoveActionGroupbox.Size = new System.Drawing.Size(234, 232);
            this.RemoveActionGroupbox.TabIndex = 22;
            this.RemoveActionGroupbox.TabStop = false;
            this.RemoveActionGroupbox.Text = "حذف زیر عملیات";
            // 
            // RemoveLevelNumericUpDown
            // 
            this.RemoveLevelNumericUpDown.Location = new System.Drawing.Point(22, 41);
            this.RemoveLevelNumericUpDown.Name = "RemoveLevelNumericUpDown";
            this.RemoveLevelNumericUpDown.Size = new System.Drawing.Size(120, 29);
            this.RemoveLevelNumericUpDown.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(174, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 23);
            this.label17.TabIndex = 10;
            this.label17.Text = "مرحله :";
            // 
            // RemoveLevelButton
            // 
            this.RemoveLevelButton.Location = new System.Drawing.Point(83, 155);
            this.RemoveLevelButton.Name = "RemoveLevelButton";
            this.RemoveLevelButton.Size = new System.Drawing.Size(73, 29);
            this.RemoveLevelButton.TabIndex = 8;
            this.RemoveLevelButton.Text = "حذف";
            this.RemoveLevelButton.UseVisualStyleBackColor = true;
            this.RemoveLevelButton.Click += new System.EventHandler(this.RemoveLevelButton_Click);
            // 
            // AddSimpleActionCheckbox
            // 
            this.AddSimpleActionCheckbox.AutoSize = true;
            this.AddSimpleActionCheckbox.Checked = true;
            this.AddSimpleActionCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AddSimpleActionCheckbox.Location = new System.Drawing.Point(637, 56);
            this.AddSimpleActionCheckbox.Name = "AddSimpleActionCheckbox";
            this.AddSimpleActionCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddSimpleActionCheckbox.Size = new System.Drawing.Size(115, 27);
            this.AddSimpleActionCheckbox.TabIndex = 21;
            this.AddSimpleActionCheckbox.Text = "اضافه کردن مرحله";
            this.AddSimpleActionCheckbox.UseVisualStyleBackColor = true;
            this.AddSimpleActionCheckbox.CheckedChanged += new System.EventHandler(this.AddSimpleActionCheckbox_CheckedChanged);
            // 
            // AddSimpleActionGroupbox
            // 
            this.AddSimpleActionGroupbox.Controls.Add(this.HasInputCheckbox);
            this.AddSimpleActionGroupbox.Controls.Add(this.NewStateTextbox);
            this.AddSimpleActionGroupbox.Controls.Add(this.AssignedLabelTreeView);
            this.AddSimpleActionGroupbox.Controls.Add(this.StatesCheckbox);
            this.AddSimpleActionGroupbox.Controls.Add(this.SelectAssetTextbox);
            this.AddSimpleActionGroupbox.Controls.Add(this.AddSimpleActionButton);
            this.AddSimpleActionGroupbox.Controls.Add(this.textBox2);
            this.AddSimpleActionGroupbox.Controls.Add(this.label5);
            this.AddSimpleActionGroupbox.Controls.Add(this.AssignedLabelCombobox);
            this.AddSimpleActionGroupbox.Controls.Add(this.label4);
            this.AddSimpleActionGroupbox.Controls.Add(this.label3);
            this.AddSimpleActionGroupbox.Location = new System.Drawing.Point(261, 84);
            this.AddSimpleActionGroupbox.Name = "AddSimpleActionGroupbox";
            this.AddSimpleActionGroupbox.Size = new System.Drawing.Size(491, 232);
            this.AddSimpleActionGroupbox.TabIndex = 19;
            this.AddSimpleActionGroupbox.TabStop = false;
            this.AddSimpleActionGroupbox.Text = "مراحل عملیات";
            // 
            // HasInputCheckbox
            // 
            this.HasInputCheckbox.AutoSize = true;
            this.HasInputCheckbox.Location = new System.Drawing.Point(319, 189);
            this.HasInputCheckbox.Name = "HasInputCheckbox";
            this.HasInputCheckbox.Size = new System.Drawing.Size(83, 27);
            this.HasInputCheckbox.TabIndex = 24;
            this.HasInputCheckbox.Text = "ورودی دارد";
            this.HasInputCheckbox.UseVisualStyleBackColor = true;
            this.HasInputCheckbox.CheckedChanged += new System.EventHandler(this.HasInputCheckbox_CheckedChanged);
            // 
            // NewStateTextbox
            // 
            this.NewStateTextbox.Location = new System.Drawing.Point(283, 95);
            this.NewStateTextbox.Name = "NewStateTextbox";
            this.NewStateTextbox.Size = new System.Drawing.Size(119, 29);
            this.NewStateTextbox.TabIndex = 23;
            // 
            // AssignedLabelTreeView
            // 
            this.AssignedLabelTreeView.Location = new System.Drawing.Point(102, 26);
            this.AssignedLabelTreeView.Name = "AssignedLabelTreeView";
            this.AssignedLabelTreeView.Size = new System.Drawing.Size(121, 145);
            this.AssignedLabelTreeView.TabIndex = 21;
            this.AssignedLabelTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AssignedLabelTreeView_AfterSelect);
            // 
            // StatesCheckbox
            // 
            this.StatesCheckbox.FormattingEnabled = true;
            this.StatesCheckbox.Location = new System.Drawing.Point(283, 95);
            this.StatesCheckbox.Name = "StatesCheckbox";
            this.StatesCheckbox.Size = new System.Drawing.Size(119, 76);
            this.StatesCheckbox.TabIndex = 14;
            // 
            // SelectAssetTextbox
            // 
            this.SelectAssetTextbox.Location = new System.Drawing.Point(283, 26);
            this.SelectAssetTextbox.Name = "SelectAssetTextbox";
            this.SelectAssetTextbox.Size = new System.Drawing.Size(119, 29);
            this.SelectAssetTextbox.TabIndex = 10;
            this.SelectAssetTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectAssetTextbox_KeyDown);
            // 
            // AddSimpleActionButton
            // 
            this.AddSimpleActionButton.Location = new System.Drawing.Point(150, 189);
            this.AddSimpleActionButton.Name = "AddSimpleActionButton";
            this.AddSimpleActionButton.Size = new System.Drawing.Size(73, 28);
            this.AddSimpleActionButton.TabIndex = 6;
            this.AddSimpleActionButton.Text = "اضافه";
            this.AddSimpleActionButton.UseVisualStyleBackColor = true;
            this.AddSimpleActionButton.Click += new System.EventHandler(this.AddSimpleActionButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 29);
            this.textBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "وضعیت جدید:";
            // 
            // AssignedLabelCombobox
            // 
            this.AssignedLabelCombobox.FormattingEnabled = true;
            this.AssignedLabelCombobox.Location = new System.Drawing.Point(283, 59);
            this.AssignedLabelCombobox.Name = "AssignedLabelCombobox";
            this.AssignedLabelCombobox.Size = new System.Drawing.Size(119, 29);
            this.AssignedLabelCombobox.TabIndex = 3;
            this.AssignedLabelCombobox.SelectedIndexChanged += new System.EventHandler(this.AssignedLabelCombobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "برچسب:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "دارایی:";
            // 
            // ActionNameTextbox
            // 
            this.ActionNameTextbox.Location = new System.Drawing.Point(542, 22);
            this.ActionNameTextbox.Name = "ActionNameTextbox";
            this.ActionNameTextbox.Size = new System.Drawing.Size(137, 29);
            this.ActionNameTextbox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(685, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "نام عملیات:";
            // 
            // AddFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddFunction";
            this.Size = new System.Drawing.Size(766, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionView)).EndInit();
            this.AddSubActionGroupbox.ResumeLayout(false);
            this.AddSubActionGroupbox.PerformLayout();
            this.RemoveActionGroupbox.ResumeLayout(false);
            this.RemoveActionGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveLevelNumericUpDown)).EndInit();
            this.AddSimpleActionGroupbox.ResumeLayout(false);
            this.AddSimpleActionGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox AddSubActionCheckbox;
        private System.Windows.Forms.GroupBox RemoveActionGroupbox;
        private System.Windows.Forms.NumericUpDown RemoveLevelNumericUpDown;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button RemoveLevelButton;
        private System.Windows.Forms.CheckBox AddSimpleActionCheckbox;
        private System.Windows.Forms.GroupBox AddSubActionGroupbox;
        private System.Windows.Forms.TextBox SubActionTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddSubActionButton;
        private System.Windows.Forms.GroupBox AddSimpleActionGroupbox;
        private System.Windows.Forms.TextBox SelectAssetTextbox;
        private System.Windows.Forms.Button AddSimpleActionButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AssignedLabelCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ActionNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox StatesCheckbox;
        private System.Windows.Forms.TreeView AssignedLabelTreeView;
        private System.Windows.Forms.DataGridView ActionView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewState;
        private System.Windows.Forms.TextBox NewStateTextbox;
        private System.Windows.Forms.CheckBox HasInputCheckbox;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
    }
}
