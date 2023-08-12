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
    public class DAL_GiaoVien
    {

        public static DataTable getData()
        {
            SqlConnection Conn = ConnectionString.getConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(); // Hoạt động như một cầu kết nối giữa Dataset/Datatable vào nguồn dữ liệu để truy xuất dữ liệu
            SqlCommand sqlCommand = new SqlCommand("getAllGiaoVien", Conn); // Dùng để truy vấn và cập nhật tới CSDL

            sqlCommand.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            dataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static bool insert(DTO_GiaoVien gv)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "insert into ToMon values (@MaGV,@ChuyenMon,@ChucVu,@MaToTruong)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaGV", SqlDbType.NChar).Value = gv.MaGV;
                sqlCommand.Parameters.Add("@ChuyenMon", SqlDbType.NVarChar).Value = gv.ChuyenMon;
                sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NChar).Value = gv.ChucVu;
                sqlCommand.Parameters.Add("@MaToTruong", SqlDbType.NChar).Value = gv.MaTT;
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

        public static bool update(DTO_GiaoVien gv)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "update ToMon set ChuyenMon = @ChuyenMon, ChucVu = @ChucVu, MaToTruong = @MaToTruong Where MaGV=@MaGV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaGV", SqlDbType.NChar).Value = gv.MaGV;
                sqlCommand.Parameters.Add("@ChuyenMon", SqlDbType.NVarChar).Value = gv.ChuyenMon;
                sqlCommand.Parameters.Add("@ChucVu", SqlDbType.NChar).Value = gv.ChucVu;
                sqlCommand.Parameters.Add("@MaToTruong", SqlDbType.NChar).Value = gv.MaTT;
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
            string query = "delete ToMon where MaGV =@MaGV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaGV", SqlDbType.NChar).Value = ma;
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

        public static DataTable LookUp(string field)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = "select MaGV As 'Mã Giáo viên', HoTen AS 'Họ Tên', ChuyenMon as 'Chuyên môn', ChucVu As 'Chức vụ', MaToTruong as 'Mã Tổ trưởng' from NhanVien, ToMon";
            if (field != null  || field.Length > 0)
            {
                query += " Where NhanVien.MaNV = ToMon.MaGV and ChuyenMon like '%" + field + "%' ";
            }
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
