using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BankManagement;

namespace BUS_BankManagement
{
    public class BUS_TinhToanLaiSuatVay
    {
        DAL_TinhToanLaiSuatVay dal_lsvay = new DAL_TinhToanLaiSuatVay();
        public DataTable DanhSachKhachHangVay()
        {
            return dal_lsvay.DanhSachMaKhachHangVay();
        }
        public DataTable ThongTinKhachHangVay(string makh)
        {
            return dal_lsvay.ThongTinKhachHangVay(makh);
        }
    }
}
