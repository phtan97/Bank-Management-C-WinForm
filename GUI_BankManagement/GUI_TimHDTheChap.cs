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
    public partial class GUI_TimHDTheChap : DevExpress.XtraEditors.XtraForm
    {
        public GUI_TimHDTheChap()
        {
            InitializeComponent();
        }
        BUS_HopDongTheChap bus_hdthechap = new BUS_HopDongTheChap();
        private void dgvHopDongTheChap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaHD.Text = dgvHopDongTheChap.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaKH.Text = dgvHopDongTheChap.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLoaiTS.Text = dgvHopDongTheChap.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGiaTriTS.Text = dgvHopDongTheChap.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu để hiển thị, vui lòng chọn dữ liệu khác!");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == null)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để lập báo cáo!");
            }
            else
            {
                GUI_frmReportTheChap frm = new GUI_frmReportTheChap();
                frm.sender(txtMaHD.Text);
                frm.Show();
            }
        }

        private void GUI_TimHDTheChap_Load(object sender, EventArgs e)
        {
            dgvHopDongTheChap.DataSource = bus_hdthechap.LayDsHopDong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_hdthechap.TimHDTheChap(txtTimKiem.Text) == null)
                {
                    MessageBox.Show("Dữ liệu đã bị sai hoặc không tìm thấy, vui lòng kiểm tra lại dữ liệu nhập vào!");
                }
                else
                {
                    dgvHopDongTheChap.DataSource = bus_hdthechap.TimHDTheChap(txtTimKiem.Text);
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
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["MaHD"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mã hợp đồng" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["MaHD"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Mã khách hàng" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["MaKH"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Mã khách hàng" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["MaKH"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Loại tài sản" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["LoaiTaiSan"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Loại tài sản" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["LoaiTaiSan"], ListSortDirection.Descending);
            }
            else if (cboSapXep.Text == "Giá trị tài sản" && cboTangGiam.Text == "Tăng")
            {
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["GiaTriTaiSan"], ListSortDirection.Ascending);
            }
            else if (cboSapXep.Text == "Giá trị tài sản" && cboTangGiam.Text == "Giảm")
            {
                dgvHopDongTheChap.Sort(dgvHopDongTheChap.Columns["GiaTriTaiSan"], ListSortDirection.Descending);
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
    }
}