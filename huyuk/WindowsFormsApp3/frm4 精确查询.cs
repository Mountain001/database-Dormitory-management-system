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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm4_Load(object sender, EventArgs e)
        {

        }
    }
}
