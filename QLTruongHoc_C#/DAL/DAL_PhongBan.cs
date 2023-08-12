using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_PhongBan
    {
        public static DataTable getData()
        {
            SqlConnection Conn = ConnectionString.getConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(); // Hoạt động như một cầu kết nối giữa Dataset/Datatable vào nguồn dữ liệu để truy xuất dữ liệu
            SqlCommand sqlCommand = new SqlCommand("getAllPhongBan", Conn); // Dùng để truy vấn và cập nhật tới CSDL

            sqlCommand.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            dataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static bool insert(DTO_PhongBan pb)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "insert into PhongBan values (@MaPB,@TenPB)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPB", SqlDbType.NChar).Value = pb.MaPB;
                sqlCommand.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = pb.TenPB;
                sqlCommand.ExecuteNonQuery(); // Thực thi lệnh truy vấn
            }
            catch //Nếu có lỗi trả về false
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public static bool update(DTO_PhongBan pb)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "update PhongBan set TenPB = @TenPB Where MaPB=@MaPB";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPB", SqlDbType.NChar).Value = pb.MaPB;
                sqlCommand.Parameters.Add("@TenPB", SqlDbType.NVarChar).Value = pb.TenPB;
                sqlCommand.ExecuteNonQuery(); // Thực thi lệnh truy vấn
            }
            catch //Nếu có lỗi trả về false
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public static bool delete(string ma)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "delete PhongBan where MaPB =@MaPB";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaPB", SqlDbType.NChar).Value = ma;
                sqlCommand.ExecuteNonQuery(); // Thực thi lệnh truy vấn
            }
            catch //Nếu có lỗi trả về false
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}