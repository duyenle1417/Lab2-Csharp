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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
{
    public partial class Lab02_Bai4 : Form
    {
        public Lab02_Bai4()
        {
            InitializeComponent();
        }

        Student[] student;

        //deserialize file input, hien thi du lieu file ra man hinh
        private void btnRead_Click(object sender, EventArgs e)
        {
            //mo file input va hien thi tren richTextBox1
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

                student = (Student[])bf.Deserialize(fs);
                for (int i = 0; i < student.Length; i++)
                {
                    richTextBox1.Text += student[i].MSSV + Environment.NewLine;
                    richTextBox1.Text += student[i].HoTen + Environment.NewLine;
                    richTextBox1.Text += student[i].DienThoai + Environment.NewLine;
                    //"#0.0#" hien thi thap phan; VD: 8.0, 10.0, 8.75
                    richTextBox1.Text += student[i].DiemToan.ToString("#0.0#") + Environment.NewLine;
                    richTextBox1.Text += student[i].DiemVan.ToString("#0.0#") + Environment.NewLine
                                        + Environment.NewLine;
                }
                fs.Close();
            }
        }
        

        //luu file output.txt
        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
            }
            richTextBox1.Text = "Cấu trúc file output.txt\r\n" + richTextBox1.Text;
        }

        //serialize file input
        private void btnInput_Click(object sender, EventArgs e)
        {
            if (Text_NumHV.TextLength > 0 && int.Parse(Text_NumHV.Text)>0)
            {
                //chua nhap thong tin hoc vien
                if(richTextBox1.TextLength<1)
                {
                    MessageBox.Show("Mời nhập thông tin học viên");
                }
                else
                {
                    //array student null
                    student = new Student[int.Parse(Text_NumHV.Text)];
                    //point moi arr vao class Student de array khong con null
                    for (int j = 0; j < int.Parse(Text_NumHV.Text); j++)
                    {
                        student[j] = new Student();
                    }
                    int num = 0;
                    for (int i = 0; i < richTextBox1.Lines.Length; i++)
                    {
                        student[num].MSSV = richTextBox1.Lines[i];
                        student[num].HoTen = richTextBox1.Lines[++i];
                        student[num].DienThoai = richTextBox1.Lines[++i];
                        student[num].DiemToan = float.Parse(richTextBox1.Lines[++i]);
                        student[num].DiemVan = float.Parse(richTextBox1.Lines[++i]);
                        num++;
                    }
                    //xoa du lieu da nhap
                    richTextBox1.Clear();
                    //khong cho sua doi so hoc vien
                    Text_NumHV.Enabled = false;

                    //serialize obj student vao file input
                    SaveFileDialog sfd = new SaveFileDialog();
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                        bf.Serialize(fs, student);
                        fs.Close();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Lỗi số học viên.");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Text_NumHV.Clear();
            Text_NumHV.Enabled = true;
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            for (int i = 0; i < student.Length; i++)
            {
                richTextBox1.Text += student[i].MSSV + Environment.NewLine;
                richTextBox1.Text += student[i].HoTen + Environment.NewLine;
                richTextBox1.Text += student[i].DienThoai + Environment.NewLine;
                //"#0.0#" hien thi thap phan; VD: 8.0, 10.0, 8.75
                richTextBox1.Text += student[i].DiemToan.ToString("#0.0#") + Environment.NewLine;
                richTextBox1.Text += student[i].DiemVan.ToString("#0.0#") + Environment.NewLine;
                //tinh diem trung binh tren obj student
                //roi hien ket qua tren richTextBox1
                student[i].DTB = (student[i].DiemToan + student[i].DiemVan) / 2;
                richTextBox1.Text += student[i].DTB.ToString("#0.0#") + Environment.NewLine
                                    + Environment.NewLine;
            }
        }
    }
}
