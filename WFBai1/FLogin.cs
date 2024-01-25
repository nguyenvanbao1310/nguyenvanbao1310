using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFBai1
{
    public partial class FLogin : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        HocSinhDAO hs= new HocSinhDAO();
        public FLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Close();
            gvHsinh.DataSource = hs.LoadTT();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh them = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, DTPNgayThangNam.Value);
            hs.ThemHocSinh(them);
            Form1_Load(sender, e );
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh xoa = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, DTPNgayThangNam.Value);
            hs.XoaThongTin(xoa);
            Form1_Load(sender, e);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh sua = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, DTPNgayThangNam.Value);
            hs.SuaThongTin(sua);
            Form1_Load(sender, e);
        }

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                txtHoTen.Text = gvHsinh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtDiaChi.Text = gvHsinh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCMND.Text = gvHsinh.Rows[e.RowIndex].Cells[2].Value.ToString();
                DTPNgayThangNam.Text = gvHsinh.Rows[e.RowIndex].Cells[3].Value.ToString();
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
