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
using System.Globalization;

namespace GUI_BankManagement
{
    public partial class GUI_LaiSuatTietKiem : DevExpress.XtraEditors.XtraForm
    {
        public GUI_LaiSuatTietKiem()
        {
            InitializeComponent();
        }
        BUS_TinhToanLaiSuatGuiTietKiem bus_lstietkiem = new BUS_TinhToanLaiSuatGuiTietKiem();
        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime kyhanvay;
            decimal SoTienGui;
            decimal LaiSuatHangThang;
            decimal LaiMoiThang;
            decimal TongLai;
            decimal TongGocLai;
            foreach (DataRow dr in bus_lstietkiem.ThongTinKhachHangGuiTietKiem(cboMaKH.SelectedItem.ToString()).Rows)
            {
                SoTienGui = Convert.ToDecimal(dr["SoTienGui"]);
                txtLaiSuat.Text = dr["LaiSuat"].ToString();
                dtpNgayGui.Value = Convert.ToDateTime(dr["NgayGui"].ToString());
                kyhanvay = Convert.ToDateTime(dr["NgayDenHan"].ToString());
                txtKyHanGui.Text = (((kyhanvay.Month - dtpNgayGui.Value.Month) + 12 * (kyhanvay.Year - dtpNgayGui.Value.Year)).ToString());
                LaiSuatHangThang = SoTienGui * Convert.ToDecimal(float.Parse(txtLaiSuat.Text) / 100) / 12;
                LaiMoiThang = (SoTienGui / 12 + LaiSuatHangThang);
                TongLai = (LaiMoiThang * Convert.ToDecimal(txtKyHanGui.Text));
                TongGocLai = TongLai + SoTienGui;
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                txtSoTienGui.Text = SoTienGui.ToString("#,### VND", cul.NumberFormat);
                txtLaiMoiThang.Text = LaiMoiThang.ToString("#,### VND", cul.NumberFormat);
                txtTongLai.Text = TongLai.ToString("#,### VND", cul.NumberFormat);
                txtTongGocLai.Text = TongGocLai.ToString("#,### VND", cul.NumberFormat);
            }
        }

        private void GUI_LaiSuatTietKiem_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bus_lstietkiem.DanhSachKhachHangGuiTietKiem().Rows)
            {
                cboMaKH.Items.Add(dr["MaKH"].ToString());
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
    }
}