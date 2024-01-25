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
    public class HocSinhDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBConnection db = new DBConnection();
        public HocSinhDAO() 
        {
            
        } 

        public DataTable LoadTT()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            
            return db.Load(sqlStr);
        }

        public void ThemHocSinh(HocSinh them)
        {

            string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')", them.Ten, them.DiaChi, them.Cmnd, them.NgaySinh.ToString("MM/dd/yyyy"));
            ThucThi(sqlStr);
        }

        public void XoaThongTin(HocSinh xoa)
        {
            string SQL = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", xoa.Cmnd);
            ThucThi(SQL);
        }

        public void SuaThongTin(HocSinh sua)
        {
            string SQL = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi ='{1}', Cmnd = '{2}' WHERE ngaysinh='{3}'", sua.Ten, sua.DiaChi, sua.Cmnd, sua.NgaySinh.ToString("MM/dd/yyyy"));
            ThucThi(SQL);
        }

        public void ThucThi(string sqlStr)
        {
            db.ThucHien(sqlStr);
        }
    }
}
