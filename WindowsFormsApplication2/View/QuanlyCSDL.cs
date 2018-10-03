using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.View
{
    public partial class QuanlyCSDL : Form
    {
        private Login login;
        private string sv;
        private string user;
        private string pass;
        private string db;

        public Login Login
        {
            set { login = value; }
        }

        public string Sv
        {
            get
            {
                return sv;
            }

            set
            {
                sv = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public string Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }

        public QuanlyCSDL()
        {
            InitializeComponent();
        }
 
        private void QuanlyCSDL_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(login == null)
            {
                login = new Login();
            }
            login.Quanly = this;
            login.ShowDialog();
        }
    }
}
