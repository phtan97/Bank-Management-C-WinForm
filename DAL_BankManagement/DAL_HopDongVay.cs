using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BankManagement;
using System.Data;
using System.Data.SqlClient;

namespace DAL_BankManagement
{
    public class DAL_HopDongVay:DAL_Connect
    {
        public DataTable ThongKeHopDongVay()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongKeHDVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongKeHDVay";
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
        public DataTable TimKiemHDVay(string timkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_TimKiemHDVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_TimKiemHDVay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@timkiem", timkiem);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count == 0)
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
        public DataTable ReportHDVay(string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ReportHopDongVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ReportHopDongVay";
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
        public DataTable DanhSachHopDongVay()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_DanhSachHopDongVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_DanhSachHopDongVay";
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
        public bool ThemHopDongVay(DTO_HopDongVay hdvay)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemHopDongVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThemHopDongVay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", hdvay.MaHD);
                cmd.Parameters.AddWithValue("@makh", hdvay.MaKH);
                cmd.Parameters.AddWithValue("@sotienvay", hdvay.SoTienVay);
                cmd.Parameters.AddWithValue("@laisuat", hdvay.LaiSuat);
                cmd.Parameters.AddWithValue("@ngayvay", hdvay.NgayVay);
                cmd.Parameters.AddWithValue("@ngaytra", hdvay.NgayTra);
                cmd.Parameters.AddWithValue("@mucdichvay", hdvay.MucDichVay);
                cmd.Parameters.AddWithValue("@thechap", hdvay.TheChap);
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
        public bool XoaHopDongVay(string mahd)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XoaHopDongVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_XoaHopDongVay";
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
        public bool SuaHopDongVay(DTO_HopDongVay hdvay)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SuaHopDongVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_SuaHopDongVay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mahd", hdvay.MaHD);
                cmd.Parameters.AddWithValue("@makh", hdvay.MaKH);
                cmd.Parameters.AddWithValue("@sotienvay", hdvay.SoTienVay);
                cmd.Parameters.AddWithValue("@laisuat", hdvay.LaiSuat);
                cmd.Parameters.AddWithValue("@ngayvay", hdvay.NgayVay);
                cmd.Parameters.AddWithValue("@ngaytra", hdvay.NgayTra);
                cmd.Parameters.AddWithValue("@mucdichvay", hdvay.MucDichVay);
                cmd.Parameters.AddWithValue("@thechap", hdvay.TheChap);
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
