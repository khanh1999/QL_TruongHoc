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
    public class BUS_Lop
    {
        public static DataTable GetAllLop()
        {
            return DAL_Lop.getData();
        }

        public static bool insertLop(DTO_Lop lh)
        {
            return DAL_Lop.insert(lh);
        }

        public static bool updateLop(DTO_Lop lh)
        {
            return DAL_Lop.update(lh);
        }

        public static bool deleteLop(string ma)
        {
            return DAL_Lop.delete(ma);
        }

        public static DataTable LookUpLop(string field)
        {
            return DAL_Lop.LookUp(field);
        }
    }
}
