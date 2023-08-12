using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhongBan
    {
        private string _maPB;
        private string _tenPB;

        public DTO_PhongBan(string maPB, string tenPB)
        {
            _maPB = maPB;
            _tenPB = tenPB;        
        }

        public string MaPB { get { return _maPB; } set { _maPB = value; } }
        public string TenPB { get { return _tenPB; } set { _tenPB = value; } }
    }
}
