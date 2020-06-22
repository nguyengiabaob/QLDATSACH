using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace BTH4
{
    public partial class formmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public formmain()
        {
            InitializeComponent();
        }
        public string maNV;
        formdoimatkhau formdoimk;
        private void ribbon_Click(object sender, EventArgs e)
        {

        }
        public void enablecontrol(int MaLTK)
        {
            switch(MaLTK)
            {
                case 1:
                    btdangxuat.Enabled = true;
                    btchamcong.Enabled = true;
                    btnhanvien.Enabled = true;
                    bttaohoadon.Enabled = true;
                    btloaisanpham.Enabled = true;
                    btsanpham.Enabled = true;
                    btdonhang.Enabled = true;
                    btkhachhang.Enabled = true;
                    btdoimatkhau.Enabled = true;
                    btthongke.Enabled = true;
                    break;
                case 2:
                    btdangxuat.Enabled = true;
                    btchamcong.Enabled = false;
                    btnhanvien.Enabled = false;
                    bttaohoadon.Enabled = true;
                    btloaisanpham.Enabled = false;
                    btsanpham.Enabled = false;
                    btdonhang.Enabled = false;
                    btkhachhang.Enabled = true;
                    btdoimatkhau.Enabled = true;
                    btthongke.Enabled = false;
                    break;
                case 3:
                    btdangxuat.Enabled = true;
                    btchamcong.Enabled = false;
                    btnhanvien.Enabled = false;
                    bttaohoadon.Enabled = false;
                    btloaisanpham.Enabled = true;
                    btsanpham.Enabled = true;
                    btdonhang.Enabled = false;
                    btkhachhang.Enabled = true;
                    btdoimatkhau.Enabled = true;
                    btthongke.Enabled = false;
                    break;
                default:
                    btdangxuat.Enabled = false;
                    btchamcong.Enabled = false;
                    btnhanvien.Enabled = false;
                    bttaohoadon.Enabled = false;
                    btloaisanpham.Enabled = false;
                    btsanpham.Enabled = false;
                    btdonhang.Enabled = false;
                    btkhachhang.Enabled = false;
                    btdoimatkhau.Enabled = false;
                    btthongke.Enabled = false;
                    break;
                   
            }

        }

        private void formmain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            enablecontrol(-1); ;
            fromdangnhap f = new fromdangnhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            
            f.Show();
            f.WindowState = FormWindowState.Normal;

        }

        private void btdangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach(Form f in this.MdiChildren)
            {
                f.Close();
            }
            formmain_Load(sender, e);

        }

        private void btdoimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formdoimk == null || formdoimk.IsDisposed)
            {
                formdoimk = new formdoimatkhau();
                //this.WindowState = FormWindowState.Maximized;
                formdoimk.MdiParent = this;
                formdoimk.StartPosition = FormStartPosition.CenterScreen;
                formdoimk.Show();

            }
            else
            {
                formdoimk.Activate();
                formdoimk.Show();
            }
           
        }
    }
}