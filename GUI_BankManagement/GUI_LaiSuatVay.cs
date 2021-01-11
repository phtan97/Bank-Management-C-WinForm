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
    public partial class GUI_LaiSuatVay : DevExpress.XtraEditors.XtraForm
    {
        public GUI_LaiSuatVay()
        {
            InitializeComponent();
        }
        BUS_TinhToanLaiSuatVay bus_lsvay = new BUS_TinhToanLaiSuatVay();
        private void GUI_LaiSuatVay_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bus_lsvay.DanhSachKhachHangVay().Rows)
            {
                cboMaKH.Items.Add(dr["MaKH"].ToString());
            }
        }        
        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime kyhanvay;
            decimal SoTienVay;
            decimal LaiSuatHangThang;
            decimal LaiMoiThang;
            decimal TongLai;
            decimal TongGocLai;
            foreach (DataRow dr in bus_lsvay.ThongTinKhachHangVay(cboMaKH.SelectedItem.ToString()).Rows)
            {
                SoTienVay = Convert.ToDecimal(dr["SoTienVay"]);
                txtLaiSuat.Text = dr["LaiSuat"].ToString();
                dtpNgayVay.Value = Convert.ToDateTime(dr["NgayVay"].ToString());
                kyhanvay = Convert.ToDateTime(dr["NgayTra"].ToString());
                txtKyHanVay.Text = (((kyhanvay.Month - dtpNgayVay.Value.Month) + 12 * (kyhanvay.Year - dtpNgayVay.Value.Year)).ToString());
                LaiSuatHangThang = SoTienVay * Convert.ToDecimal(float.Parse(txtLaiSuat.Text) / 100) / 12;
                LaiMoiThang = (SoTienVay / 12 + LaiSuatHangThang);
                TongLai = (LaiMoiThang * Convert.ToDecimal(txtKyHanVay.Text));
                TongGocLai = TongLai + SoTienVay ;
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                txtSoTienVay.Text = SoTienVay.ToString("#,### VND",cul.NumberFormat);
                txtLaiMoiThang.Text = LaiMoiThang.ToString("#,### VND", cul.NumberFormat);
                txtTongLai.Text = TongLai.ToString("#,### VND", cul.NumberFormat);
                txtTongGocLai.Text = TongGocLai.ToString("#,### VND", cul.NumberFormat);
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