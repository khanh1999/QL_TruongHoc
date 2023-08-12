using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiaoVien
    {
        private string _maGV;
        private string _chuyenMon;
        private string _chucVu;
        private string _maTT;

        public DTO_GiaoVien(string maGV, string chuyenMon, string chucVu, string maTT)
        {
            _maGV = maGV;
            _chuyenMon = chuyenMon;
            _chucVu = chucVu;
            _maTT = maTT;
        }

        public string MaGV { get { return _maGV; } set { _maGV = value; } }
        public string ChuyenMon { get { return _chuyenMon; } set { _chuyenMon = value; } }
        public string ChucVu { get { return _chucVu; } set { _chucVu = value; } }
        public string MaTT { get { return _maTT; } set { _maTT = value; } }
    }
}
