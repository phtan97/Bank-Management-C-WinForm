using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BankManagement;
using System.Data;

namespace BUS_BankManagement
{
    public class BUS_TinhToanLaiSuatGuiTietKiem
    {
        DAL_TinhToanLaiSuatGuiTietKiem dal_lstietkiem = new DAL_TinhToanLaiSuatGuiTietKiem();
        public DataTable DanhSachKhachHangGuiTietKiem()
        {
            return dal_lstietkiem.DanhSachMaKhachHangGuiTietKiem();
        }
        public DataTable ThongTinKhachHangGuiTietKiem(string makh)
        {
            return dal_lstietkiem.ThongTinKhachHangGuiTietKiem(makh);
        }
    }
}
