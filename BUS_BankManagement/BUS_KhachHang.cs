using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BankManagement;
using System.Data;
using DTO_BankManagement;

namespace BUS_BankManagement
{
    public class BUS_KhachHang
    {
        DAL_KhachHang khachhang = new DAL_KhachHang();
        public DataTable TimKiemKhachHang(string timkiem)
        {
            return khachhang.TimKiemKhachHang(timkiem);
        }
        public DataTable LayDsKhachHang()
        {
            return khachhang.LayDsKhachHang();
        }
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            return khachhang.ThemKhachHang(kh);
        }
        public bool XoaKhachHang(string makh)
        {
            return khachhang.XoaKhachHang(makh);
        }
        public bool SuaKhachHang(DTO_KhachHang kh)
        {
            return khachhang.SuaKhachHang(kh);
        }
    }
}
