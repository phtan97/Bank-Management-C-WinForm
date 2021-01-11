using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_HopDong
    {
        string _MaHD;
        string _LoaiHD;

        public string MaHD
        {
            get
            {
                return _MaHD;
            }

            set
            {
                _MaHD = value;
            }
        }

        public string LoaiHD
        {
            get
            {
                return _LoaiHD;
            }

            set
            {
                _LoaiHD = value;
            }
        }
        public DTO_HopDong() { }
        public DTO_HopDong(string mahd, string loaihd)
        {
            MaHD = mahd;
            LoaiHD = loaihd;
        }
    }
}
