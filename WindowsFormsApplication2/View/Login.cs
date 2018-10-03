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
using System.Data.Sql;
using WindowsFormsApplication2.Model.DAO;

namespace WindowsFormsApplication2.View
{
    public partial class Login : Form
    {
        private QuanlyCSDL quanly;
        public QuanlyCSDL Quanly
        {
            set { quanly = value; }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DungChung dc = new DungChung();
                string sv = lsservername.Text;
                string db = databaselist.Text;
                string userid = ID.Text;
                string pass = password.Text;

                dc.KetNoi(sv, db, userid, pass);
                MessageBox.Show("Kết nối thành công");
                quanly.Sv = sv;
                quanly.User = userid;
                quanly.Pass = pass;
                quanly.Db = db;
                this.Hide();
            } catch(Exception tt)
            {
                MessageBox.Show(tt.Message);
            }
            
        }

        private void frm1_Load(object sender, EventArgs e)
        {

            //Get list server name
            //string myServer = Environment.MachineName;

            //DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            //for (int i = 0; i < servers.Rows.Count; i++)
            //{
            //    if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
            //    {
            //        lsservername.Items.Add(servers.Rows[i]["ServerName"]);
            //        if ((servers.Rows[i]["InstanceName"] as string) != null)
            //            lsservername.Items.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
            //    }
            //}
            lsservername.Items.Add("phanthanh-pc");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DungChung dc = new DungChung();
            try
            {
                databaselist.Visible = false;
                databaselist.Items.Clear();
                string sv = lsservername.Text;
                string db = databaselist.Text;
                string userid = ID.Text;
                string pass = password.Text;
                dc.KetNoi(sv, db, userid, pass);
                string sql = "select * from sys.databases";
                SqlCommand cmd = new SqlCommand(sql, DungChung.cn);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    databaselist.Items.Add(r[0].ToString());
                }
                r.Close();
                databaselist.Visible = true;
            } catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            
        }
    }
}
