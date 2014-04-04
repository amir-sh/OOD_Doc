namespace WindowsFormsApplication1.forms.function
{
    partial class ApplyFunction
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
            this.StatesCheckbox = new System.Windows.Forms.CheckedListBox();
            this.ActionDataGridView = new System.Windows.Forms.DataGridView();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.StatesTextbox = new System.Windows.Forms.TextBox();
            this.SelectAssetTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatesCheckbox);
            this.groupBox1.Controls.Add(this.ActionDataGridView);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StatesTextbox);
            this.groupBox1.Controls.Add(this.SelectAssetTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(758, 505);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعمال عملیات";
            // 
            // StatesCheckbox
            // 
            this.StatesCheckbox.FormattingEnabled = true;
            this.StatesCheckbox.Location = new System.Drawing.Point(547, 106);
            this.StatesCheckbox.Name = "StatesCheckbox";
            this.StatesCheckbox.Size = new System.Drawing.Size(100, 76);
            this.StatesCheckbox.TabIndex = 11;
            this.StatesCheckbox.Visible = false;
            this.StatesCheckbox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.StatesCheckbox_ItemCheck);
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
            this.ActionDataGridView.Location = new System.Drawing.Point(16, 60);
            this.ActionDataGridView.Name = "ActionDataGridView";
            this.ActionDataGridView.Size = new System.Drawing.Size(510, 150);
            this.ActionDataGridView.TabIndex = 9;
            this.ActionDataGridView.SelectionChanged += new System.EventHandler(this.ActionDataGridView_SelectionChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "ورودی:";
            // 
            // StatesTextbox
            // 
            this.StatesTextbox.Location = new System.Drawing.Point(547, 106);
            this.StatesTextbox.Name = "StatesTextbox";
            this.StatesTextbox.Size = new System.Drawing.Size(100, 29);
            this.StatesTextbox.TabIndex = 7;
            this.StatesTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatesTextbox_KeyDown);
            // 
            // SelectAssetTextbox
            // 
            this.SelectAssetTextbox.Location = new System.Drawing.Point(547, 60);
            this.SelectAssetTextbox.Name = "SelectAssetTextbox";
            this.SelectAssetTextbox.Size = new System.Drawing.Size(100, 29);
            this.SelectAssetTextbox.TabIndex = 6;
            this.SelectAssetTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectAssetTextbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(688, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "عملیات:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "اعمال عملیات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplyFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApplyFunction";
            this.Size = new System.Drawing.Size(766, 510);
            this.Load += new System.EventHandler(this.SelectAssetText_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StatesTextbox;
        private System.Windows.Forms.TextBox SelectAssetTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ActionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Input;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionID;
        private System.Windows.Forms.CheckedListBox StatesCheckbox;
    }
}
