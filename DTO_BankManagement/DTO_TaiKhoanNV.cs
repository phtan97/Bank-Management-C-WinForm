using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_TaiKhoanNV
    {
        string _MaNV;
        string _TaiKhoan;
        string _MatKhau;
        string _ChucVu;

        public string MaNV
        {
            get
            {
                return _MaNV;
            }

            set
            {
                _MaNV = value;
            }
        }

        public string TaiKhoan
        {
            get
            {
                return _TaiKhoan;
            }

            set
            {
                _TaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }

            set
            {
                _MatKhau = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return _ChucVu;
            }

            set
            {
                _ChucVu = value;
            }
        }
        public DTO_TaiKhoanNV() { }
        public DTO_TaiKhoanNV(string manv, string taikhoan, string matkhau, string chucvu)
        {
            MaNV = manv;
            TaiKhoan = taikhoan;
            MatKhau = matkhau;
            ChucVu = chucvu;
        }
    }
}
