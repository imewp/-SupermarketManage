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
            this.tollDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.toolCancel = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolAmend = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.txtGoodsID = new System.Windows.Forms.TextBox();
            this.lblGoodsID = new System.Windows.Forms.Label();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
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
            this.tollDelete,
            this.toolStripSeparator2,
            this.toolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(896, 31);
            this.toolStrip1.TabIndex = 51;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tollDelete
            // 
            this.tollDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tollDelete.Name = "tollDelete";
            this.tollDelete.Size = new System.Drawing.Size(50, 28);
            this.tollDelete.Text = "删除";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
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
            // toolExit
            // 
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(74, 28);
            this.toolExit.Tag = "7";
            this.toolExit.Text = "退出";
            // 
            // txtGoodsID
            // 
            this.txtGoodsID.Location = new System.Drawing.Point(103, 57);
            this.txtGoodsID.Name = "txtGoodsID";
            this.txtGoodsID.Size = new System.Drawing.Size(190, 28);
            this.txtGoodsID.TabIndex = 53;
            // 
            // lblGoodsID
            // 
            this.lblGoodsID.AutoSize = true;
            this.lblGoodsID.Location = new System.Drawing.Point(18, 60);
            this.lblGoodsID.Name = "lblGoodsID";
            this.lblGoodsID.Size = new System.Drawing.Size(98, 18);
            this.lblGoodsID.TabIndex = 52;
            this.lblGoodsID.Text = "商品编号：";
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Location = new System.Drawing.Point(412, 60);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(190, 28);
            this.txtGoodsName.TabIndex = 55;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Location = new System.Drawing.Point(327, 63);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(98, 18);
            this.lblGoodsName.TabIndex = 54;
            this.lblGoodsName.Text = "商品名称：";
            // 
            // JHGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 598);
            this.Controls.Add(this.txtGoodsName);
            this.Controls.Add(this.lblGoodsName);
            this.Controls.Add(this.txtGoodsID);
            this.Controls.Add(this.lblGoodsID);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JHGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品进货信息";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.ToolStripButton toolCancel;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolAmend;
        private System.Windows.Forms.ToolStripButton tollDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.TextBox txtGoodsID;
        private System.Windows.Forms.Label lblGoodsID;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label lblGoodsName;
    }
}