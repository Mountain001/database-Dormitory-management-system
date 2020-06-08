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
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnect = new SqlConnection("Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123");
            sqlconnect.Open();
            string str = "";
            str = "insert into wlry(sfzh,xm,xb,md,jrsj) values(" + txt1.Text + ",'" + txt2.Text + "','" + cbx1.Text + "','" + txt3.Text + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "')";
            SqlCommand sqlcommand = new SqlCommand(str, sqlconnect);
            int s = sqlcommand.ExecuteNonQuery();
            if (s == 1)
            {
                MessageBox.Show("登记成功");
                txt1.Clear();
            }
            sqlconnect.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt4.Text = DateTime.Now.ToString();
        }

        private void frm10_Load(object sender, EventArgs e)
        {

        }
    }
}
