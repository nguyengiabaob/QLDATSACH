namespace BTH4
{
    partial class formdoimatkhau
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formdoimatkhau));
            this.btthoat = new DevExpress.XtraEditors.SimpleButton();
            this.btcapnhat = new DevExpress.XtraEditors.SimpleButton();
            this.tbxnhaplaimatkhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbnhapmoimatkhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbxnhaplaimatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnhapmoimatkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btthoat
            // 
            this.btthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.ImageOptions.Image")));
            this.btthoat.Location = new System.Drawing.Point(306, 233);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(119, 47);
            this.btthoat.TabIndex = 13;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btcapnhat
            // 
            this.btcapnhat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btcapnhat.ImageOptions.Image")));
            this.btcapnhat.Location = new System.Drawing.Point(158, 233);
            this.btcapnhat.Name = "btcapnhat";
            this.btcapnhat.Size = new System.Drawing.Size(119, 47);
            this.btcapnhat.TabIndex = 12;
            this.btcapnhat.Text = "Cập nhật";
            this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
            // 
            // tbxnhaplaimatkhau
            // 
            this.tbxnhaplaimatkhau.Location = new System.Drawing.Point(315, 167);
            this.tbxnhaplaimatkhau.Name = "tbxnhaplaimatkhau";
            this.tbxnhaplaimatkhau.Properties.DisplayFormat.FormatString = "*";
            this.tbxnhaplaimatkhau.Properties.UseSystemPasswordChar = true;
            this.tbxnhaplaimatkhau.Size = new System.Drawing.Size(231, 22);
            this.tbxnhaplaimatkhau.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(81, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(167, 23);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Nhập lại mật khẫu :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(229, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(168, 34);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Đổi Mật Khẩu";
            // 
            // tbnhapmoimatkhau
            // 
            this.tbnhapmoimatkhau.Location = new System.Drawing.Point(315, 107);
            this.tbnhapmoimatkhau.Name = "tbnhapmoimatkhau";
            this.tbnhapmoimatkhau.Properties.UseSystemPasswordChar = true;
            this.tbnhapmoimatkhau.Size = new System.Drawing.Size(231, 22);
            this.tbnhapmoimatkhau.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(69, 106);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(179, 23);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Nhập mật khẩu mới :";
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // formdoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 328);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btcapnhat);
            this.Controls.Add(this.tbxnhaplaimatkhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tbnhapmoimatkhau);
            this.Controls.Add(this.labelControl1);
            this.Name = "formdoimatkhau";
            this.Text = "formdoimatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.tbxnhaplaimatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnhapmoimatkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btthoat;
        private DevExpress.XtraEditors.SimpleButton btcapnhat;
        private DevExpress.XtraEditors.TextEdit tbxnhaplaimatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbnhapmoimatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}