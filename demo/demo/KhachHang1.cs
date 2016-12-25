using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSKhachHang
{
    class KhachHang1
    {
         private string _maKH;
        private string _tenKH;
        private string _diachi;
        private string _dienthoai;
        private string _fax;


        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        public string TenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
        }

        public string DiaChi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }

        public string DienThoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        // Ham khoi tao mac dinh 
        public KhachHang1()
        {
            _maKH = "";
            _tenKH = "";
            _diachi = "";
            _dienthoai = "";
            _fax = "";
        }

        // Ham khoi tao co tham so 
        public KhachHang1(string MaKH, string TenKH, string DiaChi, string DienThoai, string Fax)
        {
            _maKH = MaKH;
            _tenKH = TenKH;
            _diachi = DiaChi;
            _dienthoai = DienThoai;
            _fax = Fax;
        }
     }

    }


