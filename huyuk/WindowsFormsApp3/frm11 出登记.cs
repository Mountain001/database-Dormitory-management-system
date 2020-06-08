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

namespace WindowsFormsApp3
{
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection sconn = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from wlry where sfzh='" + textBox1.Text + "'", sconn);
            DataSet clnnum = new DataSet();
            sda.Fill(clnnum, "wlry");

            //使用DataSet绑定时，必须同时指明DateMember 
            this.dataGridView1.DataSource = clnnum;
            this.dataGridView1.DataMember = "wlry";
            sconn.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnect = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sqlconnect.Open();
            string str = "";
            str = "update wlry set lksj='" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "'where sfzh=" + textBox1.Text ;
            SqlCommand sqlcommand = new SqlCommand(str, sqlconnect);
            int s = sqlcommand.ExecuteNonQuery();
            if (s == 1)
            {
                MessageBox.Show("离开时间登记成功");
                textBox1.Clear();
            }
            sqlconnect.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox2.Text = DateTime.Now.ToString(); 
        }

        private void frm11_Load(object sender, EventArgs e)
        {

        }
    }
}
