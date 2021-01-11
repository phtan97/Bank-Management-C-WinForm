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
    public partial class GUI_HopDongVay : DevExpress.XtraEditors.XtraForm
    {
        public GUI_HopDongVay()
        {
            InitializeComponent();
        }
        BUS_HopDongVay bus_hdvay = new BUS_HopDongVay();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng cửa sổ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                Close();
            }
        }
        public void KiemTraTheChap()
        {
            if (radYes.Checked)
            {
                DialogResult r;
                r = MessageBox.Show("Với việc chọn có, màn hình thế chấp sẽ hiện lên, bạn có muốn tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == r)
                {
                    GUI_TheChap thechap = new GUI_TheChap();
                    thechap.Show();
                }
                else
                {
                    radNo.Checked = true;
                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (radYes.Checked)
            {
                DTO_HopDongVay hdvay = new DTO_HopDongVay(cboMaHD.Text, cboMaKH.Text, Convert.ToDecimal(txtSoTienVay.Text), float.Parse(txtLaiSuat.Text), dtpNgayVay.Value, dtpKyHan.Value, cboMucDichVay.SelectedItem.ToString(), true);
                if (bus_hdvay.ThemHopDongVay(hdvay))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvHopDongVay.DataSource = bus_hdvay.LayDsHopDong();
                }
            }
            else
            {
                DTO_HopDongVay hdvay = new DTO_HopDongVay(cboMaHD.Text, cboMaKH.Text, Convert.ToDecimal(txtSoTienVay.Text), float.Parse(txtLaiSuat.Text), dtpNgayVay.Value, dtpKyHan.Value, cboMucDichVay.SelectedItem.ToString(), false);
                if (bus_hdvay.ThemHopDongVay(hdvay))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvHopDongVay.DataSource = bus_hdvay.LayDsHopDong();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text != null)
            {
                if (bus_hdvay.XoaHopDongVay(cboMaHD.Text))
                {
                    MessageBox.Show("Hợp đồng đã được xóa thành công");
                    dgvHopDongVay.DataSource = bus_hdvay.LayDsHopDong();
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
            DTO_HopDongVay hdvay = null;
            if (bus_hdvay.SuaHopDongVay(hdvay))
            {
                if (radYes.Checked)
                {
                    new DTO_HopDongVay(cboMaHD.Text, cboMaKH.Text, Convert.ToDecimal(txtSoTienVay.Text), float.Parse(txtLaiSuat.Text), dtpNgayVay.Value, dtpKyHan.Value, cboMucDichVay.SelectedItem.ToString(), bool.Parse(radYes.Text));
                    MessageBox.Show("sửa đổi hợp đồng thành công!");
                    dgvHopDongVay.DataSource = bus_hdvay.LayDsHopDong();
                }
                else
                {
                    new DTO_HopDongVay(cboMaHD.Text, cboMaKH.Text, Convert.ToDecimal(txtSoTienVay.Text), float.Parse(txtLaiSuat.Text), dtpNgayVay.Value, dtpKyHan.Value, cboMucDichVay.SelectedItem.ToString(), bool.Parse(radNo.Text));
                    MessageBox.Show("sửa đổi hợp đồng thành công!");
                    dgvHopDongVay.DataSource = bus_hdvay.LayDsHopDong();
                }
            }
            else
            {
                MessageBox.Show("Sửa đổi thông tin hợp đồng thất bại");
            }
        }

        private void dgvHopDongVay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cboMaHD.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboMaKH.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoTienVay.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtLaiSuat.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtpNgayVay.Value = Convert.ToDateTime(dgvHopDongVay.Rows[e.RowIndex].Cells[4].Value);
                dtpKyHan.Value = Convert.ToDateTime(dgvHopDongVay.Rows[e.RowIndex].Cells[5].Value);
                cboMucDichVay.Text = dgvHopDongVay.Rows[e.RowIndex].Cells[6].Value.ToString();
                if (dgvHopDongVay.Rows[e.RowIndex].Cells[7].Value.ToString() == false.ToString())
                {
                    radNo.Checked = true;
                }
                else
                {
                    radYes.Checked = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị, vui lòng chọn dữ liệu khác!");
            }
        }

        private void GUI_HopDongVay_Load(object sender, EventArgs e)
        {
            string hdvay = "hợp đồng cho vay";
            foreach (DataRow dr in bus_hdvay.DsHDTheoLoaiHD(hdvay).Rows)
            {
                cboMaHD.Items.Add(dr["MaHD"].ToString());
            }
            cboMaKH.DataSource = bus_hdvay.LayDsMaKH();
            cboMaKH.DisplayMember = "MaKH";
            dgvHopDongVay.DataSource = bus_hdvay.LayDsHopDong();
        }

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radYes.Checked)
            {
                KiemTraTheChap();
                TinhLaiSuatVay();
            }
        }
        private void TinhLaiSuatVay()
        {
            try
            {
                int KyHanVay = int.Parse(cboKyHanVay.SelectedItem.ToString());
                if (KyHanVay < 6)
                {
                    if (cboMucDichVay.SelectedItem.ToString() == "Vay tiêu dùng")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (9.25).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (7.2).ToString();
                        }
                    }
                    else if (cboMucDichVay.SelectedItem.ToString() == "Vay kinh doanh")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (8.89).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (6.98).ToString();
                        }
                    }
                    else
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (9).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (7.05).ToString();
                        }
                    }
                }
                else if (KyHanVay >= 6 && KyHanVay < 12)
                {
                    if (cboMucDichVay.SelectedItem.ToString() == "Vay tiêu dùng")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (11.5).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (9.8).ToString();
                        }
                    }
                    else if (cboMucDichVay.SelectedItem.ToString() == "Vay kinh doanh")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (13.7).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (11.2).ToString();
                        }
                    }
                    else
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (12.99).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (10.6).ToString();
                        }
                    }
                }
                else if (KyHanVay >= 12 && KyHanVay < 24)
                {
                    if (cboMucDichVay.SelectedItem.ToString() == "Vay tiêu dùng")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (15.99).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (13.7).ToString();
                        }
                    }
                    else if (cboMucDichVay.SelectedItem.ToString() == "Vay kinh doanh")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (14.22).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (12.9).ToString();
                        }
                    }
                    else
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (15.12).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (13.3).ToString();
                        }
                    }
                }
                else if (KyHanVay >= 24)
                {
                    if (cboMucDichVay.SelectedItem.ToString() == "Vay tiêu dùng")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (18.9).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (16.22).ToString();
                        }
                    }
                    else if (cboMucDichVay.SelectedItem.ToString() == "Vay kinh doanh")
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (16.99).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (15.5).ToString();
                        }
                    }
                    else
                    {
                        if (radNo.Checked)
                        {
                            txtLaiSuat.Text = (18).ToString();
                        }
                        else
                        {
                            txtLaiSuat.Text = (16).ToString();
                        }
                    }
                }
            }
            catch(Exception) { }
        }
        private void cboKyHanVay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpKyHan.Value = DateTime.Now.AddMonths(int.Parse(cboKyHanVay.SelectedItem.ToString()));
            TinhLaiSuatVay();
        }

        private void cboMucDichVay_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhLaiSuatVay();
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            TinhLaiSuatVay();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvHopDongVay.DataSource = bus_hdvay.TimKiemHDVay(txtTimKiem.Text);
        }
    }
}