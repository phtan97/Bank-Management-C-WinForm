using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_HopDongTietKiem
    {
        string _MaHD;
        string _MaKH;
        decimal _SoTienGui;
        DateTime _NgayGui;
        DateTime _KyHan;
        float _LaiSuat;

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

        public string MaKH
        {
            get
            {
                return _MaKH;
            }

            set
            {
                _MaKH = value;
            }
        }

        public decimal SoTienGui
        {
            get
            {
                return _SoTienGui;
            }

            set
            {
                _SoTienGui = value;
            }
        }

        public DateTime NgayGui
        {
            get
            {
                return _NgayGui;
            }

            set
            {
                _NgayGui = value;
            }
        }

        public DateTime KyHan
        {
            get
            {
                return _KyHan;
            }

            set
            {
                _KyHan = value;
            }
        }

        public float LaiSuat
        {
            get
            {
                return _LaiSuat;
            }

            set
            {
                _LaiSuat = value;
            }
        }
        public DTO_HopDongTietKiem() { }
        public DTO_HopDongTietKiem(string mahd, string makh, decimal sotiengui, DateTime ngaygui, DateTime kyhan, float laisuat)
        {
            MaHD = mahd;
            MaKH = makh;
            SoTienGui = sotiengui;
            NgayGui = ngaygui;
            KyHan = kyhan;
            LaiSuat = laisuat;
        }
    }
}
