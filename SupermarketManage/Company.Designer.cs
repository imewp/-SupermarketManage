namespace SupermarketManage
{
    partial class Company
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Company));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.labCondation = new System.Windows.Forms.ToolStripLabel();
            this.cbxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.txtKeyWord = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolrefesh = new System.Windows.Forms.ToolStripButton();
            this.txtOK = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyDirector = new System.Windows.Forms.TextBox();
            this.lblCompanyDirector = new System.Windows.Forms.Label();
            this.txtCompanyPhone = new System.Windows.Forms.TextBox();
            this.lblCompanyPhone = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.lblReDateTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyRemarks = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolAmend,
            this.toolrefesh,
            this.toolStripSeparator1,
            this.labCondation,
            this.cbxCondition,
            this.txtKeyWord,
            this.toolStripSeparator2,
            this.txtOK,
            this.toolExit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1058, 32);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // labCondation
            // 
            this.labCondation.Name = "labCondation";
            this.labCondation.Size = new System.Drawing.Size(86, 24);
            this.labCondation.Text = "查询条件:";
            // 
            // cbxCondition
            // 
            this.cbxCondition.Items.AddRange(new object[] {
            "供应商名称",
            "负责人姓名"});
            this.cbxCondition.Name = "cbxCondition";
            this.cbxCondition.Size = new System.Drawing.Size(110, 32);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(148, 30);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(74, 28);
            this.toolSave.Tag = "1";
            this.toolSave.Text = "保存";
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(74, 28);
            this.toolCancel.Tag = "2";
            this.toolCancel.Text = "取消";
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(74, 28);
            this.toolAdd.Tag = "3";
            this.toolAdd.Text = "添加";
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(74, 28);
            this.toolAmend.Tag = "4";
            this.toolAmend.Text = "修改";
            // 
            // toolrefesh
            // 
            this.toolrefesh.Image = ((System.Drawing.Image)(resources.GetObject("toolrefesh.Image")));
            this.toolrefesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolrefesh.Name = "toolrefesh";
            this.toolrefesh.Size = new System.Drawing.Size(74, 28);
            this.toolrefesh.Text = "删除";
            // 
            // txtOK
            // 
            this.txtOK.Image = ((System.Drawing.Image)(resources.GetObject("txtOK.Image")));
            this.txtOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtOK.Name = "txtOK";
            this.txtOK.Size = new System.Drawing.Size(74, 28);
            this.txtOK.Tag = "6";
            this.txtOK.Text = "查找";
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(74, 28);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Location = new System.Drawing.Point(61, 53);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(116, 18);
            this.lblCompanyID.TabIndex = 9;
            this.lblCompanyID.Text = "供应商编号：";
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(164, 50);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(190, 28);
            this.txtCompanyID.TabIndex = 10;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(485, 50);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(201, 28);
            this.txtCompanyName.TabIndex = 12;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(382, 53);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(116, 18);
            this.lblCompanyName.TabIndex = 11;
            this.lblCompanyName.Text = "供应商姓名：";
            // 
            // txtCompanyDirector
            // 
            this.txtCompanyDirector.Location = new System.Drawing.Point(800, 50);
            this.txtCompanyDirector.Name = "txtCompanyDirector";
            this.txtCompanyDirector.Size = new System.Drawing.Size(194, 28);
            this.txtCompanyDirector.TabIndex = 14;
            // 
            // lblCompanyDirector
            // 
            this.lblCompanyDirector.AutoSize = true;
            this.lblCompanyDirector.Location = new System.Drawing.Point(714, 53);
            this.lblCompanyDirector.Name = "lblCompanyDirector";
            this.lblCompanyDirector.Size = new System.Drawing.Size(98, 18);
            this.lblCompanyDirector.TabIndex = 13;
            this.lblCompanyDirector.Text = "负 责 人：";
            // 
            // txtCompanyPhone
            // 
            this.txtCompanyPhone.Location = new System.Drawing.Point(164, 103);
            this.txtCompanyPhone.Name = "txtCompanyPhone";
            this.txtCompanyPhone.Size = new System.Drawing.Size(190, 28);
            this.txtCompanyPhone.TabIndex = 16;
            // 
            // lblCompanyPhone
            // 
            this.lblCompanyPhone.AutoSize = true;
            this.lblCompanyPhone.Location = new System.Drawing.Point(61, 106);
            this.lblCompanyPhone.Name = "lblCompanyPhone";
            this.lblCompanyPhone.Size = new System.Drawing.Size(116, 18);
            this.lblCompanyPhone.TabIndex = 15;
            this.lblCompanyPhone.Text = " 联系电话 ：";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(485, 103);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(201, 28);
            this.txtCompanyAddress.TabIndex = 18;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(382, 106);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(116, 18);
            this.lblCompanyAddress.TabIndex = 17;
            this.lblCompanyAddress.Text = "供应商地址：";
            // 
            // lblReDateTime
            // 
            this.lblReDateTime.AutoSize = true;
            this.lblReDateTime.Location = new System.Drawing.Point(714, 106);
            this.lblReDateTime.Name = "lblReDateTime";
            this.lblReDateTime.Size = new System.Drawing.Size(98, 18);
            this.lblReDateTime.TabIndex = 19;
            this.lblReDateTime.Text = "供应时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(800, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 28);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = " 备    注 ：";
            // 
            // txtCompanyRemarks
            // 
            this.txtCompanyRemarks.Location = new System.Drawing.Point(164, 158);
            this.txtCompanyRemarks.Multiline = true;
            this.txtCompanyRemarks.Name = "txtCompanyRemarks";
            this.txtCompanyRemarks.Size = new System.Drawing.Size(830, 108);
            this.txtCompanyRemarks.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(64, 295);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(930, 179);
            this.dataGridView1.TabIndex = 23;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCompanyRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblReDateTime);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.lblCompanyAddress);
            this.Controls.Add(this.txtCompanyPhone);
            this.Controls.Add(this.lblCompanyPhone);
            this.Controls.Add(this.txtCompanyDirector);
            this.Controls.Add(this.lblCompanyDirector);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtCompanyID);
            this.Controls.Add(this.lblCompanyID);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供应商信息";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolrefesh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel labCondation;
        private System.Windows.Forms.ToolStripComboBox cbxCondition;
        private System.Windows.Forms.ToolStripTextBox txtKeyWord;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton txtOK;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyDirector;
        private System.Windows.Forms.Label lblCompanyDirector;
        private System.Windows.Forms.TextBox txtCompanyPhone;
        private System.Windows.Forms.Label lblCompanyPhone;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Label lblReDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyRemarks;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}