using DAL_BankManagement;
using DTO_BankManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BankManagement
{
    public class BUS_HopDongTietKiem
    {
        DAL_HopDongTietKiem dal_hdtietkiem = new DAL_HopDongTietKiem();
        public DataTable ThongKeHopDongTietKiem()
        {
            return dal_hdtietkiem.ThongKeHopDongTietKiem();
        }
        public DataTable DsHDTheoLoaiHD(string loaihd)
        {
            return dal_hdtietkiem.DsHDTheoLoaiHD(loaihd);
        }
        public DataTable ReportHDTietKiem(string mahd)
        {
            return dal_hdtietkiem.ReportHDTietKiem(mahd);
        }
        public DataTable TimKiemHDTietKiem(string timkiem)
        {
            if (dal_hdtietkiem.TimKiemHDTietKiem(timkiem) == null)
            {
                return null;
            }
            else
            {
                return dal_hdtietkiem.TimKiemHDTietKiem(timkiem);
            }
        }
        public DataTable LayDsMaHD()
        {
            return dal_hdtietkiem.DanhSachMaHD();
        }
        public DataTable LayDsMaKH()
        {
            return dal_hdtietkiem.DanhSachMaKH();
        }
        public DataTable LayDsHopDong()
        {
            return dal_hdtietkiem.LayDsHopDong();
        }
        public bool ThemHopDong(DTO_HopDongTietKiem hdtietkiem)
        {
            return dal_hdtietkiem.ThemHopDong(hdtietkiem);
        }
        public bool XoaHopDong(string mahd)
        {
            return dal_hdtietkiem.XoaHopDong(mahd);
        }
        public bool SuaHopDong(DTO_HopDongTietKiem hdtietkiem)
        {
            return dal_hdtietkiem.SuaHopDong(hdtietkiem);
        }
    }
}
