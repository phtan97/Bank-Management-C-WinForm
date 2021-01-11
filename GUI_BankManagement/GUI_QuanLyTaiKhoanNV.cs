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
    public partial class GUI_QuanLyTaiKhoanNV : DevExpress.XtraEditors.XtraForm
    {
        public GUI_QuanLyTaiKhoanNV()
        {
            InitializeComponent();
        }
        BUS_QuanLyTaiKhoanNhanVien bus_taikhoan = new BUS_QuanLyTaiKhoanNhanVien();
        private void GUI_QuanLyTaiKhoanNV_Load(object sender, EventArgs e)
        {
            bsrcTaiKhoanNV.DataSource = bus_taikhoan.LayDsTaiKhoan();
            bnavTaiKhoanNV.BindingSource = bsrcTaiKhoanNV;
            dgvTaiKhoanNV.DataSource = bsrcTaiKhoanNV;
            foreach (DataRow dr in bus_taikhoan.LayDsMaNV().Rows)
            {
                txtMaNV.Items.Add(dr["MaNV"].ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboChucVu.SelectedItem.ToString() == "Nhân viên")
            {
                cboChucVu.Text = "1";
            }
            else
            {
                cboChucVu.Text = "2";
            }
            DTO_TaiKhoanNV taikhoan = new DTO_TaiKhoanNV(txtMaNV.Text, txtTaiKhoan.Text, txtMatKhau.Text, cboChucVu.Text);
            if (bus_taikhoan.ThemTaiKhoan(taikhoan))
            {
                MessageBox.Show("Thêm thành công!");
                dgvTaiKhoanNV.DataSource = bus_taikhoan.LayDsTaiKhoan();
                txtTaiKhoan.Clear();
                txtMatKhau.Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTaiKhoan.Text))
            {
                if (bus_taikhoan.XoaNhanVien(txtMaNV.Text))
                {
                    MessageBox.Show("Tài khoản nhân viên đã được xóa thành công");
                    dgvTaiKhoanNV.DataSource = bus_taikhoan.LayDsTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên bạn muốn xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                DTO_TaiKhoanNV taikhoan = new DTO_TaiKhoanNV(txtMaNV.Text, txtTaiKhoan.Text, txtMatKhau.Text, cboChucVu.Text);
                if (bus_taikhoan.SuaNhanVien(taikhoan))
                {
                    MessageBox.Show("Thông tin nhân viên đã được sửa đổi!");
                    dgvTaiKhoanNV.DataSource = bus_taikhoan.LayDsTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhân viên thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên bạn muốn sửa đổi!");
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

        private void dgvTaiKhoanNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvTaiKhoanNV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTaiKhoan.Text = dgvTaiKhoanNV.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoanNV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dgvTaiKhoanNV.Rows[e.RowIndex].Cells[3].Value.ToString() == "1")
            {
                cboChucVu.Text = "Nhân viên";
            }
            else
            {
                cboChucVu.Text = "Quản lý";
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text=="Nhân viên")
            {
                txtTimKiem.Text = "1";
            }
            else
            {
                txtTimKiem.Text = "2";
            }
            dgvTaiKhoanNV.DataSource = bus_taikhoan.TimKiemTaiKhoanNV(txtTimKiem.Text);
        }
    }
}