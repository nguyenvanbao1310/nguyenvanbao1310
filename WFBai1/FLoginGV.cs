using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBai1
{
    public partial class FLoginGV : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        GiaoVienDAO gv= new GiaoVienDAO();
        public FLoginGV()
        {
            InitializeComponent();
        }

        private void FLoginGV_Load(object sender, EventArgs e)
        {
            conn.Close();
            gvGvien.DataSource = gv.LoadTT();

        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            GiaoVien them = new GiaoVien(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, DTPNgayThangNam.Value);
            gv.ThemGV(them);
            FLoginGV_Load(sender, e);
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            GiaoVien xoa = new GiaoVien(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, DTPNgayThangNam.Value);
            gv.XoaGV(xoa);
            FLoginGV_Load(sender, e);
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            GiaoVien sua = new GiaoVien(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, DTPNgayThangNam.Value);
            gv.SuaTT(sua);
            FLoginGV_Load(sender, e);
        }

        private void gvGvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtHoTen.Text = gvGvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDiaChi.Text = gvGvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCMND.Text = gvGvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                DTPNgayThangNam.Text = gvGvien.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
