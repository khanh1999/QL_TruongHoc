using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_GiaoVien
    {
        public static DataTable GetAllGiaoVien()
        {
            return DAL_GiaoVien.getData();
        }

        public static bool insertGV(DTO_GiaoVien gv)
        {
            return DAL_GiaoVien.insert(gv);
        }

        public static bool updateGV(DTO_GiaoVien gv)
        {
            return DAL_GiaoVien.update(gv);
        }

        public static bool deleteGV(string ma)
        {
            return DAL_GiaoVien.delete(ma);
        }

        public static DataTable LookUpGV(string field)
        {
            return DAL_GiaoVien.LookUp(field);
        }
    }
}
