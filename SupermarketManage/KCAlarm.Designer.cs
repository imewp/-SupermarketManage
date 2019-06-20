namespace SupermarketManage
{
    partial class KCAlarmNum
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAlarmNum = new System.Windows.Forms.TextBox();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblGoodsID = new System.Windows.Forms.Label();
            this.txtDepotName = new System.Windows.Forms.TextBox();
            this.txtGoodsNum = new System.Windows.Forms.TextBox();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblDepotName = new System.Windows.Forms.Label();
            this.lblJHNum = new System.Windows.Forms.Label();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(456, 192);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 34);
            this.btnExit.TabIndex = 92;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAlarmNum
            // 
            this.txtAlarmNum.Location = new System.Drawing.Point(510, 140);
            this.txtAlarmNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlarmNum.MaxLength = 10;
            this.txtAlarmNum.Name = "txtAlarmNum";
            this.txtAlarmNum.Size = new System.Drawing.Size(229, 28);
            this.txtAlarmNum.TabIndex = 91;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(418, 144);
            this.lblAlarm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(98, 18);
            this.lblAlarm.TabIndex = 90;
            this.lblAlarm.Text = "警报数量：";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(144, 18);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtid.MaxLength = 20;
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(232, 28);
            this.txtid.TabIndex = 89;
            // 
            // lblGoodsID
            // 
            this.lblGoodsID.AutoSize = true;
            this.lblGoodsID.Location = new System.Drawing.Point(56, 22);
            this.lblGoodsID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoodsID.Name = "lblGoodsID";
            this.lblGoodsID.Size = new System.Drawing.Size(98, 18);
            this.lblGoodsID.TabIndex = 88;
            this.lblGoodsID.Text = "商品编号：";
            // 
            // txtDepotName
            // 
            this.txtDepotName.Enabled = false;
            this.txtDepotName.Location = new System.Drawing.Point(510, 80);
            this.txtDepotName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDepotName.MaxLength = 10;
            this.txtDepotName.Name = "txtDepotName";
            this.txtDepotName.ReadOnly = true;
            this.txtDepotName.Size = new System.Drawing.Size(229, 28);
            this.txtDepotName.TabIndex = 87;
            // 
            // txtGoodsNum
            // 
            this.txtGoodsNum.Enabled = false;
            this.txtGoodsNum.Location = new System.Drawing.Point(144, 140);
            this.txtGoodsNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoodsNum.MaxLength = 10;
            this.txtGoodsNum.Name = "txtGoodsNum";
            this.txtGoodsNum.ReadOnly = true;
            this.txtGoodsNum.Size = new System.Drawing.Size(232, 28);
            this.txtGoodsNum.TabIndex = 86;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Enabled = false;
            this.txtGoodsName.Location = new System.Drawing.Point(510, 18);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGoodsName.MaxLength = 20;
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.ReadOnly = true;
            this.txtGoodsName.Size = new System.Drawing.Size(229, 28);
            this.txtGoodsName.TabIndex = 85;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.Location = new System.Drawing.Point(144, 80);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCompanyName.MaxLength = 10;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(232, 28);
            this.txtCompanyName.TabIndex = 84;
            // 
            // lblDepotName
            // 
            this.lblDepotName.AutoSize = true;
            this.lblDepotName.Location = new System.Drawing.Point(418, 84);
            this.lblDepotName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepotName.Name = "lblDepotName";
            this.lblDepotName.Size = new System.Drawing.Size(98, 18);
            this.lblDepotName.TabIndex = 83;
            this.lblDepotName.Text = "仓库名称：";
            // 
            // lblJHNum
            // 
            this.lblJHNum.AutoSize = true;
            this.lblJHNum.Location = new System.Drawing.Point(56, 144);
            this.lblJHNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJHNum.Name = "lblJHNum";
            this.lblJHNum.Size = new System.Drawing.Size(98, 18);
            this.lblJHNum.TabIndex = 82;
            this.lblJHNum.Text = "库存数量：";
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Location = new System.Drawing.Point(418, 24);
            this.lblGoodsName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(98, 18);
            this.lblGoodsName.TabIndex = 81;
            this.lblGoodsName.Text = "商品名称：";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(38, 84);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(116, 18);
            this.lblCompanyName.TabIndex = 80;
            this.lblCompanyName.Text = "供应商名称：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(764, 225);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(203, 192);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 34);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "设置";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // KCAlarmNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 498);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAlarmNum);
            this.Controls.Add(this.lblAlarm);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblGoodsID);
            this.Controls.Add(this.txtDepotName);
            this.Controls.Add(this.txtGoodsNum);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblDepotName);
            this.Controls.Add(this.lblJHNum);
            this.Controls.Add(this.lblGoodsName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KCAlarmNum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存报警";
            this.Load += new System.EventHandler(this.KCAlarmNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAlarmNum;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblGoodsID;
        private System.Windows.Forms.TextBox txtDepotName;
        private System.Windows.Forms.TextBox txtGoodsNum;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblDepotName;
        private System.Windows.Forms.Label lblJHNum;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
    }
}