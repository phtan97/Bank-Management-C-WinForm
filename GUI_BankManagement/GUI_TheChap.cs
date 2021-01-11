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
using DTO_BankManagement;
using BUS_BankManagement;

namespace GUI_BankManagement
{
    public partial class GUI_TheChap : DevExpress.XtraEditors.XtraForm
    {
        public GUI_TheChap()
        {
            InitializeComponent();
        }
        BUS_HopDongTheChap bus_hdthechap = new BUS_HopDongTheChap();
        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_TheChap hdthechap = new DTO_TheChap(txtMaHD.Text, txtMaKH.Text, txtLoaiTS.Text, Convert.ToDecimal(txtGiaTriTS.Text));
            if (bus_hdthechap.ThemHopDong(hdthechap))
            {
                MessageBox.Show("Thêm thành công!");
                dgvTheChap.DataSource = bus_hdthechap.LayDsHopDong();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD != null)
            {
                if (bus_hdthechap.XoaHopDong(txtMaHD.Text))
                {
                    MessageBox.Show("Hợp đồng đã được xóa thành công");
                    dgvTheChap.DataSource = bus_hdthechap.LayDsHopDong();
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
            DTO_TheChap hdthechap = new DTO_TheChap(txtMaHD.Text, txtMaKH.Text, txtLoaiTS.Text, Convert.ToDecimal(txtGiaTriTS.Text));
            if (bus_hdthechap.SuaHopDong(hdthechap))
            {
                MessageBox.Show("sửa đổi hợp đồng thành công!");
                dgvTheChap.DataSource = bus_hdthechap.LayDsHopDong();
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

        private void dgvTheChap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvTheChap.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaKH.Text = dgvTheChap.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLoaiTS.Text = dgvTheChap.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGiaTriTS.Text = dgvTheChap.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void GUI_TheChap_Load(object sender, EventArgs e)
        {
            dgvTheChap.DataSource = bus_hdthechap.LayDsHopDong();
        }
    }
}