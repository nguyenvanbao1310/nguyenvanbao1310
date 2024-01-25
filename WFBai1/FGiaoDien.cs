using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBai1
{
    public partial class FGiaoDien : Form
    {
        public FGiaoDien()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            FLogin f = new FLogin();
            f.ShowDialog();
            //this.Close();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            FLoginGV f= new FLoginGV();
            f.ShowDialog();
            //this.Close();
        }
    }
}
