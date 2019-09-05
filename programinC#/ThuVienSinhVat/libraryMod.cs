using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSinhVat
{
    class libraryMod
    {
        ConnectToSql con = new ConnectToSql();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()  //lấy dữ liệu
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from ThuVienSV";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        public bool AddData(string ten, string loai, string soluong, string mota, string usercapnhap) //them du lieu
        {
            cmd.CommandText = "Insert into ThuVienSV(ten,loai,soluong,mota,usercapnhap) values (N'" +ten+"',N'"+loai+"',N'"+soluong+"',N'"+mota+"','"+usercapnhap+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool UpdData(string ten, string loai, string soluong, string mota, string usercapnhap, int id) //sua du lieu
        {
            cmd.CommandText = "Update thuviensv set ten = N'" +ten + "',loai = N'" + loai + "',soluong = N'" + soluong + "', mota = N'" + mota+ "',usercapnhap ='" + usercapnhap+ "' where id ="+id;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(string ma) //xoa du lieu
        {
            cmd.CommandText = "Delete from thuviensv Where id = '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public DataTable searchData(string ten) // tim kiem
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from thuviensv where ten like N'%"+ten+"%'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
    }
}
