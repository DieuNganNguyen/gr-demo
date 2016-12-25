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
    public partial class LoaiSanPham : Form
    {
        string cnStr;
        SqlConnection cn;
        public LoaiSanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Connect()
        {
            cn.Open(); 
        }
        private void DisConnect()
        {
            cn.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = @"INSERT INTO LoaiSP(MaLoaiSP,TenLoaiSP)VALUES(N'" + txtMaloai.Text + "',N'" + txtTenloai.Text + "')";
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                int count = cmd.ExecuteNonQuery();
                MessageBox.Show("Số dong đã thêm vào: " + count.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DisConnect();
            }
            
            
        }

        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            cnStr = @"Server=.\SQLEXPRESS;Database=QLBanHang;Integrated security=true;";
            cn = new SqlConnection(cnStr);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(DialogResult==DialogResult.OK)
            {
                string sql = @"DELETE FROM LoaiSP WHERE MaLoaiSP='" + txtMaloai.Text + "'";
                Connect();
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.CommandType = CommandType.Text;
                    int count = cmd.ExecuteNonQuery();
                    MessageBox.Show("Bạn đã xóa thành công");
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
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE LoaiSP SET MaLoaiSP=N'" + txtMaloai.Text + "',TenLoaiSP=N'" + txtTenloai.Text + "'";
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql,cn);
                cmd.CommandType = CommandType.Text;
                int count = cmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã sửa thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                DisConnect();
            }
        }

    }
}
