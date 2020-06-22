namespace BTH4
{
    partial class formmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formmain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btdangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btdoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btchamcong = new DevExpress.XtraBars.BarButtonItem();
            this.btloaisanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btsanpham = new DevExpress.XtraBars.BarButtonItem();
            this.btdonhang = new DevExpress.XtraBars.BarButtonItem();
            this.btkhachhang = new DevExpress.XtraBars.BarButtonItem();
            this.bttaohoadon = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btthongke = new DevExpress.XtraBars.BarButtonItem();
            this.btungdung = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btdangxuat,
            this.btdoimatkhau,
            this.btnhanvien,
            this.btchamcong,
            this.btloaisanpham,
            this.btsanpham,
            this.btdonhang,
            this.btkhachhang,
            this.bttaohoadon,
            this.barButtonItem9,
            this.btthongke,
            this.btungdung});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1371, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btdangxuat
            // 
            this.btdangxuat.Caption = "Đăng xuất";
            this.btdangxuat.Id = 1;
            this.btdangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdangxuat.ImageOptions.Image")));
            this.btdangxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btdangxuat.ImageOptions.LargeImage")));
            this.btdangxuat.Name = "btdangxuat";
            this.btdangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btdangxuat_ItemClick);
            // 
            // btdoimatkhau
            // 
            this.btdoimatkhau.Caption = "Đổi mật khẩu";
            this.btdoimatkhau.Id = 2;
            this.btdoimatkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdoimatkhau.ImageOptions.Image")));
            this.btdoimatkhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btdoimatkhau.ImageOptions.LargeImage")));
            this.btdoimatkhau.Name = "btdoimatkhau";
            this.btdoimatkhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btdoimatkhau_ItemClick);
            // 
            // btnhanvien
            // 
            this.btnhanvien.Caption = "Nhân viên";
            this.btnhanvien.Id = 3;
            this.btnhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnhanvien.ImageOptions.Image")));
            this.btnhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnhanvien.ImageOptions.LargeImage")));
            this.btnhanvien.Name = "btnhanvien";
            // 
            // btchamcong
            // 
            this.btchamcong.Caption = "Chấm công";
            this.btchamcong.Id = 4;
            this.btchamcong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btchamcong.ImageOptions.Image")));
            this.btchamcong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btchamcong.ImageOptions.LargeImage")));
            this.btchamcong.Name = "btchamcong";
            // 
            // btloaisanpham
            // 
            this.btloaisanpham.Caption = "Loại sản phẩm";
            this.btloaisanpham.Id = 5;
            this.btloaisanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btloaisanpham.ImageOptions.Image")));
            this.btloaisanpham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btloaisanpham.ImageOptions.LargeImage")));
            this.btloaisanpham.Name = "btloaisanpham";
            // 
            // btsanpham
            // 
            this.btsanpham.Caption = "Sản phẩm ";
            this.btsanpham.Id = 6;
            this.btsanpham.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btsanpham.ImageOptions.Image")));
            this.btsanpham.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btsanpham.ImageOptions.LargeImage")));
            this.btsanpham.Name = "btsanpham";
            // 
            // btdonhang
            // 
            this.btdonhang.Caption = "Đơn hàng";
            this.btdonhang.Id = 7;
            this.btdonhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btdonhang.ImageOptions.Image")));
            this.btdonhang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btdonhang.ImageOptions.LargeImage")));
            this.btdonhang.Name = "btdonhang";
            // 
            // btkhachhang
            // 
            this.btkhachhang.Caption = "Khách hàng";
            this.btkhachhang.Id = 8;
            this.btkhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btkhachhang.ImageOptions.Image")));
            this.btkhachhang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btkhachhang.ImageOptions.LargeImage")));
            this.btkhachhang.Name = "btkhachhang";
            // 
            // bttaohoadon
            // 
            this.bttaohoadon.Caption = "Tạo hóa đơn";
            this.bttaohoadon.Id = 9;
            this.bttaohoadon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bttaohoadon.ImageOptions.Image")));
            this.bttaohoadon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bttaohoadon.ImageOptions.LargeImage")));
            this.bttaohoadon.Name = "bttaohoadon";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thống kê";
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // btthongke
            // 
            this.btthongke.Caption = "Thống kê doanh thu";
            this.btthongke.Id = 11;
            this.btthongke.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btthongke.ImageOptions.Image")));
            this.btthongke.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btthongke.ImageOptions.LargeImage")));
            this.btthongke.Name = "btthongke";
            this.btthongke.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btungdung
            // 
            this.btungdung.Caption = "Ứng dụng";
            this.btungdung.Id = 12;
            this.btungdung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btungdung.ImageOptions.Image")));
            this.btungdung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btungdung.ImageOptions.LargeImage")));
            this.btungdung.Name = "btungdung";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btdangxuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btdoimatkhau);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnhanvien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btchamcong);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Nhân viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btloaisanpham);
            this.ribbonPageGroup3.ItemLinks.Add(this.btsanpham);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Sản phẩm";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btdonhang);
            this.ribbonPageGroup4.ItemLinks.Add(this.btkhachhang);
            this.ribbonPageGroup4.ItemLinks.Add(this.bttaohoadon);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Đơn hàng";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.btthongke);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thống kế";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btungdung);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Ứng dụng";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 555);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1371, 37);
            // 
            // formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 592);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "formmain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.formmain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btdangxuat;
        private DevExpress.XtraBars.BarButtonItem btdoimatkhau;
        private DevExpress.XtraBars.BarButtonItem btnhanvien;
        private DevExpress.XtraBars.BarButtonItem btchamcong;
        private DevExpress.XtraBars.BarButtonItem btloaisanpham;
        private DevExpress.XtraBars.BarButtonItem btsanpham;
        private DevExpress.XtraBars.BarButtonItem btdonhang;
        private DevExpress.XtraBars.BarButtonItem btkhachhang;
        private DevExpress.XtraBars.BarButtonItem bttaohoadon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btthongke;
        private DevExpress.XtraBars.BarButtonItem btungdung;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}