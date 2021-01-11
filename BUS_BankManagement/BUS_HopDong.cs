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
    public class BUS_HopDong
    {
        DAL_HopDong dal_hopdong = new DAL_HopDong();
        public DataTable TimKiemHopDong(string timkiem)
        {
            return dal_hopdong.TimKiemHopDong(timkiem);
        }
        public DataTable LayDsHopDong()
        {
            return dal_hopdong.LayDsHopDong();
        }
        public bool ThemHopDong(DTO_HopDong hd)
        {
            return dal_hopdong.ThemHopDong(hd);
        }
        public bool XoaHopDong(string mahd)
        {
            return dal_hopdong.XoaHopDong(mahd);
        }
        public bool SuaHopDong(DTO_HopDong hd)
        {
            return dal_hopdong.SuaHopDong(hd);
        }
    }
}
