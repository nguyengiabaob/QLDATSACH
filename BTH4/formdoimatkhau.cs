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
    public partial class formdoimatkhau : Form
    {
        public formdoimatkhau()
        {
            InitializeComponent();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            dxErrorProvider1.SetError(tbnhapmoimatkhau, "");
            dxErrorProvider1.SetError(tbxnhaplaimatkhau, "");
            if (tbnhapmoimatkhau.Text.Length < 8 || (tbnhapmoimatkhau.Text.Any(char.IsDigit)) || (tbnhapmoimatkhau.Text.Any(char.IsLower)) || (tbnhapmoimatkhau.Text.Any(char.IsUpper)))
                {
                dxErrorProvider1.SetError(tbnhapmoimatkhau, "Mật khẩu mới gồm 8 kí tự,gồm chữ số," + "in hoa in thường");
                return;
            }
           if(tbnhapmoimatkhau.Text!=tbxnhaplaimatkhau.Text)
            {
                dxErrorProvider1.SetError(tbxnhaplaimatkhau, "Mật khẩu nhập lại không trủng");
                return;

            }
            formmain f = (formmain)this.MdiParent;
            int count = XLBANG.thuc_hien_lenh("Update NHANVIEN set Password='" + tbnhapmoimatkhau.Text + "Where MaNV ='"+f.maNV+"'");
            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Mật khẩu không hợp lệ");

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
