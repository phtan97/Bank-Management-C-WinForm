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
    public partial class GUI_TimHDTietKiem : DevExpress.XtraEditors.XtraForm
    {
        public GUI_TimHDTietKiem()
        {
            InitializeComponent();
        }
        BUS_HopDongTietKiem bus_hdtietkiem = new BUS_HopDongTietKiem();
        private void dgvHopDongTietKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHD.Text = dgvHopDongTietKiem.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaKH.Text = dgvHopDongTietKiem.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoTienGui.Text = dgvHopDongTietKiem.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpNgayGui.Text = Convert.ToDateTime(dgvHopDongTietKiem.Rows[e.RowIndex].Cells[3].Value).ToString();
                dtpKyHan.Text = Convert.ToDateTime(dgvHopDongTietKiem.Rows[e.RowIndex].Cells[4].Value).ToString();
                txtLaiSuat.Text = dgvHopDongTietKiem.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu để hiển thị, vui lòng chọn dữ liệu khác!");
            }
        }
        private void SapXep()
        {
            if (cboSapXep.Text == "Mã hợp đồng" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["MaHD"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mã hợp đồng" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["MaHD"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Mã khách hàng" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["MaKH"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mã khách hàng" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["MaKH"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Số tiền gửi" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["SoTienGui"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Số tiền gửi" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["SoTienGui"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Ngày gửi" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["NgayGui"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Ngày gửi" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["NgayGui"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Kỳ hạn" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["NgayDenHan"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Kỳ hạn" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["NgayDenHan"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Lãi suất" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["LaiSuat"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Lãi suất" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTietKiem.Sort(dgvHopDongTietKiem.Columns["LaiSuat"], ListSortDirection.Descending);
            }
        }
        private void cboSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            SapXep();
        }

        private void cboTangGiam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SapXep();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để lập báo cáo!");
            }
            else
            {
                GUI_frmReportHDTietKiem frm = new GUI_frmReportHDTietKiem();
                frm.sender(txtMaHD.Text);
                frm.Show();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_hdtietkiem.TimKiemHDTietKiem(txtTimKiem.Text) == null)
                {
                    MessageBox.Show("Dữ liệu đã bị sai hoặc không tìm thấy, vui lòng kiểm tra lại dữ liệu nhập vào!");
                }
                else
                {
                    dgvHopDongTietKiem.DataSource = bus_hdtietkiem.TimKiemHDTietKiem(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đã bị sai hoặc không tìm thấy, vui lòng kiểm tra lại dữ liệu nhập vào!");
            }
        }

        private void GUI_TimHDTietKiem_Load(object sender, EventArgs e)
        {
            dgvHopDongTietKiem.DataSource = bus_hdtietkiem.LayDsHopDong();
        }
    }
}