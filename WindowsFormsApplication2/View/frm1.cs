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
using WindowsFormsApplication2.Model.DAO;

namespace WindowsFormsApplication2.View
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DungChung dc = new DungChung();
                string sv = server.Text;
                string db = database.Text;
                string userid = ID.Text;
                string pass = password.Text;

                dc.KetNoi(sv, db, userid, pass);
                MessageBox.Show("Kết nối thành công");
            } catch(Exception tt)
            {
                MessageBox.Show(tt.Message);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm1_Load(object sender, EventArgs e)
        {
            DungChung dc = new DungChung();
            dc.KetNoi("phanthanh-pc", "master", "sa", "123");
            string sql = "select * from sys.databases";
            SqlCommand cmd = new SqlCommand(sql, DungChung.cn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                databaselist.Items.Add(r[0].ToString());
            }
            r.Close();
        }
    }
}
