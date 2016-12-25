using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DSKhachHang
{
    public partial class KHACHHANG : Form
    {
        string cnstr = @"Server= HONGLIEN\SQLEXPRESS; Database = QLBanHang; Integrated Security = true";
        SqlConnection _cn;    

        public KHACHHANG()
        {
            InitializeComponent();
            _cn = new SqlConnection(cnstr);
        }
        public void Connect()
        {
            try
            {
                if (_cn != null && _cn.State == ConnectionState.Closed)
                {
                    _cn.Open();
                    labeL6.Text = "Trạng thái: Đã kết nối!";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
        public void Disconnect()
        {
            try
            {
                if (_cn != null && _cn.State == ConnectionState.Open)
                {
                    _cn.Close();
                    labeL6.Text = "Trạng thái: Đã ngắt kết nối!";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }
        public void ShowData(string sqlwhere)
        {
            // Goi ham ket noi den CSDL
            Connect();
            string sql;
            if(sqlwhere == null)
            {
                sql = @"SELECT * FROM KHACH_HANG";
            }
            else 
            {
                sql = sqlwhere;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(sql, _cn);
                // Thuc thi phuong thuc ExucuteReader cua doi tuong SqlCommand
                // tra ve mot hang
                SqlDataReader dr = cmd.ExecuteReader();

                List<KhachHang1> lstKhachHang = new List<KhachHang1>();

                string MaKH, TenKH, DiaChi, DienThoai, Fax;
                // Phuong thuc Read() cua doi tuong
                // 
                while (dr.Read())
                {
                    MaKH = dr.GetString(0);
                    TenKH = dr.GetString(1);
                    DiaChi = dr.GetString(2);
                    DienThoai = dr.GetString(3);
                    Fax = dr.GetString(4);
                    // Goi phuong thuc khoi tao co tham so cua lop khach hang 
                    KhachHang1 kh = new KhachHang1(MaKH, TenKH, DiaChi, DienThoai, Fax);

                   lstKhachHang.Add(kh);
                }

                dtgvKhachHang.DataSource = lstKhachHang;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
                throw;
            }
            finally
            {
                Disconnect();
            }
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvKhachHang.CurrentRow != null)
            {
                tbMaKH.Text = dtgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString();// Click vao dong nao hien dong do tren label
                tbTenKH.Text = dtgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
                tbDiaChi.Text = dtgvKhachHang.CurrentRow.Cells["DiaChi"].Value.ToString();
                tbDienThoai.Text = dtgvKhachHang.CurrentRow.Cells["DienThoai"].Value.ToString();
                tbFax.Text = dtgvKhachHang.CurrentRow.Cells["Fax"].Value.ToString();
            }
        }

        
        private void btThem_Click(object sender, EventArgs e)
        {
            KhachHang1 kh = new KhachHang1(txtMaKH.Text, txttenkh.Text, txtdiachi.Text, txtdienthoai.Text, txtfax.Text);
            List<SqlParameter> SqlParams = new List<SqlParameter>();
            SqlParams.Add(new SqlParameter("MaKH", kh.MaKH));
            SqlParams.Add(new SqlParameter("TenKH", kh.TenKH));
            SqlParams.Add(new SqlParameter("DiaChi", kh.DiaChi));
            SqlParams.Add(new SqlParameter("DienThoai", kh.DienThoai));
            SqlParams.Add(new SqlParameter("Fax", kh.Fax));

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("usp_Insert_KH", _cn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (SqlParams != null)
                {
                    foreach (SqlParameter param in SqlParams)
                        cmd.Parameters.Add(param);
                }

                SqlParameter ret = cmd.Parameters.Add("return", SqlDbType.Int);
                ret.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();

                int ins = (int)ret.Value;
                if (ins == 2)
                    ShowData(null);
                else
                    if (ins == 0)
                    {
                        MessageBox.Show(" Ma da ton tai ");
                    }
                    else
                    {
                        MessageBox.Show(" Can phai nhap ma khach hang ");
                    }
            }
            catch
            {
                MessageBox.Show(" Loi nhap lieu");
            }
            finally
            {
                Disconnect();
            }

        }
	

        

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            ShowData(null);
        }

        private void KHACHHANG_FormClosing(object sender, FormClosingEventArgs e)
        {
                        DialogResult rs = MessageBox.Show("Bạn có thật sự muốn thoát?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void KHACHHANG_Load_1(object sender, EventArgs e)
        {
            ShowData(null);
        }

        }


    }

