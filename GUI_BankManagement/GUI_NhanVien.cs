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
    public partial class GUI_NhanVien : DevExpress.XtraEditors.XtraForm
    {
        
        public GUI_NhanVien()
        {
            InitializeComponent();
        }
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            bsrcPhanTrang.DataSource = bus_nhanvien.LayNhanVien();
            bnavPhanTrang.BindingSource = bsrcPhanTrang;
            dgvNhanVien.DataSource = bsrcPhanTrang;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_NhanVien nhanvien = new DTO_NhanVien(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text, txtChucVu.Text);
            if (bus_nhanvien.ThemNhanVien(nhanvien))
            {
                MessageBox.Show("Thêm thành công!");
                dgvNhanVien.DataSource = bus_nhanvien.LayNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtMaNV.Text)) 
            {
                DialogResult r;
                r = MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này!");
                if (r == DialogResult.OK)
                {
                    if (bus_nhanvien.XoaNhanVien(txtMaNV.Text))
                    {
                        MessageBox.Show("Nhân viên đã được xóa thành công");
                        dgvNhanVien.DataSource = bus_nhanvien.LayNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại, Bạn phải xóa tài khoản của nhân viên này trước!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên bạn muốn xóa!");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                DTO_NhanVien nv = new DTO_NhanVien(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text, txtChucVu.Text);
                DialogResult r;
                r = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (bus_nhanvien.SuaNhanVien(nv))
                    {
                        MessageBox.Show("Thông tin nhân viên đã được sửa đổi!");
                        dgvNhanVien.DataSource = bus_nhanvien.LayNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thất bại!");
                    }
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bus_nhanvien.TimKiemNhanVien(txtTimKiem.Text);
        }
    }
}