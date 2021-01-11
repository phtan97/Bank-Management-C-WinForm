using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_HopDongVay
    {
        string _MaHD;
        string _MaKH;
        decimal _SoTienVay;
        float _LaiSuat;
        DateTime _NgayVay;
        DateTime _NgayTra;
        string _MucDichVay;
        bool _TheChap = false;

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

        public decimal SoTienVay
        {
            get
            {
                return _SoTienVay;
            }

            set
            {
                _SoTienVay = value;
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

        public DateTime NgayVay
        {
            get
            {
                return _NgayVay;
            }

            set
            {
                _NgayVay = value;
            }
        }

        public DateTime NgayTra
        {
            get
            {
                return _NgayTra;
            }

            set
            {
                _NgayTra = value;
            }
        }

        public string MucDichVay
        {
            get
            {
                return _MucDichVay;
            }

            set
            {
                _MucDichVay = value;
            }
        }

        public bool TheChap
        {
            get
            {
                return _TheChap;
            }

            set
            {
                _TheChap = value;
            }
        }
        public DTO_HopDongVay() { }
        public DTO_HopDongVay(string mahd, string makh, decimal sotienvay, float laisuat, DateTime ngayvay, DateTime kyhan, string mucdichvay, bool thechap)
        {
            MaHD = mahd;
            MaKH = makh;
            SoTienVay = sotienvay;
            LaiSuat = laisuat;
            NgayVay = ngayvay;
            NgayTra = kyhan;
            MucDichVay = mucdichvay;
            TheChap = thechap;
        }
    }
}
