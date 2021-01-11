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
    public class BUS_HopDongTheChap
    {
        DAL_HopDongTheChap dal_hdthechap = new DAL_HopDongTheChap();
        public DataTable ThongKeHopDongTheChap()
        {
            return dal_hdthechap.ThongKeHopDongTheChap();
        }
        public DataTable ReportHDTheChap(string mahd)
        {
            return dal_hdthechap.ReportHDTheChap(mahd);
        }
        public DataTable TimHDTheChap(string timkiem)
        {
            if (dal_hdthechap.TimHDTheChap(timkiem) == null)
            {
                return null;
            }
            else
            {
                return dal_hdthechap.TimHDTheChap(timkiem);
            }
        }
        public DataTable LayDsMaHD()
        {
            return dal_hdthechap.DanhSachMaHD();
        }
        public DataTable LayDsMaKH()
        {
            return dal_hdthechap.DanhSachMaKH();
        }
        public DataTable LayDsHopDong()
        {
            return dal_hdthechap.LayDsHopDong();
        }
        public bool ThemHopDong(DTO_TheChap tc)
        {
            return dal_hdthechap.ThemHopDong(tc);
        }
        public bool XoaHopDong(string mahd)
        {
            return dal_hdthechap.XoaHopDong(mahd);
        }
        public bool SuaHopDong(DTO_TheChap tc)
        {
            return dal_hdthechap.SuaHopDong(tc);
        }
    }
}

