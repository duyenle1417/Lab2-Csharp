using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai1 form = new Lab02_Bai1();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai2 form = new Lab02_Bai2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai3 form = new Lab02_Bai3();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai4 form = new Lab02_Bai4();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai5 form = new Lab02_Bai5();
            form.ShowDialog();
        }
    }
}
