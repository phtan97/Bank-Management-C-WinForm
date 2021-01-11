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
    public partial class GUI_TimHopDongVay : DevExpress.XtraEditors.XtraForm
    {
        public GUI_TimHopDongVay()
        {
            InitializeComponent();
        }
        BUS_HopDongVay bus_hdvay = new BUS_HopDongVay();
        private void dgvHopDongVay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHD.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaKH.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoTienVay.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLaiSuat.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNgayVay.Value = Convert.ToDateTime(dgvHopDongVay.Rows[e.RowIndex].Cells[4].Value);
                dtpKyHan.Value = Convert.ToDateTime(dgvHopDongVay.Rows[e.RowIndex].Cells[5].Value);
                txtMucDichVay.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (dgvHopDongVay.Rows[e.RowIndex].Cells[7].Value.ToString() == false.ToString())
                {
                    radKhong.Checked = true;
                }
                else
                {
                    radCo.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu để hiển thị, vui lòng chọn dữ liệu khác!");
            }
        }

        private void GUI_TimHopDongVay_Load(object sender, EventArgs e)
        {
            dgvHopDongVay.DataSource = bus_hdvay.LayDsHopDong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_hdvay.TimKiemHDVay(txtTimKiem.Text) == null)
                {
                    MessageBox.Show("Dữ liệu đã bị sai hoặc không tìm thấy, vui lòng kiểm tra lại dữ liệu nhập vào!");
                }
                else
                {
                    dgvHopDongVay.DataSource = bus_hdvay.TimKiemHDVay(txtTimKiem.Text);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đã bị sai hoặc không tìm thấy, vui lòng kiểm tra lại dữ liệu nhập vào!");
            }
        }
        private void SapXep()
        {
            if (cboSapXep.Text == "Mã hợp đồng" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["MaHD"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mã hợp đồng" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["MaHD"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Mã khách hàng" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["MaKH"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mã khách hàng" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["MaKH"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Số tiền vay" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["SoTienVay"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Số tiền vay" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["SoTienVay"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Lãi suất" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["LaiSuat"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Lãi suất" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["LaiSuat"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Ngày vay" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["NgayVay"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Ngày vay" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["NgayVay"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Ngày trả" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["NgayTra"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Ngày trả" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["NgayTra"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Mục đích vay" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["MucDichVay"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mục đích vay" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["MucDichVay"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Thế chấp" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["TheChap"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Thế chấp" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongVay.Sort(dgvHopDongVay.Columns["TheChap"], ListSortDirection.Descending);
            }
            else
            {
                MessageBox.Show("Lỗi! kiểm tra lại bộ nguồn!");
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
                GUI_frmReport frm = new GUI_frmReport();
                frm.sender(txtMaHD.Text);
                frm.Show();
            }
        }
    }
}