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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void 数据库导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关闭系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员修改", "修改密码", MessageBoxButtons.OK);
        }

        private void 范围查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm3();
            frm.ShowDialog();
        }

        private void 精确查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm4();
            frm.ShowDialog();
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm6();
            frm.ShowDialog();
        }

        private void 增加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm5();
            frm.ShowDialog();
        }

        private void 更改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm7();
            frm.ShowDialog();
        }

        private void 查看帮助文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm8();
            frm.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("该软件为104号与106号的课程设计作业，如有疑问请询问106号和104号同学。","关于", MessageBoxButtons.OK);
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void 测试数据库连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123";
            try
            {
                conn.Open();
                MessageBox.Show("连接成功。可以进行进一步操作。","测试结果");
                conn.Close();

            }
            catch
            {
                MessageBox.Show("连接失败。请检查网络是否通畅以及数据库是否出现了损坏。","测试结果");
            }

        }

        private void 数据库登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm2();
            frm.ShowDialog();
        }

        private void 数据库退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 入登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm10();
            frm.ShowDialog();
        }

        private void 出登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm11();
            frm.ShowDialog();
        }

        private void 查看登记表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frm12();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab5.Text = DateTime.Now.AddSeconds(0).ToString("yyyy年MM月dd日 dddd tt hh:mm:ss");
        }

        private void frm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) ;
            {
                e.Cancel = true;
                this.Hide();
            }
            notifyIcon1.BalloonTipTitle = "注意";//右下角气泡提示
            notifyIcon1.BalloonTipText = "双击重新打开";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 显示主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
