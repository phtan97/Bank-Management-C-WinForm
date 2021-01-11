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
    public class DAL_KhachHang : DAL_Connect
    {
        public DataTable TimKiemKhachHang(string timkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_TimKiemKhachHang", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_TimKiemKhachHang";
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
        public DataTable LayDsKhachHang()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongTinKhachHang", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongTinKhachHang";
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
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemKhachHang", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThemKhachHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", kh.MaKH);
                cmd.Parameters.AddWithValue("@hokh", kh.HoKH);
                cmd.Parameters.AddWithValue("@tenkh", kh.TenKH);
                cmd.Parameters.AddWithValue("@ngaysinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@dantoc", kh.DanToc);
                cmd.Parameters.AddWithValue("@cmnd", kh.CMND);
                cmd.Parameters.AddWithValue("@ngaycap", kh.NgayCap);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@email", kh.Email);
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
        public bool XoaKhachHang(string makh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XoaKhachHang", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_XoaKhachHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", makh);
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
        public bool SuaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SuaKhachHang", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_SuaKhachHang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh", kh.MaKH);
                cmd.Parameters.AddWithValue("@hokh", kh.HoKH);
                cmd.Parameters.AddWithValue("@tenkh", kh.TenKH);
                cmd.Parameters.AddWithValue("@ngaysinh", kh.NgaySinh);
                cmd.Parameters.AddWithValue("@gioitinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@dantoc", kh.DanToc);
                cmd.Parameters.AddWithValue("@cmnd", kh.CMND);
                cmd.Parameters.AddWithValue("@ngaycap", kh.NgayCap);
                cmd.Parameters.AddWithValue("@diachi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@email", kh.Email);
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
