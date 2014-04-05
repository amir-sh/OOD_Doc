namespace WindowsFormsApplication1.forms.function
{
    partial class RemoveFunction
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
            this.ActionDataGridView = new System.Windows.Forms.DataGridView();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveActionTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActionDataGridView);
            this.groupBox1.Controls.Add(this.RemoveActionTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(758, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حذف عملیات";
            // 
            // ActionDataGridView
            // 
            this.ActionDataGridView.AllowUserToAddRows = false;
            this.ActionDataGridView.AllowUserToDeleteRows = false;
            this.ActionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Level,
            this.SubAction,
            this.AssetName,
            this.LabelName,
            this.NewState,
            this.Input,
            this.ActionID});
            this.ActionDataGridView.Location = new System.Drawing.Point(25, 29);
            this.ActionDataGridView.Name = "ActionDataGridView";
            this.ActionDataGridView.Size = new System.Drawing.Size(510, 275);
            this.ActionDataGridView.TabIndex = 12;
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
            // NewState
            // 
            this.NewState.HeaderText = "مقدار جدید";
            this.NewState.Name = "NewState";
            // 
            // Input
            // 
            this.Input.HeaderText = "ورودی";
            this.Input.Name = "Input";
            // 
            // ActionID
            // 
            this.ActionID.HeaderText = "Column1";
            this.ActionID.Name = "ActionID";
            this.ActionID.Visible = false;
            // 
            // RemoveActionTextbox
            // 
            this.RemoveActionTextbox.Location = new System.Drawing.Point(552, 29);
            this.RemoveActionTextbox.Name = "RemoveActionTextbox";
            this.RemoveActionTextbox.Size = new System.Drawing.Size(106, 29);
            this.RemoveActionTextbox.TabIndex = 11;
            this.RemoveActionTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveActionTextbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(698, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "عملیات:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(552, 84);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(106, 26);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "حذف عملیات";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoveFunction";
            this.Size = new System.Drawing.Size(766, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RemoveActionTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.DataGridView ActionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionID;
    }
}
