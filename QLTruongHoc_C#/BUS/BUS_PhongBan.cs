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
    public class BUS_PhongBan
    {
        public static DataTable GetAllPhongBan()
        {
            return DAL_PhongBan.getData();
        }

        public static bool insertPB(DTO_PhongBan pb)
        {
            return DAL_PhongBan.insert(pb);
        }

        public static bool updatePB(DTO_PhongBan pb)
        {
            return DAL_PhongBan.update(pb);
        }

        public static bool deletePB(string ma)
        {
            return DAL_PhongBan.delete(ma);
        }
    }
}
