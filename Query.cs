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
    public partial class Query : Form
    {
        string cnStr;
        SqlConnection cn;
        public Query()
        {
            InitializeComponent();
        }

        private void Query_Load(object sender, EventArgs e)
        {
            cnStr = @"Server=.\SQLEXPRESS;Database=QLBanHang;Integrated security=true;";
            cn = new SqlConnection(cnStr);
        }
        private void Connect()
        {
            cn.Open();
        }
        private void Disconnect()
        {
            cn.Close();
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            try 
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = txtQuery.Text;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                Disconnect();
            }
            
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
