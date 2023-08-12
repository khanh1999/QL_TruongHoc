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
    public class DAL_NhanVien
    {
        public static DataTable getData()
        {
            SqlConnection Conn = ConnectionString.getConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(); // Hoạt động như một cầu kết nối giữa Dataset/Datatable vào nguồn dữ liệu để truy xuất dữ liệu
            SqlCommand sqlCommand = new SqlCommand("getAllNhanVien",Conn); // Dùng để truy vấn và cập nhật tới CSDL

            sqlCommand.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            dataAdapter.SelectCommand = sqlCommand;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static bool insert(DTO_NhanVien nv)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "insert into NhanVien values (@MaNV,@HoTen,@NgaySinh,@GioiTinh,@SDT,@PhongBan)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NChar).Value = nv.MaNV;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.Char).Value = nv.Sdt;
                sqlCommand.Parameters.Add("@PhongBan", SqlDbType.NChar).Value = nv.PhongBan;
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

        public static bool update(DTO_NhanVien nv)
        {
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = ConnectionString.getConnection();
            string query = "update NhanVien set HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDT =@SDT, PhongBan =@PhongBan Where MaNV=@MaNV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NChar).Value = nv.MaNV;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = nv.HoTen;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.Char).Value = nv.Sdt;
                sqlCommand.Parameters.Add("@PhongBan", SqlDbType.NChar).Value = nv.PhongBan;
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
            string query = "delete NhanVien where MaNV =@MaNV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NChar).Value = ma;
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
            string query = "select MaNV,HoTen,NgaySinh,GioiTinh,SDT,TenPB from NhanVien, PhongBan";
            if (field != null || field.Length > 0)
            {
                query += " Where NhanVien.PhongBan = PhongBan.MaPB and HoTen like '%" + field + "%'";
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

        public static DataTable LookUpGV()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = "select MaNV as 'Mã NV',HoTen as 'Họ Tên',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',SDT,TenPB as 'Phòng Ban', ChuyenMon as 'Chuyên Môn' from NhanVien, PhongBan, ToMon where NhanVien.PhongBan = PhongBan.MaPB and NhanVien.MaNV = ToMon.MaGV";
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static DataTable LookUpBV()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = "select MaNV as 'Mã NV',HoTen as 'Họ Tên',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',SDT,TenPB as 'Phòng Ban' from NhanVien, PhongBan where NhanVien.PhongBan = PhongBan.MaPB and MaPB = 'BV'";
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static DataTable LookUpGVBM()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = "select MaNV as 'Mã NV',HoTen as 'Họ Tên',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',SDT,ChucVu as 'Chức Vụ', ChuyenMon as 'Chuyên Môn' from NhanVien, PhongBan, ToMon where NhanVien.PhongBan = PhongBan.MaPB and NhanVien.MaNV = ToMon.MaGV and  ChucVu = N'Giáo viên bộ môn'";
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static DataTable LookUpLD()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = "select MaNV as 'Mã NV',HoTen as 'Họ Tên',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',SDT,ChucVu as 'Chức Vụ', ChuyenMon as 'Chuyên Môn' from NhanVien, PhongBan, ToMon where NhanVien.PhongBan = PhongBan.MaPB and NhanVien.MaNV = ToMon.MaGV and  ChucVu in (N'Hiệu trưởng',N'Hiệu phó',N'Tổ trưởng')";
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static DataTable LookUpGVCN()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = "select MaNV as 'Mã NV',HoTen as 'Họ Tên',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',SDT, ChuyenMon as 'Chuyên Môn',TenL as 'Lớp Phụ Trách' from NhanVien, ToMon, LopHoc where NhanVien.MaNV = ToMon.MaGV and NhanVien.MaNV=LopHoc.GVCN";
            using (SqlConnection sqlConnection = ConnectionString.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }

        public static DataTable LookUpLC()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string query = "select MaNV as 'Mã NV',HoTen as 'Họ Tên',NgaySinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',SDT,TenPB as 'Phòng Ban' from NhanVien, PhongBan where NhanVien.PhongBan = PhongBan.MaPB and MaPB = 'LC'";
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
