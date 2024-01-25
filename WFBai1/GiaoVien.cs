using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBai1
{
    public class GiaoVien
    {
        private string ten;
        private string diaChi;
        private string cmnd;
        private DateTime ngaySinh;

        public GiaoVien(string ten, string diaChi, string cmnd, DateTime ngaySinh)
        {
            this.ten = ten;
            this.diaChi = diaChi;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
        }

        public string Ten
        {
            get { return ten; }
        }

        public string DiaChi
        {
            get { return diaChi; }
        }

        public string Cmnd
        {
            get { return cmnd; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
        }
    }
}
