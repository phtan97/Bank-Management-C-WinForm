using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BankManagement
{
    public class DAL_TinhToanLaiSuatVay:DAL_Connect
    {
        public DataTable DanhSachMaKhachHangVay()
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_DanhSachKhachHangVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_DanhSachKhachHangVay";
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
        public DataTable ThongTinKhachHangVay(string makh)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("SP_ThongTinKhachHangVay", _conn);
                cmd.Connection = _conn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandText = "SP_ThongTinKhachHangVay";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makh",makh);
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
