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
    public class DAL_HopDongTheChap:DAL_Connect
    {
        public DataTable ThongKeHopDongTheChap()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongKeHDTheChap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongKeHDTheChap";
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
        public DataTable ReportHDTheChap(string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ReportHopDongTheChap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ReportHopDongTheChap";
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
        public DataTable TimHDTheChap(string timkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_TimKiemHDTheChap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_TimKiemHDTheChap";
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
        public DataTable LayDsHopDong()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_DanhSachHDTheChap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_DanhSachHDTheChap";
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
        public bool ThemHopDong(DTO_TheChap thechap)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemHDTheChap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThemHDTheChap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", thechap.MaHD);
                cmd.Parameters.AddWithValue("@makh", thechap.MaKH);
                cmd.Parameters.AddWithValue("@loaits", thechap.LoaiTS);
                cmd.Parameters.AddWithValue("@giatrits", thechap.GiaTriTS);
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
                SqlCommand cmd = new SqlCommand("SP_XoaHDTheChap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_XoaHDTheChap";
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
        public bool SuaHopDong(DTO_TheChap thechap)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SuaHDTheChap", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_SuaHDTheChap";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", thechap.MaHD);
                cmd.Parameters.AddWithValue("@makh", thechap.MaKH);
                cmd.Parameters.AddWithValue("@loaits", thechap.LoaiTS);
                cmd.Parameters.AddWithValue("@giatrits", thechap.GiaTriTS);
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
