using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        private string _maL;
        private string _tenL;
        private int _siSo;
        private string _gvCN;
        private string _gvT;
        private string _gvL;
        private string _gvH;

        public DTO_Lop(string maL, string tenL, int siSo, string gvCN, string gvT, string gvL, string gvH)
        {
            _maL = maL;
            _tenL = tenL;
            _siSo = siSo;
            _gvCN = gvCN;
            _gvT = gvT;
            _gvL = gvL;
            _gvH = gvH;
        }

        public string MaL { get { return _maL; } set { _maL = value; } }
        public string TenL { get { return _tenL; } set { _tenL = value; } }
        public int SiSo { get { return _siSo; } set { _siSo = value; } }
        public string GvCN { get { return _gvCN; } set { _gvCN = value; } }
        public string GvT { get { return _gvT; } set { _gvT = value; } }
        public string GvL { get { return _gvL; } set { _gvL = value; } }
        public string GvH { get { return _gvH; } set { _gvH = value; } }
    }
}
