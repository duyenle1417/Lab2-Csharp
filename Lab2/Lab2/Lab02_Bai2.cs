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
    public partial class Lab02_Bai2 : Form
    {
        public Lab02_Bai2()
        {
            InitializeComponent();
        }
        //doc file
        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string TextString;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                TextString = sr.ReadToEnd();
                richTextBox1.Text = TextString;

                //tra ve ten file
                TenFile.Text = ofd.SafeFileName;
                //tra ve duong link cua file
                URL.Text = fs.Name;
                //tra ve so ky tu trong file
                CharacterNum.Text = TextString.Length.ToString();
                //tra ve so dong trong file
                LineNum.Text = richTextBox1.Lines.Count().ToString();
                //tra ve so tu tong file
                string[] wordcount = TextString.Split(new char[] {'.', '?', '!', ' ', ';', ':', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
                WordCount.Text = wordcount.Count().ToString();

                sr.Close();
                fs.Close();
            }
        }
    }
}
