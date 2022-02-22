using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai1 : Form
    {
        public Lab02_Bai1()
        {
            InitializeComponent();
        }

        string sText;//doc du lieu file vao day va xu ly

        private void btnRead_Click(object sender, EventArgs e)
        {
            //mo file input1.txt
            ofd = new OpenFileDialog();
            //kiem tra trang thai
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                //doc file
                sText = sr.ReadToEnd();
                HienThi.Text = sText;
                //dong stream va close file
                sr.Close();
                fs.Close();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //file output1.txt luu ket qua
            sText = sText.ToUpper();//chuyen ky tu sang in hoa

            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog()==DialogResult.OK)
            {
                //ghi file
                File.WriteAllText(sfd.FileName, sText);
                //hien thi ket qua cua file output
                HienThi.Text = HienThi.Text + "\r\n\r\nOutput:\r\n" + sText;
            }
        }
    }
}
