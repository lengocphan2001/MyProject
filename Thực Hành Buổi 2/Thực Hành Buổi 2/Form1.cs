using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thực_Hành_Buổi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Page_Load();
        }
        private void Page_Load()
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Consolas", 12);
            Connection a = new Connection();
            string connectString = a.getConnectionString();
            string query = "select Masach, Tieude, Dongia, Soluong from SACH where Trangthai = 1";
            SqlConnection cnn = new SqlConnection(connectString);
            SqlDataAdapter adt = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            dataGridView1.AutoSize = true;
            cnn.Open();
            try
            {
                adt.Fill(ds, "SACH");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "SACH";
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            textBox1.Text = Convert.ToString(dr.Cells[0].Value);
            textBox2.Text = Convert.ToString(dr.Cells[1].Value);
            textBox3.Text = Convert.ToString(dr.Cells[2].Value);
            textBox4.Text = Convert.ToString(dr.Cells[3].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            Connection a = new Connection();
            string connectionString = a.getConnectionString();
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                SqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "them_sach";
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    string masach = textBox1.Text;
                    string tieude = textBox2.Text;
                    int dongia = Convert.ToInt32(textBox3.Text);
                    int soluong = Convert.ToInt32(textBox4.Text);
                    cmd.Parameters.AddWithValue("@Masach", masach);
                    cmd.Parameters.AddWithValue("@Tieude", tieude);
                    cmd.Parameters.AddWithValue("@Dongia", dongia);
                    cmd.Parameters.AddWithValue("@Soluong", soluong);
                    int t = cmd.ExecuteNonQuery();
                    cnn.Close();
                    Page_Load();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            string ma = dr.Cells[0].Value.ToString();
            Connection a = new Connection();
            string connectionString = a.getConnectionString();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "xoa_sach1";
                    cmd.Parameters.AddWithValue("@Masach", ma);
                    cnn.Open();
                    int t = cmd.ExecuteNonQuery();
                    cnn.Close();
                    if (t != 0)
                    {
                        label1.Text = "Done";
                    }
                }
            }
        }
    }
}
