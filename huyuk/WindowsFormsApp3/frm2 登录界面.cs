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
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string x = txt1.Text;
            string y = txt2.Text;
            try
            {
                string constr = "server=localhost;database=huyuk;uid='" + x + "';pwd='" + y + "';";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                MessageBox.Show("登录成功。可以进行进一步操作。", "登录结果");
            }
            catch
            {
                MessageBox.Show("登录失败，请检查用户名密码是否正确。", "登录结果");
            }
        }

        private void frm2_Load(object sender, EventArgs e)
        {

        }
    }
}
