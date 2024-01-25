using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBai1
{
    public  class GiaoVienDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public GiaoVienDAO()
        {

        }

        public DataTable LoadTT()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");
            DBConnection db = new DBConnection();
            return db.Load(sqlStr);
        }

        public void ThemGV(GiaoVien them)
        {
            //conn.Open();
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten , Diachi, Cmnd, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')", them.Ten, them.DiaChi, them.Cmnd, them.NgaySinh.ToString("MM/dd/yyyy"));
            ThucThi(sqlStr);
            
        }

        public void XoaGV(GiaoVien xoa)
        {
            string SQL = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", xoa.Cmnd);
            ThucThi(SQL); 
          
        }

        public void SuaTT(GiaoVien sua)
        {

            string SQL = string.Format("UPDATE GiaoVien SET Ten = '{0}', DiaChi ='{1}', Cmnd = '{2}' WHERE ngaysinh='{3}'", sua.Ten, sua.DiaChi, sua.Cmnd, sua.NgaySinh.ToString("MM/dd/yyyy"));
            ThucThi(SQL);
        }

        public void ThucThi(string sql)
        {
            DBConnection db = new DBConnection();
            db.ThucHien(sql);
        }
    }
}
