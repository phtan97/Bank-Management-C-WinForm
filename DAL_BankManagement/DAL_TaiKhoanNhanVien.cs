using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BankManagement;

namespace DAL_BankManagement
{
   public class DAL_TaiKhoanNhanVien:DAL_Connect
    {
        public DataTable DoiMatKhau(string taikhoan, string matkhau)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_DoiMatKhau", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_DoiMatKhau";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public DataTable ThongTinDangNhap(string taikhoan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongTinDangNhap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongTinDangNhap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public DataTable DangNhap(DTO_DangNhap dangnhap)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongTinTaiKhoanNV", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongTinTaiKhoanNV";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tendangnhap", dangnhap.TaiKhoan);
                cmd.Parameters.AddWithValue("@matkhau", dangnhap.MatKhau);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            return null;
        }
    }
}
