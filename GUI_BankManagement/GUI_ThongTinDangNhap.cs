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
    public partial class GUI_ThongTinDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public string TaiKhoan;
        public GUI_ThongTinDangNhap(string taikhoan)
        {
            InitializeComponent();
            TaiKhoan = taikhoan;
        }
        BUS_TaiKhoanNhanVien dangnhap = new BUS_TaiKhoanNhanVien();
        private void GUI_ThongTinDangNhap_Load(object sender, EventArgs e)
        {           
            foreach (DataRow dr in dangnhap.ThongTinDangNhap(TaiKhoan).Rows)
            {
                lblTaiKhoan.Text = dr["TenDangNhap"].ToString();
                txtMatKhau.Text = dr["MatKhau"].ToString();
                lblHoTen.Text = dr["HoNV"].ToString() + " " + dr["TenNV"].ToString();
                lblChucVu.Text = dr["ChucVu"].ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            GUI_DoiMatKhau doimatkhau = new GUI_DoiMatKhau(TaiKhoan);
            doimatkhau.ShowDialog();
            if(doimatkhau.DialogResult == DialogResult.OK)
            {
                foreach(DataRow dr in dangnhap.ThongTinDangNhap(TaiKhoan).Rows)
                {
                    txtMatKhau.Text = dr["MatKhau"].ToString();
                }
            }
        }
    }
}