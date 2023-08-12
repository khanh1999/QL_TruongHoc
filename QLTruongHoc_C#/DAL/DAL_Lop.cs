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
    public class DAL_Lop
    {
        public static DataTable getData()
        {
            SqlConnection Conn = ConnectionString.getConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(); // Hoạt động như một cầu kết nối giữa Dataset/Datatable vào nguồn dữ liệu để truy xuất dữ liệu
            SqlCommand sqlCommand = new SqlCommand("getAllLopHoc1", Conn); // Dùng để truy vấn và cập nhật tới CSDL

            sqlCommand.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            dataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static bool insert(DTO_Lop lh)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "insert into LopHoc values (@MaL,@TenL,@SiSo,@GVCN,@GVToan,@GVLy,@GVHoa)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaL", SqlDbType.NChar).Value = lh.MaL;
                sqlCommand.Parameters.Add("@TenL", SqlDbType.NVarChar).Value = lh.TenL;
                sqlCommand.Parameters.Add("@SiSo", SqlDbType.Int).Value = lh.SiSo;
                sqlCommand.Parameters.Add("@GVCN", SqlDbType.NChar).Value = lh.GvCN;
                sqlCommand.Parameters.Add("@GVToan", SqlDbType.NChar).Value = lh.GvT;
                sqlCommand.Parameters.Add("@GVLy", SqlDbType.NChar).Value = lh.GvL;
                sqlCommand.Parameters.Add("@GVHoa", SqlDbType.NChar).Value = lh.GvH ;
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

        public static bool update(DTO_Lop lh)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "update LopHoc set TenL = @TenL, SiSo = @SiSo, GVCN = @GVCN, GVToan=@GVToan,GVLy=@GVLy,GVHoa=@GVHoa Where MaL=@MaL";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaL", SqlDbType.NChar).Value = lh.MaL;
                sqlCommand.Parameters.Add("@TenL", SqlDbType.NVarChar).Value = lh.TenL;
                sqlCommand.Parameters.Add("@SiSo", SqlDbType.Int).Value = lh.SiSo;
                sqlCommand.Parameters.Add("@GVCN", SqlDbType.NChar).Value = lh.GvCN;
                sqlCommand.Parameters.Add("@GVToan", SqlDbType.NChar).Value = lh.GvT;
                sqlCommand.Parameters.Add("@GVLy", SqlDbType.NChar).Value = lh.GvL;
                sqlCommand.Parameters.Add("@GVHoa", SqlDbType.NChar).Value = lh.GvH;
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
            string query = "delete LopHoc where MaL =@MaL";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaL", SqlDbType.NChar).Value = ma;
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
            string query = "select MaL as 'Mã Lớp',TenL as 'Tên Lớp',SiSo as 'Sỉ Số',GVCN,GVToan as 'GV Toán',GVLy as 'GV Lý',GVHoa as 'GV Hóa' from LopHoc";
            if (field != null || field.Length > 0)
            {
                query += " Where TenL like '%" + field + "%' ";
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
