using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BankManagement;
using DTO_BankManagement;
using System.Data;

namespace BUS_BankManagement
{
    public class BUS_QuanLyTaiKhoanNhanVien
    {
        DAL_QuanLyTaiKhoanNhanVien dal_taikhoan = new DAL_QuanLyTaiKhoanNhanVien();
        public DataTable LayDsMaNV()
        {
            return dal_taikhoan.LayDsMaNV();
        }
        public DataTable LayDsTaiKhoan()
        {
            return dal_taikhoan.LayDsTaiKhoan();
        }
        public DataTable TimKiemTaiKhoanNV(string timkiem)
        {
            return dal_taikhoan.TimKiemTaiKhoanNV(timkiem);
        }
        public bool ThemTaiKhoan(DTO_TaiKhoanNV taikhoan)
        {
            return dal_taikhoan.ThemTaiKhoan(taikhoan);
        }
        public bool XoaNhanVien(string taikhoan)
        {
            return dal_taikhoan.XoaTaiKhoan(taikhoan);
        }
        public bool SuaNhanVien(DTO_TaiKhoanNV taikhoan)
        {
            return dal_taikhoan.SuaNhanVien(taikhoan);
        }
    }
}
