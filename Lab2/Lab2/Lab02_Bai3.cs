using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Lab02_Bai3 : Form
    {
        public Lab02_Bai3()
        {
            InitializeComponent();
        }

        string sText;//luu text tren man hinh richTextBox

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                sText = sr.ReadToEnd();
                richTextBox1.Text = sText.ToString();
            }
            sText = "";
        }
        //ghi file output
        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
        }
        //tinh toan cac phep tinh doc trong file
        private void btnCal_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Lines.Length>0)
            {
                foreach(var line in richTextBox1.Lines)
                {
                    if (line.Length < 0)
                        continue;
                    //lay gia tri can tinh toan
                    string[] value = line.Split(new char[] { '+', '-', '*', '/' });
                    double num1, num2, result;
                    num1 = double.Parse(value[0]);
                    num2 = double.Parse(value[1]);
                    //thuc hien phep tinh
                    if(line.IndexOf('+')>0)
                    {
                        result = num1 + num2;
                        sText += line + "=" + result.ToString() + Environment.NewLine;
                    }
                    else if (line.IndexOf('-') > 0)
                    {
                        result = num1 - num2;
                        sText += line + "=" + result.ToString() + Environment.NewLine;
                    }
                    else if (line.IndexOf('*') > 0)
                    {
                        result = num1 * num2;
                        sText += line + "=" + result.ToString() + Environment.NewLine;
                    }
                    else if (line.IndexOf('/') > 0)
                    {
                        result = num1 / num2;
                        sText += line + "=" + result.ToString() + Environment.NewLine;
                    }
                    else
                    {
                        //neu la cac phep tinh ngoai +-*/ thi bao loi
                        MessageBox.Show("Lỗi!");
                    }
                }
            }
            richTextBox1.Text = sText;
        }
    }
}
