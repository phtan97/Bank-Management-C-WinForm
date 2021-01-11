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
using DTO_BankManagement;

namespace GUI_BankManagement
{
    public partial class GUI_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                BUS_TaiKhoanNhanVien bus_dangnhap = new BUS_TaiKhoanNhanVien();
                DTO_DangNhap dangnhap = new DTO_DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                if (bus_dangnhap.DangNhap(dangnhap) == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Hide();
                    GUI_ThongTinDangNhap thongtindangnhap = new GUI_ThongTinDangNhap(txtTaiKhoan.Text);
                    thongtindangnhap.Show();
                    //frmMain frm = new frmMain();                    
                    //frm.Sender(bus_dangnhap.ID_User);
                    int id = bus_dangnhap.ID_User;
                    (Application.OpenForms["frmMain"] as frmMain).PhanQuyen(id);
                    
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu chưa có hoặc không tồn tại, vui lòng kiểm tra cơ sở dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng cửa sổ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                Close();
            }
        }
    }
}