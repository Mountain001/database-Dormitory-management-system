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
using System.Collections;
namespace WindowsFormsApp3
{
    public partial class frm5 : Form
    {
        public frm5()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnect = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sqlconnect.Open();
            string str = "";
            SqlCommand cmd1 = new SqlCommand("select xybh from xy where xymc='" + cbx1.Text + "'", sqlconnect);
            SqlDataReader dr;
            dr = cmd1.ExecuteReader();
            dr.Read();
            string cno = dr[0].ToString();
            dr.Close();

            if (txt1.Text == "" || txt2.Text == "" || cbx6.Text == "" || cbx1.Items.Count == 0 || txt2.Text == "" || cbx2.Items.Count == 0 || cbx4.Items.Count == 0 || cbx4.Items.Count == 0)
            {
                MessageBox.Show("请输入该学生的完整信息");
            }
            else
            {
                str = "insert into xs (xh,xm,xb,csrq,xyh,dh,sslh,ssh,cwh,sfjf) values ('" + txt1.Text + "','" + txt2.Text + "','" + cbx6.Text + "','" + dtp1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cno + "','" + txt3.Text + "','" + cbx2.Text + "','" + txt4.Text + "','" + cbx4.Text + "','" + cbx5.Text + "')";

            }
            SqlCommand sqlcommand = new SqlCommand(str, sqlconnect);
            int s = sqlcommand.ExecuteNonQuery();
            if (s == 1)
            {
                MessageBox.Show("添加成功");
                txt1.Clear();
            }
            sqlconnect.Close();

        }





        private void cbx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void frm5_Load(object sender, EventArgs e)
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

        private void cbx4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
