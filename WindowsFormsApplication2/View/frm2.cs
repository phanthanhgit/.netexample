using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.BO;
using WindowsFormsApplication2.Model;
using WindowsFormsApplication2.View;

namespace WindowsFormsApplication2.View
{
    public partial class frm2 : Form
    {
        sachBO s = new sachBO();

        public frm2()
        {
            InitializeComponent();
        }

        public void reloadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = s.lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool i = s.Add(txtmasach.Text, txttensach.Text, long.Parse(txtgia.Text), long.Parse(txtsoluong.Text));
            if (i)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = s.lst;
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Đã trùng mã");
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            s.lst = s.getSach();
            s.luuFile(s.lst);
            dataGridView1.DataSource = s.lst;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                txtmasach.Text = dataGridView1[0, index].Value.ToString();
                txttensach.Text = dataGridView1[1, index].Value.ToString();
                txtgia.Text = dataGridView1[2, index].Value.ToString();
                txtsoluong.Text = dataGridView1[3, index].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool i = s.Edit(txtmasach.Text, txttensach.Text, long.Parse(txtgia.Text), long.Parse(txtsoluong.Text));
            if (i)
            {
                reloadData();
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s.luuFile(s.lst);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Đồng ý xóa?", "Thông báo", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                bool i = s.Xoa(txtmasach.Text);
                if (i)
                {
                    reloadData();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string st = Interaction.InputBox("Nhập tên sách cần tìm");
            List<sachBean> t = new List<sachBean>();
            t = s.Search(st);
            if (t.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy bất kì thứ gì liên quan");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = t;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s.lst = s.getSach();
            reloadData();
        }
    }
}
