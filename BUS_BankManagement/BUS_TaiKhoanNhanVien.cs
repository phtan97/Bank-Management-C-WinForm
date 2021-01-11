using DAL_BankManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BankManagement;

namespace BUS_BankManagement
{
    public class BUS_TaiKhoanNhanVien
    {
        public int ID_User = 0;
        DAL_TaiKhoanNhanVien dal = new DAL_TaiKhoanNhanVien();
        public bool DangNhap(DTO_DangNhap dangnhap)
        {            
            DataTable dt = dal.DangNhap(dangnhap);
            foreach (DataRow dr in dt.Rows)
            {
                if (dangnhap.TaiKhoan == dr["TenDangNhap"].ToString() && dangnhap.MatKhau == dr["Matkhau"].ToString())
                {
                    ID_User = int.Parse(dr["ChucVu"].ToString());
                    return true;
                }
            }
            return false;
        }
        public DataTable ThongTinDangNhap(string taikhoan)
        {
            return dal.ThongTinDangNhap(taikhoan);
        }
        public DataTable DoiMatKhau(string taikhoan, string matkhau)
        {
            return dal.DoiMatKhau(taikhoan, matkhau);
        }
    }
}
