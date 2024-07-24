using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaoDien
{
    public partial class Nhân_Viên : Form
    {
        public Nhân_Viên()
        {
            InitializeComponent();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            KhuyenMai form2 = new KhuyenMai();
            form2.Show();
        }

        private void btnnhaHang_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nhân_Viên nhân_Viên = new Nhân_Viên();
            nhân_Viên.Show();
        }

        private void btnkhuyenMai_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenMai = new KhuyenMai();
            khuyenMai.Show();
        }

        private void btnnhaHang_Click_1(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form2 form21 = new Form2();
            form21.Show();
        }
    }
}
