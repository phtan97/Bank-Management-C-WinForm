using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BankManagement
{
    public class DTO_NhanVien
    {
        private string _MaNV;
        private string _Ho;
        private string _Ten;
        private string _ChucVu;

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

        public string Ho
        {
            get
            {
                return _Ho;
            }

            set
            {
                _Ho = value;
            }
        }

        public string Ten
        {
            get
            {
                return _Ten;
            }

            set
            {
                _Ten = value;
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
        public DTO_NhanVien() { }
        public DTO_NhanVien(string manv, string ho, string ten, string chucvu)
        {
            MaNV = manv;
            Ho = ho;
            Ten = ten;
            ChucVu = chucvu;
        }
    }
}
