using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace luyentap1
{
    public partial class SanPham : Form
    {
        string cnStr;
        SqlConnection cn;
        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            cnStr=@"Server=.\SQLEXPRESS;Database=QLBanHang;Integrated security=true;";
            cn = new SqlConnection(cnStr);
            dgvSanPham.DataSource = GetDataReader();
        }
        private void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi...\n" + ex.Message);
            }
        }
        private void DisConnect()
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();

        }
        private List<DataReader> GetDataReader()
        {
            Connect();
            List<DataReader> list = new List<DataReader>();
            try
            {
                string sql = " SELECT*FROM SanPham";
                SqlCommand cmd = new SqlCommand(sql,cn);
                SqlDataReader dr = cmd.ExecuteReader();
                string MaSP, TenSP, Donvitinh, HinhSP;
                double Dongia;
                int Maloai;
                while(dr.Read())
                {
                    MaSP = dr.GetString(0);
                    TenSP = dr.GetString(1);
                    Donvitinh = dr.GetString(2);
                    Dongia = dr.GetDouble(3);
                    Maloai = dr.GetInt32(4);
                    HinhSP = dr.GetString(5);
                    DataReader da = new DataReader(MaSP, TenSP, Donvitinh, Dongia, Maloai, HinhSP);
                    list.Add(da);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                DisConnect();
            }
            return list;
        }
    }
}
