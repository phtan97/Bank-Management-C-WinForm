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
    public class BUS_NhanVien
    {
        DAL_NhanVien nhanvien = new DAL_NhanVien();
        public DataTable TimKiemNhanVien(string timkiem)
        {
            return nhanvien.TimKiemNhanVien(timkiem);
        }
        public DataTable LayNhanVien()
        {
            return nhanvien.LayNhanVien();
        }
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            return nhanvien.ThemNhanVien(nv);
        }
        public bool XoaNhanVien(string manv)
        {
            return nhanvien.XoaNhanVien(manv);
        }
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            return nhanvien.SuaNhanVien(nv);
        }
        public DataTable PhanTrang(int pageindex, int pagesize, out int recordcount)
        {
            return nhanvien.PhanTrang(pageindex, pagesize, out recordcount);
        }
    }
}
