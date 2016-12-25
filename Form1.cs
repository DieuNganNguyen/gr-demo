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
    public partial class Form1 : Form
    {
        string cnStr;
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void rdWindow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();

        }
        private void Connect()
        {
            cnStr="Server="+txtTen.Text+";Database="+txtCSDL.Text+";";
            if(rdWindow.Checked)
            {
                cnStr = cnStr + "Integrated security=true;";
            }
            else
            {
                cnStr = cnStr + ";User id=" + txtName.Text + ";password=" + txtPass.Text;
            }
            cn.ConnectionString = cnStr;
            cn.Open();
            MessageBox.Show("Kết nối thành công", "Login", MessageBoxButtons.OK);

        }
        private void Disconnect()
        {
            cn.Close();
            MessageBox.Show("Hủy kết nối thành công", "Login", MessageBoxButtons.OK);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
    }
}
