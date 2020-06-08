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
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123";
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from xs where xh=" + txt1.Text,conn);
            SqlDataReader dateReader = comm.ExecuteReader();
            if (dateReader != null)
            {
                MessageBox.Show("查找成功！！");
                dateReader.Read();
                txt2.Text = dateReader[0].ToString();  // 把查到结果显示在文本框
                txt3.Text = dateReader[1].ToString();
                txt4.Text = dateReader[2].ToString();
                txt5.Text = dateReader[3].ToString();
                txt6.Text = dateReader[4].ToString();
                txt7.Text = dateReader[5].ToString();
                txt8.Text = dateReader[6].ToString();
                txt9.Text = dateReader[7].ToString();
                txt10.Text = dateReader[8].ToString();
                txt11.Text = dateReader[9].ToString();
            }
            else
            {
                MessageBox.Show("请重新输入！！");
            }
        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnect = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sqlconnect.Open();
            SqlCommand cmd1 = new SqlCommand("select xybh from xy where xymc='" + cbx1.Text + "'", sqlconnect);
            SqlDataReader dr;
            dr = cmd1.ExecuteReader();
            dr.Read();
            string cno = dr[0].ToString();
            dr.Close();

            string str = "update xs set xh='" + txt12.Text + "',xm='" + txt13.Text + "',xb='" + cbx5.Text + "',csrq='" + dtp1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',xyh='" + cno + "',dh='" + txt14.Text + "',sslh='" + cbx2.Text + "',ssh='" + textBox1.Text + "',cwh='" + cbx4.Text + "',sfjf='" + cbx6.Text + "'where xh=" + txt1.Text;
            SqlCommand sqlcommand = new SqlCommand(str, sqlconnect);
            int s = sqlcommand.ExecuteNonQuery();
            if (s == 1)
            {
                MessageBox.Show("修改成功");
                txt1.Clear();
            }
            sqlconnect.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbx2_Enter(object sender, EventArgs e)
        {

        }

        private void frm7_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123";
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = "select xymc from xy";
            SqlDataReader dr;
            dr = com.ExecuteReader();
            cbx1.Items.Clear();
            while (dr.Read())
            {
                cbx1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }
    }
}
