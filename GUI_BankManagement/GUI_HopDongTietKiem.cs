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
    public partial class GUI_HopDongTietKiem : DevExpress.XtraEditors.XtraForm
    {
        public GUI_HopDongTietKiem()
        {
            InitializeComponent();
        }
        BUS_HopDongTietKiem bus_hdtietkiem = new BUS_HopDongTietKiem();
        private void GUI_HopDongTietKiem_Load(object sender, EventArgs e)
        {
            string hdvay = "hợp đồng cho vay";
            foreach (DataRow dr in bus_hdtietkiem.DsHDTheoLoaiHD(hdvay).Rows)
            {
                cboMaHD.Items.Add(dr["MaHD"].ToString());
            }
            foreach (DataRow dr in bus_hdtietkiem.LayDsMaKH().Rows)
            {
                cboMaKH.Items.Add(dr["MaKH"].ToString());
            }
            dgvHDTietKiem.DataSource = bus_hdtietkiem.LayDsHopDong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_HopDongTietKiem hdtietkiem = new DTO_HopDongTietKiem(cboMaHD.SelectedItem.ToString(), cboMaKH.SelectedItem.ToString(), Convert.ToDecimal(txtSoTienGui.Text), dtpNgayGui.Value, dtpNgayDenHan.Value, float.Parse(txtLaiSuat.Text));
            if (bus_hdtietkiem.ThemHopDong(hdtietkiem))
            {
                MessageBox.Show("Thêm thành công!");
                dgvHDTietKiem.DataSource = bus_hdtietkiem.LayDsHopDong();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Vui lòng thử lại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text != null)
            {
                if (bus_hdtietkiem.XoaHopDong(cboMaHD.Text))
                {
                    MessageBox.Show("Hợp đồng đã được xóa thành công");
                    dgvHDTietKiem.DataSource = bus_hdtietkiem.LayDsHopDong();
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
            DTO_HopDongTietKiem hdtietkiem = new DTO_HopDongTietKiem(cboMaHD.SelectedItem.ToString(), cboMaKH.SelectedItem.ToString(), Convert.ToDecimal(txtSoTienGui.Text), dtpNgayGui.Value, dtpNgayDenHan.Value, float.Parse(txtLaiSuat.Text));
            if (bus_hdtietkiem.SuaHopDong(hdtietkiem))
            {
                MessageBox.Show("sửa đổi hợp đồng thành công!");
                dgvHDTietKiem.DataSource = bus_hdtietkiem.LayDsHopDong();
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

        private void dgvHDTietKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cboMaHD.Text = dgvHDTietKiem.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboMaKH.Text = dgvHDTietKiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpNgayGui.Value = Convert.ToDateTime(dgvHDTietKiem.Rows[e.RowIndex].Cells[2].Value);
                dtpNgayDenHan.Value = Convert.ToDateTime(dgvHDTietKiem.Rows[e.RowIndex].Cells[3].Value);
                txtSoTienGui.Text = dgvHDTietKiem.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtLaiSuat.Text = dgvHDTietKiem.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy dữ liệu hoặc dữ liệu không phù hợp, vui lòng chọn lại dữ liệu!");
            }
        }
        private void TinhLaiSuatGuiTietKiem()
        {
            int KyHanGui = int.Parse(cboKyHanGui.SelectedItem.ToString());
            if (KyHanGui <= 2)
            {
                txtLaiSuat.Text = (3).ToString();
            }
            else if (KyHanGui >= 3 && KyHanGui < 6)
            {
                txtLaiSuat.Text = (3.30).ToString();
            }
            else if (KyHanGui >= 6 && KyHanGui <= 9)
            {
                txtLaiSuat.Text = (3.90).ToString();
            }
            else if (KyHanGui > 9 && KyHanGui <= 12)
            {
                txtLaiSuat.Text = (5.60).ToString();
            }
            else if (KyHanGui > 12 && KyHanGui <= 36)
            {
                txtLaiSuat.Text = (5.40).ToString();
            }
        }
        private void cboKyHanGui_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpNgayDenHan.Value = DateTime.Now.AddMonths(int.Parse(cboKyHanGui.SelectedItem.ToString()));
            TinhLaiSuatGuiTietKiem();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHDTietKiem.DataSource = bus_hdtietkiem.TimKiemHDTietKiem(txtTimKiem.Text);
        }
    }
}