using System;

namespace thuchanh1
{
    public partial class ChiTiet : Form
    {
        public ChiTiet()
        {
            InitializeComponent();
        }

        public ChiTiet(string ten, string tien, string loai, string _tenanh)
        {
            InitializeComponent();

            ctTen = ten;
            ctTien = tien;
            ctLoai = loai;
            tenAnh = _tenanh;

            ctAnh_a = Image.FromFile("Resources/" + _tenanh + "a.jpg");
            ctAnh_b = Image.FromFile("Resources/" + _tenanh + "b.jpg");
            ctAnh_c = Image.FromFile("Resources/" + _tenanh + "c.jpg");
            ctAnh_d = Image.FromFile("Resources/" + _tenanh + "d.jpg");
        }


        private string tenanh;
        public string tenAnh { get => tenanh; set => tenanh = value; }
        public string ctTien { get => lb_giatien.Text; set => lb_giatien.Text = value; }
        public string ctTen { get => lb_ten.Text; set => lb_ten.Text = value; }
        public string ctLoai { get => lb_loai.Text; set => lb_loai.Text = value; }

        public Image ctAnh_a { get => img_a.BackgroundImage; set => img_a.BackgroundImage = value; }
        public Image ctAnh_b { get => img_b.BackgroundImage; set => img_b.BackgroundImage = value; }
        public Image ctAnh_c { get => img_c.BackgroundImage; set => img_c.BackgroundImage = value; }
        public Image ctAnh_d { get => img_d.BackgroundImage; set => img_d.BackgroundImage = value; }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var newForm = new LichSuMuaHang();
            newForm.Show();
        }

        private void ChiTiet_Shown(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}