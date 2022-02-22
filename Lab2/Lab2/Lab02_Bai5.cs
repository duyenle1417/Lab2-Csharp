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
    public partial class Lab02_Bai5 : Form
    {
        public Lab02_Bai5()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            ThuMuc.Items.Clear();//xoa ket qua cu
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog()==DialogResult.OK)
            {
                //chon thu muc
                DirectoryInfo dr = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] arr = dr.GetFiles();//lay cac file co trong folder
                foreach (FileInfo file in arr)
                {
                    ListViewItem info = new ListViewItem();
                    //lay cac thong tin file
                    info.Text = file.Name;//ten file
                    info.SubItems.Add(file.Length.ToString());//bytes
                    info.SubItems.Add(file.Extension);//duoi mo rong
                    info.SubItems.Add(file.CreationTime.ToString());//ngay tao file
                    //hien thi thong tin
                    ThuMuc.Items.Add(info);
                }

                
            }
        }
        //dong form
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
