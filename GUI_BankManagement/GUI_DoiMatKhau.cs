using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS_BankManagement;

namespace GUI_BankManagement
{
    public partial class GUI_DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public string TaiKhoan;
        public GUI_DoiMatKhau(string taikhoan)
        {
            InitializeComponent();
            TaiKhoan = taikhoan;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BUS_TaiKhoanNhanVien doimatkhau = new BUS_TaiKhoanNhanVien();
            foreach(DataRow dr in doimatkhau.ThongTinDangNhap(TaiKhoan).Rows)
            {
                if(txtMatKhauCu.Text == dr["MatKhau"].ToString())
                {
                    doimatkhau.DoiMatKhau(TaiKhoan, txtMatKhauMoi.Text);
                    MessageBox.Show("Mật khẩu của bạn đã được thay đổi");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng, vui lòng nhập lại!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}