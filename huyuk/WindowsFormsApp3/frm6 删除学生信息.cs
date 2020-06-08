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
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnect = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sqlconnect.Open();
            string str = "";
            if (txt1.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入要删除的学号！！！");
            }
            else if (txt1.Text.Trim().Length > 0 )

            {
                str = "delete from xs where xh=" + txt1.Text + "";
            }                    
            SqlCommand sqlcommand = new SqlCommand(str, sqlconnect);
            int s = sqlcommand.ExecuteNonQuery();
            if (s == 1)
            {
                MessageBox.Show("删除成功");
                txt1.Clear();       
            }            
            sqlconnect.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection sconn = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sconn.Open();
            
            SqlDataAdapter sda = new SqlDataAdapter("select * from xs where xh='" + txt1.Text + "'", sconn);
          
            DataSet clnnum = new DataSet();
            sda.Fill(clnnum, "xs");

            //使用DataSet绑定时，必须同时指明DateMember 
            this.dataGridView1.DataSource = clnnum;
            this.dataGridView1.DataMember = "xs";
            sconn.Close();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm6_Load(object sender, EventArgs e)
        {

        }
    }
}
