﻿namespace SupermarketManage
{
    partial class SellGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellGoods));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.DaSellGoodsTime = new System.Windows.Forms.DateTimePicker();
            this.txtdeSellPrice = new System.Windows.Forms.TextBox();
            this.txtSellRemark = new System.Windows.Forms.TextBox();
            this.txtSellNeedPay = new System.Windows.Forms.TextBox();
            this.txtdeSellHasPay = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtSellID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDepotName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.numSellGoodsNum = new System.Windows.Forms.NumericUpDown();
            this.cboEmpID = new System.Windows.Forms.ComboBox();
            this.lblComName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellGoodsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolCancel,
            this.toolAdd,
            this.toolStripSeparator2,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1031, 31);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
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
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
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
            this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolAdd.Image")));
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(74, 28);
            this.toolAdd.Tag = "3";
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
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
            this.toolExit.Size = new System.Drawing.Size(74, 28);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // DaSellGoodsTime
            // 
            this.DaSellGoodsTime.Location = new System.Drawing.Point(768, 148);
            this.DaSellGoodsTime.Margin = new System.Windows.Forms.Padding(4);
            this.DaSellGoodsTime.Name = "DaSellGoodsTime";
            this.DaSellGoodsTime.Size = new System.Drawing.Size(214, 28);
            this.DaSellGoodsTime.TabIndex = 86;
            // 
            // txtdeSellPrice
            // 
            this.txtdeSellPrice.Location = new System.Drawing.Point(128, 145);
            this.txtdeSellPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeSellPrice.Name = "txtdeSellPrice";
            this.txtdeSellPrice.Size = new System.Drawing.Size(178, 28);
            this.txtdeSellPrice.TabIndex = 85;
            // 
            // txtSellRemark
            // 
            this.txtSellRemark.Location = new System.Drawing.Point(766, 194);
            this.txtSellRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellRemark.Name = "txtSellRemark";
            this.txtSellRemark.Size = new System.Drawing.Size(214, 28);
            this.txtSellRemark.TabIndex = 83;
            // 
            // txtSellNeedPay
            // 
            this.txtSellNeedPay.Enabled = false;
            this.txtSellNeedPay.Location = new System.Drawing.Point(128, 194);
            this.txtSellNeedPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellNeedPay.Name = "txtSellNeedPay";
            this.txtSellNeedPay.ReadOnly = true;
            this.txtSellNeedPay.Size = new System.Drawing.Size(178, 28);
            this.txtSellNeedPay.TabIndex = 82;
            this.txtSellNeedPay.Text = "0";
            // 
            // txtdeSellHasPay
            // 
            this.txtdeSellHasPay.Location = new System.Drawing.Point(449, 194);
            this.txtdeSellHasPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtdeSellHasPay.Name = "txtdeSellHasPay";
            this.txtdeSellHasPay.Size = new System.Drawing.Size(178, 28);
            this.txtdeSellHasPay.TabIndex = 81;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(128, 98);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.ReadOnly = true;
            this.txtGoodsName.Size = new System.Drawing.Size(178, 28);
            this.txtGoodsName.TabIndex = 79;
            // 
            // txtSellID
            // 
            this.txtSellID.Location = new System.Drawing.Point(128, 49);
            this.txtSellID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSellID.Name = "txtSellID";
            this.txtSellID.Size = new System.Drawing.Size(178, 28);
            this.txtSellID.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(713, 201);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 77;
            this.label9.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 76;
            this.label8.Text = "实付金额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 75;
            this.label7.Text = "应付金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 74;
            this.label6.Text = "员工编号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 73;
            this.label5.Text = "销售单价：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "销售时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = "销售数量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "商品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "销售编号：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 252);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(942, 225);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(678, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 70;
            this.label10.Text = "仓库名称：";
            // 
            // txtDepotName
            // 
            this.txtDepotName.Location = new System.Drawing.Point(767, 49);
            this.txtDepotName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepotName.Name = "txtDepotName";
            this.txtDepotName.ReadOnly = true;
            this.txtDepotName.Size = new System.Drawing.Size(214, 28);
            this.txtDepotName.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 70;
            this.label11.Text = "商品编号：";
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(449, 102);
            this.txtGoodsID.Margin = new System.Windows.Forms.Padding(4);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.ReadOnly = true;
            this.txtGoodsID.Size = new System.Drawing.Size(178, 28);
            this.txtGoodsID.TabIndex = 79;
            // 
            // numSellGoodsNum
            // 
            this.numSellGoodsNum.Location = new System.Drawing.Point(449, 146);
            this.numSellGoodsNum.Margin = new System.Windows.Forms.Padding(4);
            this.numSellGoodsNum.Name = "numSellGoodsNum";
            this.numSellGoodsNum.Size = new System.Drawing.Size(178, 28);
            this.numSellGoodsNum.TabIndex = 87;
            this.numSellGoodsNum.ValueChanged += new System.EventHandler(this.numSellGoodsNum_ValueChanged);
            // 
            // cboEmpID
            // 
            this.cboEmpID.FormattingEnabled = true;
            this.cboEmpID.Location = new System.Drawing.Point(449, 51);
            this.cboEmpID.Name = "cboEmpID";
            this.cboEmpID.Size = new System.Drawing.Size(178, 26);
            this.cboEmpID.TabIndex = 88;
            // 
            // lblComName
            // 
            this.lblComName.AutoSize = true;
            this.lblComName.Location = new System.Drawing.Point(661, 104);
            this.lblComName.Name = "lblComName";
            this.lblComName.Size = new System.Drawing.Size(116, 18);
            this.lblComName.TabIndex = 89;
            this.lblComName.Text = "供应商名称：";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(768, 98);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(214, 28);
            this.txtCompanyName.TabIndex = 90;
            // 
            // SellGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 503);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblComName);
            this.Controls.Add(this.cboEmpID);
            this.Controls.Add(this.numSellGoodsNum);
            this.Controls.Add(this.DaSellGoodsTime);
            this.Controls.Add(this.txtdeSellPrice);
            this.Controls.Add(this.txtSellRemark);
            this.Controls.Add(this.txtSellNeedPay);
            this.Controls.Add(this.txtdeSellHasPay);
            this.Controls.Add(this.txtDepotName);
            this.Controls.Add(this.txtGoodsID);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtSellID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品销售";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSellGoodsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.DateTimePicker DaSellGoodsTime;
        private System.Windows.Forms.TextBox txtdeSellPrice;
        private System.Windows.Forms.TextBox txtSellRemark;
        private System.Windows.Forms.TextBox txtSellNeedPay;
        private System.Windows.Forms.TextBox txtdeSellHasPay;
        public System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.TextBox txtSellID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtDepotName;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.NumericUpDown numSellGoodsNum;
        private System.Windows.Forms.ComboBox cboEmpID;
        private System.Windows.Forms.Label lblComName;
        public System.Windows.Forms.TextBox txtCompanyName;
    }
}