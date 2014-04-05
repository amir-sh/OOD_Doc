namespace WindowsFormsApplication1.forms.barchasb
{
    partial class BarchasbViewe
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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectLabelTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AssetListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelTreeView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelDataGridView = new System.Windows.Forms.DataGridView();
            this.LabelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelConstraint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "انتخاب برچسب";
            // 
            // SelectLabelTextbox
            // 
            this.SelectLabelTextbox.Location = new System.Drawing.Point(464, 35);
            this.SelectLabelTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectLabelTextbox.Name = "SelectLabelTextbox";
            this.SelectLabelTextbox.Size = new System.Drawing.Size(93, 29);
            this.SelectLabelTextbox.TabIndex = 1;
            this.SelectLabelTextbox.Text = "چراغ";
            this.SelectLabelTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SelectLabelTextbox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SelectLabelTextbox);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(758, 505);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشاهده برچسب";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AssetListView);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LabelTreeView);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LabelDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(26, 67);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(705, 433);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مشخصات برچسب";
            // 
            // AssetListView
            // 
            this.AssetListView.Location = new System.Drawing.Point(66, 210);
            this.AssetListView.Name = "AssetListView";
            this.AssetListView.Size = new System.Drawing.Size(160, 198);
            this.AssetListView.TabIndex = 38;
            this.AssetListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "دارایی‌های شامل:";
            // 
            // LabelTreeView
            // 
            this.LabelTreeView.Location = new System.Drawing.Point(389, 210);
            this.LabelTreeView.Name = "LabelTreeView";
            this.LabelTreeView.Size = new System.Drawing.Size(188, 198);
            this.LabelTreeView.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "ساختار برچسب:";
            // 
            // LabelDataGridView
            // 
            this.LabelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LabelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LabelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabelName,
            this.LabelState,
            this.LabelConstraint,
            this.DefaultValue});
            this.LabelDataGridView.Location = new System.Drawing.Point(66, 38);
            this.LabelDataGridView.Name = "LabelDataGridView";
            this.LabelDataGridView.Size = new System.Drawing.Size(564, 150);
            this.LabelDataGridView.TabIndex = 34;
            // 
            // LabelName
            // 
            this.LabelName.HeaderText = "نام برچسب";
            this.LabelName.Name = "LabelName";
            // 
            // LabelState
            // 
            this.LabelState.HeaderText = "نوع برچسب";
            this.LabelState.Name = "LabelState";
            // 
            // LabelConstraint
            // 
            this.LabelConstraint.HeaderText = "محدودیت";
            this.LabelConstraint.Name = "LabelConstraint";
            // 
            // DefaultValue
            // 
            this.DefaultValue.HeaderText = "مقدار پیش فرض";
            this.DefaultValue.Name = "DefaultValue";
            // 
            // BarchasbViewe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BarchasbViewe";
            this.Size = new System.Drawing.Size(766, 510);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabelDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectLabelTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView AssetListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView LabelTreeView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView LabelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelState;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelConstraint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
    }
}
