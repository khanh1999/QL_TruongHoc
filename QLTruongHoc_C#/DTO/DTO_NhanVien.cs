using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private string _maNV;
        private string _hoTen;
        private DateTime _ngaySinh;
        private string _gioiTinh;
        private string _sdt;
        private string _phongBan;

        public DTO_NhanVien(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string sdt, string phongBan)
        {
            _maNV = maNV;
            _hoTen = hoTen;
            _ngaySinh = ngaySinh;
            _gioiTinh = gioiTinh;
            _sdt = sdt;
            _phongBan = phongBan;        
        }

        public string MaNV { get { return _maNV; } set { _maNV = value; } }
        public string HoTen { get { return _hoTen; } set { _hoTen = value; } }
        public DateTime NgaySinh { get { return _ngaySinh; } set { _ngaySinh = value; } }
        public string GioiTinh { get { return _gioiTinh; } set { _gioiTinh = value; } }
        public string Sdt { get { return _sdt; } set { _sdt = value; } }
        public string PhongBan { get { return _phongBan; } set { _phongBan = value; } }
    }
}
