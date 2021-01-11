using DTO_BankManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BankManagement
{
    public class DAL_HopDongTietKiem:DAL_Connect
    {
        public DataTable ThongKeHopDongTietKiem()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongKeHDTietKiem", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongKeHDTietKiem";
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
        public DataTable DsHDTheoLoaiHD(string loaihd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_DsHDTheoLoaiHD", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_DsHDTheoLoaiHD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loaihd", loaihd);
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
        public DataTable TimKiemHDTietKiem(string timkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_TimKiemHDTietKiem", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_TimKiemHDTietKiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@timkiem", timkiem);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    return dt;
                }
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public DataTable ReportHDTietKiem(string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ReportHDTietKiem", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ReportHDTietKiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", mahd);
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
        public DataTable LayDsHopDong()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_DanhSachHDTietKiem", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_DanhSachHDTietKiem";
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
        public DataTable DanhSachMaHD()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_LayMaHD", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_LayMaHD";
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
        public DataTable DanhSachMaKH()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_LayMaKH", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_LayMaKH";
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
        public bool ThemHopDong(DTO_HopDongTietKiem hdtietkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemHDTietKiem", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThemHDTietKiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", hdtietkiem.MaHD);
                cmd.Parameters.AddWithValue("@makh", hdtietkiem.MaKH);
                cmd.Parameters.AddWithValue("@sotiengui", hdtietkiem.SoTienGui);
                cmd.Parameters.AddWithValue("@ngaygui", hdtietkiem.NgayGui);
                cmd.Parameters.AddWithValue("@kyhan", hdtietkiem.KyHan);
                cmd.Parameters.AddWithValue("@laisuat", hdtietkiem.LaiSuat);
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
        public bool XoaHopDong(string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XoaHDTietKiem", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_XoaHDTietKiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", mahd);
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
        public bool SuaHopDong(DTO_HopDongTietKiem hdtietkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SuaHDTietKiem", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_SuaHDTietKiem";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", hdtietkiem.MaHD);
                cmd.Parameters.AddWithValue("@makh", hdtietkiem.MaKH);
                cmd.Parameters.AddWithValue("@sotiengui", hdtietkiem.SoTienGui);
                cmd.Parameters.AddWithValue("@ngaygui", hdtietkiem.NgayGui);
                cmd.Parameters.AddWithValue("@kyhan", hdtietkiem.KyHan);
                cmd.Parameters.AddWithValue("@laisuat", hdtietkiem.LaiSuat);
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
