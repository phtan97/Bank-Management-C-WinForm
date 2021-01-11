using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_TheChap
    {
        string _MaHD;
        string _MaKH;
        string _LoaiTS;
        decimal _GiaTriTS;

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

        public string LoaiTS
        {
            get
            {
                return _LoaiTS;
            }

            set
            {
                _LoaiTS = value;
            }
        }

        public decimal GiaTriTS
        {
            get
            {
                return _GiaTriTS;
            }

            set
            {
                _GiaTriTS = value;
            }
        }
        public DTO_TheChap() { }
        public DTO_TheChap(string mahd, string makh, string loaits, decimal giatrits)
        {
            MaHD = mahd;
            MaKH = makh;
            LoaiTS = loaits;
            GiaTriTS = giatrits;
        }
    }
}
