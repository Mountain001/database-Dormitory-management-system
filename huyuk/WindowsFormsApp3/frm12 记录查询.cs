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
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sconn = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from wlry " , sconn);
            DataSet clnnum = new DataSet();
            sda.Fill(clnnum, "wlry");

            //使用DataSet绑定时，必须同时指明DateMember 
            this.dataGridView1.DataSource = clnnum;
            this.dataGridView1.DataMember = "wlry";
            sconn.Close();
        }

        private void frm12_Load(object sender, EventArgs e)
        {

        }
    }
}
