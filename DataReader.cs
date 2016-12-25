using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luyentap1
{
    class DataReader
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string Donvitinh { get; set; }
        public double Dongia { get; set; }
        public int MaloaiHinh { get; set; }
        public string HinhSP { get; set; }
        public DataReader(string ma, string ten, string donvi, double dongia, int maloai, string hinh)
        {
            this.MaSP = ma;
            this.TenSP = ten;
            this.Donvitinh = donvi;
            this.Dongia = dongia;
            this.MaloaiHinh = maloai;
            this.HinhSP = hinh;

        }
    }
}
