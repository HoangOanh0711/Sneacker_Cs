namespace thuchanh1
{
    partial class sanpham_trangchu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            sp_mau = new Label();
            sp_loai = new Label();
            sp_ten = new Label();
            sp_giatien = new Label();
            sp_anh = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sp_anh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(sp_mau);
            panel1.Controls.Add(sp_loai);
            panel1.Controls.Add(sp_ten);
            panel1.Controls.Add(sp_giatien);
            panel1.Controls.Add(sp_anh);
            panel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(9, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 324);
            panel1.TabIndex = 0;
            // 
            // sp_mau
            // 
            sp_mau.AutoSize = true;
            sp_mau.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sp_mau.ForeColor = SystemColors.ControlDarkDark;
            sp_mau.Location = new Point(10, 290);
            sp_mau.Name = "sp_mau";
            sp_mau.Size = new Size(51, 18);
            sp_mau.TabIndex = 4;
            sp_mau.Text = "4 màu";
            // 
            // sp_loai
            // 
            sp_loai.AutoSize = true;
            sp_loai.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sp_loai.ForeColor = SystemColors.ControlDarkDark;
            sp_loai.Location = new Point(10, 263);
            sp_loai.Name = "sp_loai";
            sp_loai.Size = new Size(96, 18);
            sp_loai.TabIndex = 3;
            sp_loai.Text = "Nữ Originals";
            // 
            // sp_ten
            // 
            sp_ten.AutoSize = true;
            sp_ten.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sp_ten.Location = new Point(10, 236);
            sp_ten.Name = "sp_ten";
            sp_ten.Size = new Size(178, 18);
            sp_ten.TabIndex = 2;
            sp_ten.Text = "Dép Sandal adidas Astir";
            // 
            // sp_giatien
            // 
            sp_giatien.AutoSize = true;
            sp_giatien.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sp_giatien.Location = new Point(10, 203);
            sp_giatien.Name = "sp_giatien";
            sp_giatien.Size = new Size(88, 18);
            sp_giatien.TabIndex = 1;
            sp_giatien.Text = "2.000.000đ";
            // 
            // sp_anh
            // 
            sp_anh.BackColor = Color.Transparent;
            sp_anh.BackgroundImage = Properties.Resources._10a;
            sp_anh.BackgroundImageLayout = ImageLayout.Stretch;
            sp_anh.Location = new Point(3, 3);
            sp_anh.Name = "sp_anh";
            sp_anh.Size = new Size(220, 220);
            sp_anh.TabIndex = 0;
            sp_anh.TabStop = false;
            sp_anh.Click += sp_anh_Click;
            // 
            // sanpham_trangchu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Name = "sanpham_trangchu";
            Size = new Size(248, 338);
            Click += sanpham_trangchu_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sp_anh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label sp_mau;
        public Label sp_loai;
        public Label sp_ten;
        public Label sp_giatien;
        public PictureBox sp_anh;
    }
}
