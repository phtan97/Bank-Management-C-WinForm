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
    public partial class GUI_HopDong : DevExpress.XtraEditors.XtraForm
    {
        public GUI_HopDong()
        {
            InitializeComponent();
        }
        BUS_HopDong bus_hopdong = new BUS_HopDong();
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_HopDong hopdong = new DTO_HopDong(txtMaHD.Text, cboLoaiHD.SelectedItem.ToString());
            if (bus_hopdong.ThemHopDong(hopdong))
            {
                MessageBox.Show("Thêm thành công!");
                dgvHopDong.DataSource = bus_hopdong.LayDsHopDong();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD != null)
            {
                if (bus_hopdong.XoaHopDong(txtMaHD.Text))
                {
                    MessageBox.Show("Hợp đồng đã được xóa thành công");
                    dgvHopDong.DataSource = bus_hopdong.LayDsHopDong();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn hợp đồng bạn muốn xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_HopDong hopdong = new DTO_HopDong(txtMaHD.Text, cboLoaiHD.SelectedItem.ToString());
            if (bus_hopdong.SuaHopDong(hopdong))
            {
                MessageBox.Show("sửa đổi hợp đồng thành công!");
                dgvHopDong.DataSource = bus_hopdong.LayDsHopDong();
            }
            else
            {
                MessageBox.Show("Sửa đổi thông tin hợp đồng thất bại");
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

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvHopDong.Rows[e.RowIndex].Cells[0].Value.ToString();
            cboLoaiHD.Text = dgvHopDong.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void GUI_HopDong_Load(object sender, EventArgs e)
        {
            bsrcHopDong.DataSource = bus_hopdong.LayDsHopDong();
            bnavHopDong.BindingSource = bsrcHopDong;
            dgvHopDong.DataSource = bsrcHopDong;
        }
        private void SapXep()
        {
            if (cboSapXep.Text == "Mã hợp đồng" && cboThuTu.Text == "Tăng")
            {
                dgvHopDong.Sort(dgvHopDong.Columns["MaHD"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mã hợp đồng" && cboThuTu.Text == "Giảm")
            {
                dgvHopDong.Sort(dgvHopDong.Columns["MaHD"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Loại hợp đồng" && cboThuTu.Text == "Tăng")
            {
                dgvHopDong.Sort(dgvHopDong.Columns["LoaiHD"], ListSortDirection.Ascending);
            }
            else
            {
                dgvHopDong.Sort(dgvHopDong.Columns["LoaiHD"], ListSortDirection.Descending);
            }
        }
        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            SapXep();
        }

        private void cboThuTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            SapXep();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHopDong.DataSource = bus_hopdong.TimKiemHopDong(txtTimKiem.Text);
        }
    }
}