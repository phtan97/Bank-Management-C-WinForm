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
    public partial class GUI_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        public GUI_KhachHang()
        {
            InitializeComponent();
        }
        BUS_KhachHang bus_khachhang = new BUS_KhachHang();
        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            bsrcKhachHang.DataSource = bus_khachhang.LayDsKhachHang();
            bnavKhachHang.BindingSource = bsrcKhachHang;
            dgvKhachHang.DataSource = bsrcKhachHang;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = null;
            if (radNam.Checked)
            {
                kh = new DTO_KhachHang(txtMaKH.Text, txtHoKH.Text, txtTen.Text, dtpNgaySinh.Value, radNam.Text, txtDanToc.Text, txtCMND.Text, dtpNgayCap.Value, txtDiaChi.Text, txtEmail.Text);
            }
            else
            {
                kh = new DTO_KhachHang(txtMaKH.Text, txtHoKH.Text, txtTen.Text, dtpNgaySinh.Value, radNu.Text, txtDanToc.Text, txtCMND.Text, dtpNgayCap.Value, txtDiaChi.Text, txtEmail.Text);
            }
            if (bus_khachhang.ThemKhachHang(kh))
            {
                MessageBox.Show("Thêm thành công!");
                dgvKhachHang.DataSource = bus_khachhang.LayDsKhachHang();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                DialogResult r;
                r = MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (bus_khachhang.XoaKhachHang(txtMaKH.Text))
                    {
                        MessageBox.Show("Khách hàng đã được xóa thành công");
                        dgvKhachHang.DataSource = bus_khachhang.LayDsKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng bạn muốn xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                DTO_KhachHang kh = null;
                if (radNam.Checked)
                {
                    kh = new DTO_KhachHang(txtMaKH.Text, txtHoKH.Text, txtTen.Text, dtpNgaySinh.Value, radNam.Text, txtDanToc.Text, txtCMND.Text, dtpNgayCap.Value, txtDiaChi.Text, txtEmail.Text);
                }
                else
                {
                    kh = new DTO_KhachHang(txtMaKH.Text, txtHoKH.Text, txtTen.Text, dtpNgaySinh.Value, radNu.Text, txtDanToc.Text, txtCMND.Text, dtpNgayCap.Value, txtDiaChi.Text, txtEmail.Text);
                }
                DialogResult r;
                r = MessageBox.Show("Bạn chắc chắn muốn sửa thông tin khách hàng này?", "Thông báo", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    if (bus_khachhang.SuaKhachHang(kh))
                    {
                        MessageBox.Show("Thông tin khách hàng đã được sửa đổi!");
                        dgvKhachHang.DataSource = bus_khachhang.LayDsKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Sửa đổi thông tin khách hàng thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng bạn muốn sửa đổi!");
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvKhachHang.Rows[e.RowIndex].Cells[3].Value);
            if (radNam.Text == dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString())
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtDanToc.Text = dgvKhachHang.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCMND.Text = dgvKhachHang.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtpNgayCap.Value = Convert.ToDateTime(dgvKhachHang.Rows[e.RowIndex].Cells[7].Value);
            txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = bus_khachhang.TimKiemKhachHang(txtTimKiem.Text);
        }
    }
}