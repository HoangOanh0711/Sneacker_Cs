namespace thuchanh1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button button9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel4 = new TableLayoutPanel();
            p_dangnhap = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label13 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            lb_dangky = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button9 = new Button();
            p_dangnhap.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.BackColor = Color.Transparent;
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.FromArgb(92, 147, 184);
            button9.Location = new Point(245, 230);
            button9.Name = "button9";
            button9.Size = new Size(162, 28);
            button9.TabIndex = 2;
            button9.Text = "Quên mật khẩu?";
            button9.TextAlign = ContentAlignment.MiddleRight;
            button9.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // p_dangnhap
            // 
            p_dangnhap.BackColor = Color.White;
            p_dangnhap.Controls.Add(panel2);
            p_dangnhap.Controls.Add(panel1);
            p_dangnhap.Controls.Add(label2);
            p_dangnhap.Controls.Add(label1);
            p_dangnhap.Controls.Add(button1);
            p_dangnhap.Controls.Add(checkBox1);
            p_dangnhap.Controls.Add(button9);
            p_dangnhap.Controls.Add(lb_dangky);
            p_dangnhap.Controls.Add(label6);
            p_dangnhap.Controls.Add(label4);
            p_dangnhap.Controls.Add(label3);
            p_dangnhap.Controls.Add(textBox2);
            p_dangnhap.Controls.Add(textBox1);
            p_dangnhap.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p_dangnhap.Location = new Point(9, 0);
            p_dangnhap.Margin = new Padding(0);
            p_dangnhap.Name = "p_dangnhap";
            p_dangnhap.Size = new Size(466, 595);
            p_dangnhap.TabIndex = 0;
            p_dangnhap.Paint += panel4_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(76, 531);
            panel2.Name = "panel2";
            panel2.Size = new Size(307, 41);
            panel2.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox3.Image = Properties.Resources.gg;
            pictureBox3.Location = new Point(19, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(87, 0);
            label13.Name = "label13";
            label13.Size = new Size(198, 41);
            label13.TabIndex = 1;
            label13.Text = "Đăng nhập bằng Google";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox2.Image = Properties.Resources.fb;
            pictureBox2.Location = new Point(88, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 0);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 120, 241);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(76, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 41);
            panel1.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.ForeColor = Color.White;
            label5.Location = new Point(87, 0);
            label5.Name = "label5";
            label5.Size = new Size(209, 41);
            label5.TabIndex = 1;
            label5.Text = "Đăng nhập bằng Facebook";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.fb;
            pictureBox1.Location = new Point(19, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 25);
            label2.Name = "label2";
            label2.Size = new Size(460, 42);
            label2.TabIndex = 14;
            label2.Text = "ĐĂNG NHẬP";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 415);
            label1.Name = "label1";
            label1.Size = new Size(440, 18);
            label1.TabIndex = 13;
            label1.Text = "_____________________ HOẶC _____________________";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 147, 184);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(76, 307);
            button1.Name = "button1";
            button1.Size = new Size(307, 47);
            button1.TabIndex = 12;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(39, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 22);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Tự động đăng nhập";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // lb_dangky
            // 
            lb_dangky.AutoSize = true;
            lb_dangky.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_dangky.ForeColor = Color.FromArgb(92, 147, 184);
            lb_dangky.Location = new Point(282, 369);
            lb_dangky.Name = "lb_dangky";
            lb_dangky.Size = new Size(72, 19);
            lb_dangky.TabIndex = 9;
            lb_dangky.Text = "Đăng ký";
            lb_dangky.Click += lb_dangky_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(112, 369);
            label6.Name = "label6";
            label6.Size = new Size(177, 18);
            label6.TabIndex = 8;
            label6.Text = "Bạn chưa có tài khoản? ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 171);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 89);
            label3.Name = "label3";
            label3.Size = new Size(153, 18);
            label3.TabIndex = 5;
            label3.Text = "Email / Tên tài khoản";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(65, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 26);
            textBox2.TabIndex = 2;
            textBox2.Tag = "";
            textBox2.WordWrap = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(65, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 26);
            textBox1.TabIndex = 1;
            textBox1.Tag = "";
            textBox1.WordWrap = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(485, 603);
            ControlBox = false;
            Controls.Add(p_dangnhap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            p_dangnhap.ResumeLayout(false);
            p_dangnhap.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private Panel p_dangnhap;
        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
        private Label lb_dangky;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label13;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label2;

        public virtual string PlaceholderText { get; set; }
    }
}