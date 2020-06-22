namespace BTH4
{
    partial class fromdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromdangnhap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbdangnhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbnhapmatkhau = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btdangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.btthoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbdangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnhapmatkhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 99);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên đăng nhập :";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // tbdangnhap
            // 
            this.tbdangnhap.Location = new System.Drawing.Point(256, 101);
            this.tbdangnhap.Name = "tbdangnhap";
            this.tbdangnhap.Size = new System.Drawing.Size(231, 22);
            this.tbdangnhap.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(180, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(140, 34);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Đăng Nhập";
            // 
            // tbnhapmatkhau
            // 
            this.tbnhapmatkhau.Location = new System.Drawing.Point(256, 155);
            this.tbnhapmatkhau.Name = "tbnhapmatkhau";
            this.tbnhapmatkhau.Properties.DisplayFormat.FormatString = "*";
            this.tbnhapmatkhau.Properties.Padding = new System.Windows.Forms.Padding(-1, 0, 0, 0);
            this.tbnhapmatkhau.Properties.UseSystemPasswordChar = true;
            this.tbnhapmatkhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbnhapmatkhau.Size = new System.Drawing.Size(231, 22);
            this.tbnhapmatkhau.TabIndex = 4;
            this.tbnhapmatkhau.ToolTipAnchor = DevExpress.Utils.ToolTipAnchor.Object;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(57, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 23);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Mật khẫu :";
            // 
            // btdangnhap
            // 
            this.btdangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdangnhap.ImageOptions.Image")));
            this.btdangnhap.Location = new System.Drawing.Point(109, 222);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(125, 47);
            this.btdangnhap.TabIndex = 5;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // btthoat
            // 
            this.btthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.ImageOptions.Image")));
            this.btthoat.Location = new System.Drawing.Point(289, 222);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(130, 47);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "Thoát";
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // fromdangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 335);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.tbnhapmatkhau);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tbdangnhap);
            this.Controls.Add(this.labelControl1);
            this.KeyPreview = true;
            this.Name = "fromdangnhap";
            this.Text = "fromdangnhap";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromdangnhap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tbdangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbnhapmatkhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbdangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbnhapmatkhau;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btdangnhap;
        private DevExpress.XtraEditors.SimpleButton btthoat;
    }
}