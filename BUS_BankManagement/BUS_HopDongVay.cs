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
    public class BUS_HopDongVay
    {
        DAL_HopDongVay dal_hdvay = new DAL_HopDongVay();
        public DataTable ThongKeHopDongVay()
        {
            return dal_hdvay.ThongKeHopDongVay();
        }
        public DataTable ReportHDVay(string mahd)
        {
            return dal_hdvay.ReportHDVay(mahd);
        }
        public DataTable  DsHDTheoLoaiHD(string loaihd)
        {
            return dal_hdvay.DsHDTheoLoaiHD(loaihd);
        }
        public DataTable TimKiemHDVay(string timkiem)
        {
            if(dal_hdvay.TimKiemHDVay(timkiem) == null)
            {
                return null;
            }
            else
            {
                return dal_hdvay.TimKiemHDVay(timkiem);
            }
        }
        public DataTable LayDsHopDong()
        {
            return dal_hdvay.DanhSachHopDongVay();
        }
        public DataTable LayDsMaHD()
        {
            return dal_hdvay.DanhSachMaHD();
        }
        public DataTable LayDsMaKH()
        {
            return dal_hdvay.DanhSachMaKH();
        }
        public bool ThemHopDongVay(DTO_HopDongVay hdvay)
        {
            if(hdvay.TheChap == true)
            {
                hdvay.TheChap = Convert.ToBoolean(1);
            }
            else
            {
                hdvay.TheChap = Convert.ToBoolean(0);
            }
            return dal_hdvay.ThemHopDongVay(hdvay);
        }
        public bool XoaHopDongVay(string mahd)
        {
            return dal_hdvay.XoaHopDongVay(mahd);
        }
        public bool SuaHopDongVay(DTO_HopDongVay hdvay)
        {
            return dal_hdvay.SuaHopDongVay(hdvay);
        }
    }
}
