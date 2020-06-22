using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTH4.modules;

namespace BTH4
{
    public partial class fromdangnhap : Form
    {
        public fromdangnhap()
        {
            InitializeComponent();
        }
        XLNHANVIEN tbnhnavien;

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            tbnhnavien = new XLNHANVIEN();
            var r = tbnhnavien.Select("Username= '" + tbdangnhap.Text + "'and Password='" + tbnhapmatkhau.Text + "'");
            if(r.Count()>0)
            {
                formmain f = (formmain)this.MdiParent;
                f.Text = "Quản lý Nhà sách -Chào" + r[0]["TENNV"].ToString();
                f.maNV = r[0]["MaNV"].ToString();
                f.enablecontrol((int)r[0]["MaLTK"]);
                this.Close();

            }
            else
            {

                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fromdangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(int)Keys.Enter)
            {
                btdangnhap_Click(sender, e);
            }
        }
    }
}
