namespace SupermarketManage
{
    partial class JHGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JHGoods));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.lblGoodsID = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.txtDepotName = new System.Windows.Forms.TextBox();
            this.lblDepotName = new System.Windows.Forms.Label();
            this.lblGoodsNum = new System.Windows.Forms.Label();
            this.cmbGoodsUnit = new System.Windows.Forms.ComboBox();
            this.txtGoodsJHPrice = new System.Windows.Forms.TextBox();
            this.lblGoodsJHPrice = new System.Windows.Forms.Label();
            this.txtSellGoodsPrice = new System.Windows.Forms.TextBox();
            this.lblSellGoodsPrice = new System.Windows.Forms.Label();
            this.txtGoodsNeedPrice = new System.Windows.Forms.TextBox();
            this.lblGoodsNeedPrice = new System.Windows.Forms.Label();
            this.txtGoodsHasPay = new System.Windows.Forms.TextBox();
            this.lblGoodsHasPay = new System.Windows.Forms.Label();
            this.lblGoodsTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblGoodsRemark = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.numGoodsNum = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsNum)).BeginInit();
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
            this.toolDelete,
            this.toolStripSeparator2,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 31);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSave
            // 
            this.toolSave.Enabled = false;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(60, 28);
            this.toolSave.Tag = "1";
            this.toolSave.Text = "保存";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // toolCancel
            // 
            this.toolCancel.Enabled = false;
            this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
            this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCancel.Name = "toolCancel";
            this.toolCancel.Size = new System.Drawing.Size(60, 28);
            this.toolCancel.Tag = "2";
            this.toolCancel.Text = "取消";
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(60, 28);
            this.toolAdd.Tag = "3";
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolAmend
            // 
            this.toolAmend.Image = ((System.Drawing.Image)(resources.GetObject("toolAmend.Image")));
            this.toolAmend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAmend.Name = "toolAmend";
            this.toolAmend.Size = new System.Drawing.Size(60, 28);
            this.toolAmend.Tag = "4";
            this.toolAmend.Text = "修改";
            this.toolAmend.Click += new System.EventHandler(this.toolAmend_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(36, 28);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(60, 28);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(95, 38);
            this.txtGoodsID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(128, 21);
            this.txtGoodsID.TabIndex = 53;
            // 
            // lblGoodsID
            // 
            this.lblGoodsID.AutoSize = true;
            this.lblGoodsID.Location = new System.Drawing.Point(38, 40);
            this.lblGoodsID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsID.Name = "lblGoodsID";
            this.lblGoodsID.Size = new System.Drawing.Size(65, 12);
            this.lblGoodsID.TabIndex = 52;
            this.lblGoodsID.Text = "商品编号：";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(287, 38);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(128, 21);
            this.txtGoodsName.TabIndex = 55;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Location = new System.Drawing.Point(231, 40);
            this.lblGoodsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(65, 12);
            this.lblGoodsName.TabIndex = 54;
            this.lblGoodsName.Text = "商品名称：";
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(95, 69);
            this.txtComName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(128, 21);
            this.txtComName.TabIndex = 57;
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Location = new System.Drawing.Point(26, 71);
            this.lblComName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(77, 12);
            this.lblComName.TabIndex = 56;
            this.lblComName.Text = "供应商名称：";
            // 
            // txtDepotName
            // 
            this.txtDepotName.Location = new System.Drawing.Point(287, 69);
            this.txtDepotName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepotName.Name = "txtDepotName";
            this.txtDepotName.Size = new System.Drawing.Size(128, 21);
            this.txtDepotName.TabIndex = 59;
            // 
            // lblDepotName
            // 
            this.lblDepotName.AutoSize = true;
            this.lblDepotName.Location = new System.Drawing.Point(231, 71);
            this.lblDepotName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepotName.Name = "lblDepotName";
            this.lblDepotName.Size = new System.Drawing.Size(65, 12);
            this.lblDepotName.TabIndex = 58;
            this.lblDepotName.Text = "仓库名称：";
            // 
            // lblGoodsNum
            // 
            this.lblGoodsNum.AutoSize = true;
            this.lblGoodsNum.Location = new System.Drawing.Point(38, 103);
            this.lblGoodsNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsNum.Name = "lblGoodsNum";
            this.lblGoodsNum.Size = new System.Drawing.Size(65, 12);
            this.lblGoodsNum.TabIndex = 60;
            this.lblGoodsNum.Text = "商品数量：";
            // 
            // cmbGoodsUnit
            // 
            this.cmbGoodsUnit.FormattingEnabled = true;
            this.cmbGoodsUnit.Items.AddRange(new object[] {
            "个",
            "箱",
            "把",
            "车"});
            this.cmbGoodsUnit.Location = new System.Drawing.Point(181, 101);
            this.cmbGoodsUnit.Name = "cmbGoodsUnit";
            this.cmbGoodsUnit.Size = new System.Drawing.Size(41, 20);
            this.cmbGoodsUnit.TabIndex = 62;
            // 
            // txtGoodsJHPrice
            // 
            this.txtGoodsJHPrice.Location = new System.Drawing.Point(287, 101);
            this.txtGoodsJHPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGoodsJHPrice.Name = "txtGoodsJHPrice";
            this.txtGoodsJHPrice.Size = new System.Drawing.Size(128, 21);
            this.txtGoodsJHPrice.TabIndex = 64;
            this.txtGoodsJHPrice.Text = "0";
            // 
            // lblGoodsJHPrice
            // 
            this.lblGoodsJHPrice.AutoSize = true;
            this.lblGoodsJHPrice.Location = new System.Drawing.Point(231, 103);
            this.lblGoodsJHPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsJHPrice.Name = "lblGoodsJHPrice";
            this.lblGoodsJHPrice.Size = new System.Drawing.Size(65, 12);
            this.lblGoodsJHPrice.TabIndex = 63;
            this.lblGoodsJHPrice.Text = "进货单价：";
            // 
            // txtSellGoodsPrice
            // 
            this.txtSellGoodsPrice.Location = new System.Drawing.Point(95, 133);
            this.txtSellGoodsPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSellGoodsPrice.Name = "txtSellGoodsPrice";
            this.txtSellGoodsPrice.Size = new System.Drawing.Size(128, 21);
            this.txtSellGoodsPrice.TabIndex = 66;
            // 
            // lblSellGoodsPrice
            // 
            this.lblSellGoodsPrice.AutoSize = true;
            this.lblSellGoodsPrice.Location = new System.Drawing.Point(38, 135);
            this.lblSellGoodsPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSellGoodsPrice.Name = "lblSellGoodsPrice";
            this.lblSellGoodsPrice.Size = new System.Drawing.Size(65, 12);
            this.lblSellGoodsPrice.TabIndex = 65;
            this.lblSellGoodsPrice.Text = "销售单价：";
            // 
            // txtGoodsNeedPrice
            // 
            this.txtGoodsNeedPrice.Location = new System.Drawing.Point(287, 133);
            this.txtGoodsNeedPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGoodsNeedPrice.Name = "txtGoodsNeedPrice";
            this.txtGoodsNeedPrice.Size = new System.Drawing.Size(128, 21);
            this.txtGoodsNeedPrice.TabIndex = 68;
            this.txtGoodsNeedPrice.Text = "0";
            // 
            // lblGoodsNeedPrice
            // 
            this.lblGoodsNeedPrice.AutoSize = true;
            this.lblGoodsNeedPrice.Location = new System.Drawing.Point(231, 135);
            this.lblGoodsNeedPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsNeedPrice.Name = "lblGoodsNeedPrice";
            this.lblGoodsNeedPrice.Size = new System.Drawing.Size(65, 12);
            this.lblGoodsNeedPrice.TabIndex = 67;
            this.lblGoodsNeedPrice.Text = "应付金额：";
            // 
            // txtGoodsHasPay
            // 
            this.txtGoodsHasPay.Location = new System.Drawing.Point(95, 164);
            this.txtGoodsHasPay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGoodsHasPay.Name = "txtGoodsHasPay";
            this.txtGoodsHasPay.Size = new System.Drawing.Size(128, 21);
            this.txtGoodsHasPay.TabIndex = 70;
            this.txtGoodsHasPay.Text = "0";
            // 
            // lblGoodsHasPay
            // 
            this.lblGoodsHasPay.AutoSize = true;
            this.lblGoodsHasPay.Location = new System.Drawing.Point(38, 166);
            this.lblGoodsHasPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsHasPay.Name = "lblGoodsHasPay";
            this.lblGoodsHasPay.Size = new System.Drawing.Size(65, 12);
            this.lblGoodsHasPay.TabIndex = 69;
            this.lblGoodsHasPay.Text = "实付金额：";
            // 
            // lblGoodsTime
            // 
            this.lblGoodsTime.AutoSize = true;
            this.lblGoodsTime.Location = new System.Drawing.Point(231, 166);
            this.lblGoodsTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsTime.Name = "lblGoodsTime";
            this.lblGoodsTime.Size = new System.Drawing.Size(65, 12);
            this.lblGoodsTime.TabIndex = 71;
            this.lblGoodsTime.Text = "进货时间：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 161);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 21);
            this.dateTimePicker1.TabIndex = 72;
            // 
            // lblGoodsRemark
            // 
            this.lblGoodsRemark.AutoSize = true;
            this.lblGoodsRemark.Location = new System.Drawing.Point(442, 71);
            this.lblGoodsRemark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGoodsRemark.Name = "lblGoodsRemark";
            this.lblGoodsRemark.Size = new System.Drawing.Size(41, 12);
            this.lblGoodsRemark.TabIndex = 73;
            this.lblGoodsRemark.Text = "备注：";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(487, 69);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(131, 110);
            this.txtRemarks.TabIndex = 74;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(589, 150);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(487, 38);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(128, 21);
            this.txtEmployeeID.TabIndex = 77;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(431, 40);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(65, 12);
            this.lblEmployeeID.TabIndex = 76;
            this.lblEmployeeID.Text = "进货员工：";
            // 
            // numGoodsNum
            // 
            this.numGoodsNum.Location = new System.Drawing.Point(95, 100);
            this.numGoodsNum.Name = "numGoodsNum";
            this.numGoodsNum.Size = new System.Drawing.Size(83, 21);
            this.numGoodsNum.TabIndex = 78;
            // 
            // JHGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 379);
            this.Controls.Add(this.numGoodsNum);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblGoodsRemark);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblGoodsTime);
            this.Controls.Add(this.txtGoodsHasPay);
            this.Controls.Add(this.lblGoodsHasPay);
            this.Controls.Add(this.txtGoodsNeedPrice);
            this.Controls.Add(this.lblGoodsNeedPrice);
            this.Controls.Add(this.txtSellGoodsPrice);
            this.Controls.Add(this.lblSellGoodsPrice);
            this.Controls.Add(this.txtGoodsJHPrice);
            this.Controls.Add(this.lblGoodsJHPrice);
            this.Controls.Add(this.cmbGoodsUnit);
            this.Controls.Add(this.lblGoodsNum);
            this.Controls.Add(this.txtDepotName);
            this.Controls.Add(this.lblDepotName);
            this.Controls.Add(this.txtComName);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.lblGoodsName);
            this.Controls.Add(this.txtGoodsID);
            this.Controls.Add(this.lblGoodsID);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JHGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品进货信息";
            this.Load += new System.EventHandler(this.JHGoods_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.Label lblGoodsID;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label lblComName;
        private System.Windows.Forms.TextBox txtDepotName;
        private System.Windows.Forms.Label lblDepotName;
        private System.Windows.Forms.Label lblGoodsNum;
        private System.Windows.Forms.ComboBox cmbGoodsUnit;
        private System.Windows.Forms.TextBox txtGoodsJHPrice;
        private System.Windows.Forms.Label lblGoodsJHPrice;
        private System.Windows.Forms.TextBox txtSellGoodsPrice;
        private System.Windows.Forms.Label lblSellGoodsPrice;
        private System.Windows.Forms.TextBox txtGoodsNeedPrice;
        private System.Windows.Forms.Label lblGoodsNeedPrice;
        private System.Windows.Forms.TextBox txtGoodsHasPay;
        private System.Windows.Forms.Label lblGoodsHasPay;
        private System.Windows.Forms.Label lblGoodsTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblGoodsRemark;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.NumericUpDown numGoodsNum;
    }
}