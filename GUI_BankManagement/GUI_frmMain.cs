using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_BankManagement;
using DTO_BankManagement;

namespace GUI_BankManagement
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //public int ID_User;
        //public delegate void KiemTraQuyen(int id_user);
        //public KiemTraQuyen Sender;
        public frmMain()
        {
            InitializeComponent();
            //Sender = new KiemTraQuyen(NhanGiaTriUser);
        }
        //public void NhanGiaTriUser(int id_user)
        //{
        //    ID_User = id_user;
        //}
        public void PhanQuyen(int id_user)
        {
            if(id_user == 1)
            {
                bbiDangNhap.Enabled = false;
                rbgQuanLy.Enabled = false;
                rbgThongKeBaoCao.Enabled = false;
                bbiDangXuat.Enabled = true;
                bbiThongTinKH.Enabled = true;
                rbgHopDong.Enabled = true;
                rbgTinhLai.Enabled = true;
                rbgTimKiem.Enabled = true;

            }
            else if (id_user == 2)
            {
                bbiDangNhap.Enabled = false;
                rbgQuanLy.Enabled = true;
                rbgThongKeBaoCao.Enabled = true;
                bbiDangXuat.Enabled = true;
                bbiThongTinKH.Enabled = true;
                rbgHopDong.Enabled = true;
                rbgTinhLai.Enabled = true;
                rbgTimKiem.Enabled = true;
            }
            else
            {
                bbiDangNhap.Enabled = true;
                bbiDangXuat.Enabled = false;
                rbgQuanLy.Enabled = false;
                bbiThongTinKH.Enabled = false;
                rbgHopDong.Enabled = false;
                rbgTinhLai.Enabled = false;
                rbgTimKiem.Enabled = false;
                rbgThongKeBaoCao.Enabled = false;
            }
        }
        private bool KiemTraFormActive(string name)
        {
            bool check = false;
            foreach (Form frm in MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveFormCon(string name)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen(0);
            GUI_Connect connect = new GUI_Connect();
            //if (connect.ShowDialog() == DialogResult.OK)
            //{
            //    GUI_DangNhap dangnhap = new GUI_DangNhap();
            //    if (dangnhap.ShowDialog() == DialogResult.OK)
            //    {
            //        PhanQuyen();
            //    }
            //    else
            //    {
            //        Application.Exit();
            //    }
            //}
            //else
            //{
            //    Application.Exit();
            //}
            connect.MdiParent = this;
            connect.Show();
        }
        private void bbiDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn muốn đăng xuất khỏi hệ thống?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                PhanQuyen(0);
            }           
        }

        private void bbiReconnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_Connect connect = new GUI_Connect();
            if (!KiemTraFormActive(connect.Name))
            {
                connect.MdiParent = this;
                connect.Show();
            }
            else
            {
                ActiveFormCon(connect.Name);
            }
        }

        private void bbiThongTinNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //GUI_ThongTinDangNhap thongtin = new GUI_ThongTinDangNhap();
            //thongtin.MdiParent = this;
            //thongtin.Show();
        }


        private void bbiThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_NhanVien nhanvien = new GUI_NhanVien();
            if (!KiemTraFormActive(nhanvien.Name))
            {
                nhanvien.MdiParent = this;
                nhanvien.Show();
            }
            else
            {
                ActiveFormCon(nhanvien.Name);
            }
        }

        private void bbiHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_HopDong hopdong = new GUI_HopDong();
            if (!KiemTraFormActive(hopdong.Name))
            {
                hopdong.MdiParent = this;
                hopdong.Show();
            }
            else
            {
                ActiveFormCon(hopdong.Name);
            }
        }

        private void bbiHopDongVay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_HopDongVay hdvay = new GUI_HopDongVay();
            if (!KiemTraFormActive(hdvay.Name))
            {
                hdvay.MdiParent = this;
                hdvay.Show();
            }
            else
            {
                ActiveFormCon(hdvay.Name);
            }
        }

        private void bbiHopDongTietKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_HopDongTietKiem hdtietkiem = new GUI_HopDongTietKiem();
            if (!KiemTraFormActive(hdtietkiem.Name))
            {
                hdtietkiem.MdiParent = this;
                hdtietkiem.Show();
            }
            else
            {
                ActiveFormCon(hdtietkiem.Name);
            }
        }

        private void bbiThongTinKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_KhachHang khachhang = new GUI_KhachHang();
            if (!KiemTraFormActive(khachhang.Name))
            {
                khachhang.MdiParent = this;
                khachhang.Show();
            }
            else
            {
                KiemTraFormActive(khachhang.Name);
            }
        }

        private void bbiTimKiemHopDongChoVay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_TimHopDongVay hdvay = new GUI_TimHopDongVay();
            if (!KiemTraFormActive(hdvay.Name))
            {
                hdvay.MdiParent = this;
                hdvay.Show();
            }
            else
            {
                KiemTraFormActive(hdvay.Name);
            }
        }

        private void bbiHopDongTheChap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_TimHDTheChap hdthechap = new GUI_TimHDTheChap();
            if (!KiemTraFormActive(hdthechap.Name))
            {
                hdthechap.MdiParent = this;
                hdthechap.Show();
            }
            else
            {
                KiemTraFormActive(hdthechap.Name);
            }
        }

        private void bbiHopDongGuiTietKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_TimHDTietKiem hdtietkiem = new GUI_TimHDTietKiem();
            if (!KiemTraFormActive(hdtietkiem.Name))
            {
                hdtietkiem.MdiParent = this;
                hdtietkiem.Show();
            }
            else
            {
                KiemTraFormActive(hdtietkiem.Name);
            }
        }

        private void bbiCapQuyenNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiLaiSuatVay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_LaiSuatVay lsvay = new GUI_LaiSuatVay();
            if (!KiemTraFormActive(lsvay.Name))
            {
                lsvay.MdiParent = this;
                lsvay.Show();
            }
            else
            {
                KiemTraFormActive(lsvay.Name);
            }
        }

        private void bbiLaiSuatGui_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_LaiSuatTietKiem lstietkiem = new GUI_LaiSuatTietKiem();
            if (!KiemTraFormActive(lstietkiem.Name))
            {
                lstietkiem.MdiParent = this;
                lstietkiem.Show();
            }
            else
            {
                KiemTraFormActive(lstietkiem.Name);
            }
        }

        private void bbiThemTaiKhoanNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_QuanLyTaiKhoanNV taikhoannv = new GUI_QuanLyTaiKhoanNV();
            if (!KiemTraFormActive(taikhoannv.Name))
            {
                taikhoannv.MdiParent = this;
                taikhoannv.Show();
            }
            else
            {
                KiemTraFormActive(taikhoannv.Name);
            }
        }

        private void bbiThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn đóng cửa sổ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                Application.Exit();
            }
        }

        private void bbiCacLoaiHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_frmReportHopDong rptHopDong = new GUI_frmReportHopDong();
            rptHopDong.Show();
        }

        private void bbiThongKeHopDongVay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_frmReportHopDongVay hdvay = new GUI_frmReportHopDongVay();
            hdvay.Show();
        }

        private void bbiThongKeHDTheChap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_frmThongKeHDTheChap hdthechap = new GUI_frmThongKeHDTheChap();
            hdthechap.Show();
        }

        private void bbiThongKeHDTietKiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_frmThongKeHDTietKiem hdtietkiem = new GUI_frmThongKeHDTietKiem();
            hdtietkiem.Show();
        }

        private void bbiPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bbiDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_DangNhap dangnhap = new GUI_DangNhap();
            dangnhap.MdiParent = this;
            dangnhap.Show();
        }
    }
}
