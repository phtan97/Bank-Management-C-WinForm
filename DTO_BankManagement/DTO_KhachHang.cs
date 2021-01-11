using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_KhachHang
    {
        string _MaKH;
        string _HoKH;
        string _TenKH;
        DateTime _NgaySinh;
        string _GioiTinh;
        string _DanToc;
        string _CMND;
        DateTime _NgayCap;
        string _DiaChi;
        string _Email;

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

        public string HoKH
        {
            get
            {
                return _HoKH;
            }

            set
            {
                _HoKH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return _TenKH;
            }

            set
            {
                _TenKH = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return _NgaySinh;
            }

            set
            {
                _NgaySinh = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return _GioiTinh;
            }

            set
            {
                _GioiTinh = value;
            }
        }

        public string DanToc
        {
            get
            {
                return _DanToc;
            }

            set
            {
                _DanToc = value;
            }
        }

        public string CMND
        {
            get
            {
                return _CMND;
            }

            set
            {
                _CMND = value;
            }
        }

        public DateTime NgayCap
        {
            get
            {
                return _NgayCap;
            }

            set
            {
                _NgayCap = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }

            set
            {
                _DiaChi = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }
        public DTO_KhachHang() { }
        public DTO_KhachHang(string makh, string hokh, string tenkh, DateTime ngaysinh, string gioitinh, string dantoc, string cmnd, DateTime ngaycap, string diachi, string email)
        {
            MaKH = makh;
            HoKH = hokh;
            TenKH = tenkh;
            NgaySinh = ngaysinh;
            GioiTinh = gioitinh;
            DanToc = dantoc;
            CMND = cmnd;
            NgayCap = ngaycap;
            DiaChi = diachi;
            Email = email;
        }
    }
}
