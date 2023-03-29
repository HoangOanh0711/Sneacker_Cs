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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            p_dangky = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            label12 = new Label();
            label11 = new Label();
            textBox5 = new TextBox();
            button6 = new Button();
            button5 = new Button();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            button8 = new Button();
            label1 = new Label();
            button9 = new Button();
            p_dangnhap.SuspendLayout();
            p_dangky.SuspendLayout();
            SuspendLayout();
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
            p_dangnhap.BackColor = Color.Gainsboro;
            p_dangnhap.Controls.Add(label1);
            p_dangnhap.Controls.Add(button1);
            p_dangnhap.Controls.Add(checkBox1);
            p_dangnhap.Controls.Add(button9);
            p_dangnhap.Controls.Add(label7);
            p_dangnhap.Controls.Add(label6);
            p_dangnhap.Controls.Add(label4);
            p_dangnhap.Controls.Add(label3);
            p_dangnhap.Controls.Add(textBox2);
            p_dangnhap.Controls.Add(textBox1);
            p_dangnhap.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p_dangnhap.Location = new Point(30, 59);
            p_dangnhap.Margin = new Padding(0);
            p_dangnhap.Name = "p_dangnhap";
            p_dangnhap.Size = new Size(466, 551);
            p_dangnhap.TabIndex = 0;
            p_dangnhap.Paint += panel4_Paint_1;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(60, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 26);
            textBox1.TabIndex = 1;
            textBox1.Tag = "";
            textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(60, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 26);
            textBox2.TabIndex = 2;
            textBox2.Tag = "";
            textBox2.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 159);
            label3.Name = "label3";
            label3.Size = new Size(153, 18);
            label3.TabIndex = 5;
            label3.Text = "Email / Tên tài khoản";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(56, 234);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(108, 423);
            label6.Name = "label6";
            label6.Size = new Size(177, 18);
            label6.TabIndex = 8;
            label6.Text = "Bạn chưa có tài khoản? ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(92, 147, 184);
            label7.Location = new Point(282, 423);
            label7.Name = "label7";
            label7.Size = new Size(65, 18);
            label7.TabIndex = 9;
            label7.Text = "Đăng ký";
            // 
            // button9
            // 
            button9.BackColor = Color.Gainsboro;
            button9.BackgroundImageLayout = ImageLayout.None;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.FromArgb(92, 147, 184);
            button9.Location = new Point(240, 303);
            button9.Name = "button9";
            button9.Size = new Size(162, 36);
            button9.TabIndex = 2;
            button9.Text = "Quên mật khẩu?";
            button9.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(62, 309);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 22);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Tự động đăng nhập";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(92, 147, 184);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(72, 361);
            button1.Name = "button1";
            button1.Size = new Size(307, 47);
            button1.TabIndex = 12;
            button1.Text = "ĐĂNG NHẬP";
            button1.UseVisualStyleBackColor = false;
            // 
            // p_dangky
            // 
            p_dangky.BackColor = Color.Gainsboro;
            p_dangky.Controls.Add(button8);
            p_dangky.Controls.Add(label9);
            p_dangky.Controls.Add(label10);
            p_dangky.Controls.Add(label8);
            p_dangky.Controls.Add(button5);
            p_dangky.Controls.Add(button6);
            p_dangky.Controls.Add(textBox5);
            p_dangky.Controls.Add(label11);
            p_dangky.Controls.Add(label12);
            p_dangky.Controls.Add(button3);
            p_dangky.Controls.Add(button4);
            p_dangky.Controls.Add(textBox3);
            p_dangky.Controls.Add(textBox4);
            p_dangky.Location = new Point(557, 73);
            p_dangky.Name = "p_dangky";
            p_dangky.Size = new Size(466, 551);
            p_dangky.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(60, 186);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(342, 30);
            textBox4.TabIndex = 1;
            textBox4.Tag = "";
            textBox4.WordWrap = false;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(60, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(342, 30);
            textBox3.TabIndex = 2;
            textBox3.Tag = "";
            textBox3.WordWrap = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(361, 261);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(41, 30);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(361, 297);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.No;
            button3.Size = new Size(41, 30);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(56, 159);
            label12.Name = "label12";
            label12.Size = new Size(51, 24);
            label12.TabIndex = 5;
            label12.Text = "Email";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(56, 234);
            label11.Name = "label11";
            label11.Size = new Size(77, 24);
            label11.TabIndex = 6;
            label11.Text = "Mật khẩu";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(60, 346);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(342, 30);
            textBox5.TabIndex = 7;
            textBox5.Tag = "";
            textBox5.WordWrap = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(361, 346);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(41, 30);
            button6.TabIndex = 8;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(361, 382);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(41, 30);
            button5.TabIndex = 9;
            button5.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(56, 319);
            label8.Name = "label8";
            label8.Size = new Size(150, 24);
            label8.TabIndex = 10;
            label8.Text = "Xác nhận mật khẩu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(86, 484);
            label10.Name = "label10";
            label10.Size = new Size(162, 24);
            label10.TabIndex = 11;
            label10.Text = "Bạn đã có tài khoản?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 15F, FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(242, 484);
            label9.Name = "label9";
            label9.Size = new Size(130, 24);
            label9.TabIndex = 12;
            label9.Text = "Đăng nhập ngay";
            // 
            // button8
            // 
            button8.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(145, 407);
            button8.Name = "button8";
            button8.Size = new Size(166, 50);
            button8.TabIndex = 13;
            button8.Text = "Đăng ký";
            button8.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 463);
            label1.Name = "label1";
            label1.Size = new Size(440, 18);
            label1.TabIndex = 13;
            label1.Text = "_____________________ HOẶC _____________________";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1273, 751);
            ControlBox = false;
            Controls.Add(p_dangky);
            Controls.Add(p_dangnhap);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Login_Load;
            p_dangnhap.ResumeLayout(false);
            p_dangnhap.PerformLayout();
            p_dangky.ResumeLayout(false);
            p_dangky.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private Panel p_dangnhap;
        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel p_dangky;
        private Button button8;
        private Label label9;
        private Label label10;
        private Label label8;
        private Button button5;
        private Button button6;
        private TextBox textBox5;
        private Label label11;
        private Label label12;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;

        public virtual string PlaceholderText { get; set; }
    }
}