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
        private string noti;
        public Login Login
        {
            set { login = value; }
        }

        public string Noti
        {
            get
            {
                return noti;
            }

            set
            {
                noti = value;
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
