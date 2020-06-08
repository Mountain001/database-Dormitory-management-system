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
    public partial class frm3 : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter adapter = null;
        public frm3()
        {
            InitializeComponent();
        }

        private void frm3_Load(object sender, EventArgs e)
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

        private void btn1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();    
            conn.ConnectionString = "Data Source=localhost;Initial Catalog=huyuk; User ID=sa;Password=123";
            conn.Open();
            ////SqlCommand comm = new SqlCommand("select * from xs where xm=' " + txt1.Text+"'", conn);//输入的姓名为数据库里的姓名  
            //SqlDataAdapter sda = new SqlDataAdapter("select * from xs where xm='" + txt1.Text + "'", conn);
            try
            {
                //DataSet clnnum = new DataSet();
                //sda.Fill(clnnum, "xs");

                ////使用DataSet绑定时，必须同时指明DateMember 
                //this.lvw1.DataSource = clnnum;
                //this.lvw1.DataMember = "xs";
                //conn.Close();
                string str = "select * from xs,xy where xs.xyh=xy.xybh ";
                if (txt1.Text.Trim().Length > 0)
                {
                    str += "and xm='" + txt1.Text + "'";

                }
                if (cbx1.Text.Trim().Length > 0)
                {
                   
                        str += "and xymc='" + cbx1.Text + "'";
                   
                }
                SqlCommand comm = new SqlCommand(str, conn);
                comm.ExecuteNonQuery();
                SqlDataAdapter sd = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                sd.Fill(ds);
                lvw1.DataSource = ds.Tables[0];
            }
            catch (SqlException err)
            {
                label1.Text = "无法读取数据";
            }
            finally
            {
                conn.Close();
              
            }

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //switch (e.Row.RowType)
            //{
            //    //判断是否表头
            //    case DataControlRowType.Header:
            //        //第一行表头
            //        TableCellCollection tcHeader = e.Row.Cells;
            //        tcHeader.Clear();



            //        tcHeader.Add(new TableHeaderCell());
            //        tcHeader[0].Attributes.Add("colspan", "4");
            //        tcHeader[0].Attributes.Add("bgcolor", "Azure");
            //        tcHeader[0].Text = "基  本  信  息";

            //        tcHeader.Add(new TableHeaderCell());
            //        tcHeader[1].Attributes.Add("bgcolor", "Azure");
            //        tcHeader[1].Text = "其他</th></tr><tr>";

            //        //第1行表头
            //        tcHeader.Add(new TableHeaderCell());
            //        tcHeader[0].Attributes.Add("bgcolor", "Azure");
            //        tcHeader[0].Text = "ID";
            //        tcHeader.Add(new TableHeaderCell());
            //        tcHeader[1].Attributes.Add("bgcolor", "Azure");
            //        tcHeader[1].Text = "船名";
            //        tcHeader.Add(new TableHeaderCell());
            //        tcHeader[2].Attributes.Add("bgcolor", "Azure");
            //        tcHeader[2].Text = "航次";
            //        tcHeader.Add(new TableHeaderCell());
            //        tcHeader[3].Attributes.Add("bgcolor", "Azure");
            //        tcHeader[3].Text = "提单号";
            //        tcHeader.Add(new TableHeaderCell());

            //        break;
            }
        }
    }