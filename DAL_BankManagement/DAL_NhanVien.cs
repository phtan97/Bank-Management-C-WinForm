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
    public class DAL_NhanVien : DAL_Connect
    {
        public DataTable TimKiemNhanVien(string timkiem)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_TimKiemNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_TimKiemNhanVien";
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
        public DataTable LayNhanVien()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongTinNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongTinNhanVien";
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
        public bool ThemNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThemNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThemNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", nv.MaNV);
                cmd.Parameters.AddWithValue("@honv", nv.Ho);
                cmd.Parameters.AddWithValue("@tennv", nv.Ten);
                cmd.Parameters.AddWithValue("@chucvu", nv.ChucVu);
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
        public bool XoaNhanVien(string manv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_XoaNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_XoaNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", manv);
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
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_SuaNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_SuaNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", nv.MaNV);
                cmd.Parameters.AddWithValue("@honv", nv.Ho);
                cmd.Parameters.AddWithValue("@tennv", nv.Ten);
                cmd.Parameters.AddWithValue("@chucvu", nv.ChucVu);
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
        public DataTable PhanTrang(int pageindex, int pagesize, out int recordcount)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_PhanTrangNhanVien", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_PhanTrangNhanVien";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter[] param =
                {
                    new SqlParameter("@pageSize",SqlDbType.Int),
                    new SqlParameter("@pageIndex",SqlDbType.Int),
                    new SqlParameter("@recordCount",SqlDbType.Int)
                };
                param[0].Value = pagesize;
                param[1].Value = pageindex;
                param[2].Direction = ParameterDirection.Output;
                cmd.Parameters.AddRange(param);
                DataTable dt = new DataTable("MaNV");
                dt.Columns.Add(new DataColumn("HoNV", typeof(string)));
                dt.Columns.Add(new DataColumn("TenNV", typeof(string)));
                dt.Columns.Add(new DataColumn("ChucVu", typeof(decimal)));
                da.Fill(dt);
                recordcount = (int)param[2].Value;
                return dt;
            }
            catch (Exception) { }
            finally
            {
                _conn.Close();
            }
            recordcount = 0;
            return null;
        }
    }
}
