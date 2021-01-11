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
    public class DAL_QuanLyTaiKhoanNhanVien : DAL_Connect
    {
        public DataTable LayDsMaNV()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("LayDsMaNV", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "LayDsMaNV";
                cmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable TimKiemTaiKhoanNV(string timkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_TimKiemTaiKhoanNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_TimKiemTaiKhoanNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@timkiem", timkiem);
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
        public DataTable LayDsTaiKhoan()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongTinTaiKhoanNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongTinTaiKhoanNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
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
        public bool ThemTaiKhoan(DTO_TaiKhoanNV taikhoan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemTaiKhoanNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThemTaiKhoanNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", taikhoan.MaNV);
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan.TaiKhoan);
                cmd.Parameters.AddWithValue("@matkhau", taikhoan.MatKhau);
                cmd.Parameters.AddWithValue("@chucvu", taikhoan.ChucVu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool XoaTaiKhoan(string taikhoan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XoaTaiKhoanNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_XoaTaiKhoanNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tendangnhap", taikhoan);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool SuaNhanVien(DTO_TaiKhoanNV taikhoan)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SuaTaiKhoanNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_SuaTaiKhoanNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", taikhoan.MaNV);
                cmd.Parameters.AddWithValue("@taikhoan", taikhoan.TaiKhoan);
                cmd.Parameters.AddWithValue("@matkhau", taikhoan.MatKhau);
                cmd.Parameters.AddWithValue("@chucvu", taikhoan.ChucVu);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}

