namespace Lab2
{
    partial class Lab02_Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThuMuc = new System.Windows.Forms.ListView();
            this.NameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThuMuc
            // 
            this.ThuMuc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFile,
            this.SizeFile,
            this.Extension,
            this.Date});
            this.ThuMuc.HideSelection = false;
            this.ThuMuc.Location = new System.Drawing.Point(12, 86);
            this.ThuMuc.Name = "ThuMuc";
            this.ThuMuc.Size = new System.Drawing.Size(794, 379);
            this.ThuMuc.TabIndex = 0;
            this.ThuMuc.UseCompatibleStateImageBehavior = false;
            this.ThuMuc.View = System.Windows.Forms.View.Details;
            // 
            // NameFile
            // 
            this.NameFile.Text = "Tên file";
            this.NameFile.Width = 386;
            // 
            // SizeFile
            // 
            this.SizeFile.Text = "Kích thước";
            this.SizeFile.Width = 126;
            // 
            // Extension
            // 
            this.Extension.Text = "Đuôi mở rộng";
            this.Extension.Width = 110;
            // 
            // Date
            // 
            this.Date.Text = "Ngày tạo";
            this.Date.Width = 167;
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.Location = new System.Drawing.Point(168, 21);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(178, 48);
            this.btn_open.TabIndex = 1;
            this.btn_open.Text = "Duyệt thư mục";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(446, 21);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(178, 48);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Lab02_Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 477);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.ThuMuc);
            this.Name = "Lab02_Bai5";
            this.Text = "Lab02_Bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ThuMuc;
        private System.Windows.Forms.ColumnHeader NameFile;
        private System.Windows.Forms.ColumnHeader SizeFile;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_close;
    }
}