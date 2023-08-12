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
    public class BUS_NhanVien
    {
        public static DataTable GetAllNhanVien()
        {
            return DAL_NhanVien.getData();
        }

        public static bool insertNV(DTO_NhanVien nv)
        {
            return DAL_NhanVien.insert(nv);
        }

        public static bool updateNV(DTO_NhanVien nv)
        {
            return DAL_NhanVien.update(nv);
        }

        public static bool deleteNV(string ma)
        {
            return DAL_NhanVien.delete(ma);
        }

        public static DataTable LookUpNV(string field)
        {
            return DAL_NhanVien.LookUp(field);
        }

        public static DataTable LookUpGV()
        {
            return DAL_NhanVien.LookUpGV();
        }

        public static DataTable LookUpBV()
        {
            return DAL_NhanVien.LookUpBV();
        }

        public static DataTable LookUpGVBM()
        {
            return DAL_NhanVien.LookUpGVBM();
        }

        public static DataTable LookUpLD()
        {
            return DAL_NhanVien.LookUpLD();
        }

        public static DataTable LookUpGVCN()
        {
            return DAL_NhanVien.LookUpGVCN();
        }

        public static DataTable LookUpLC()
        {
            return DAL_NhanVien.LookUpLC();
        }
    }


}
