namespace thuchanh1
{
    public partial class trangchu_dadangnhap : Form
    {
        public trangchu_dadangnhap()
        {
            InitializeComponent();
        }

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
            
        }

        public void AddItem(string ten, string loai, string mau, string tien, string anh)
        {
            flowLayoutPanel1.Controls.Add(new sanpham_trangchu()
            {
                spTen = ten,
                spLoai = loai,
                tenAnh = anh,
                spAnh = Image.FromFile("Resources/" + anh + "a.jpg"),
                spMau = mau,
                spTien = tien,
            });

        }
        private void trangchu_dadangnhap_Shown(object sender, EventArgs e)
        {
            AddItem("DÉP SANDAL ADIDAS ASTIR", "Originals", "Wonder Taupe / Off White / Shadow Red", "2.000.000₫", "1");
            AddItem("GIÀY SUPERSTAR", "Originals", "Cloud White / Core Black / Cloud White", "2.600.000₫", "2");
            AddItem("GIÀY FORUM 84 LOW", "Originals", "Off White / Off White / Cloud White", "2.800.000₫", "3");
            AddItem("DÉP SANDAL ADIDAS ASTIR", "Originals", "Wonder Taupe / Off White / Shadow Red", "2.000.000₫", "4");
            AddItem("GIÀY FORUM LOW", "Originals", "Cloud White / Core Black / Cloud White", "2.500.000", "5");
            AddItem("DÉP SANDAL ADIDAS ASTIR", "Originals", "Wonder Taupe / Off White / Shadow Red", "2.000.000₫", "6");
            AddItem("GIÀY FORUM 84 LOW", "Originals", "Off White / Off White / Cloud White", "2.800.000₫", "7");
            AddItem("GIÀY SUPERSTAR", "Originals", "Cloud White / Clear Pink / Pulse Magenta", "2.600.000₫", "8");
            AddItem("GIÀY FORUM 84 LOW", "Originals", "Off White / Off White / Cloud White", "2.800.000₫", "9");
            AddItem("GIÀY FORUM 84 LOW", "Originals", "Off White / Off White / Cloud White", "2.800.000₫", "10");

            AddItem("GIÀY SUPERSTAR", "Originals", "Cloud White / Clear Pink / Pulse Magenta", "2.600.000₫", "11");
            AddItem("GIÀY SUPERSTAR", "Originals", "Cloud White / Clear Pink / Pulse Magenta", "2.600.000₫", "12");
            AddItem("DÉP ADILETTE AYOON", "Originals", "Solar Green / Core Black / Solar Green", "1.400.000₫", "13");
            AddItem("GIÀY FORUM LOW", "Originals", "Cloud White / Core Black / Cloud White", "2.500.000", "14");
            AddItem("GIÀY SUPERSTAR", "Originals", "Cloud White / Core Black / Cloud White", "2.600.000₫", "15");
            AddItem("DÉP ADILETTE AYOON", "Originals", "Solar Green / Core Black / Solar Green", "1.400.000₫", "16");
            AddItem("DÉP ADILETTE AYOON", "Originals", "Solar Green / Core Black / Solar Green", "1.400.000₫", "17");
            AddItem("DÉP ADILETTE AYOON", "Originals", "Solar Green / Core Black / Solar Green", "1.400.000₫", "18");
            AddItem("DÉP SANDAL ADIDAS ASTIR", "Originals", "Wonder Taupe / Off White / Shadow Red", "2.000.000₫", "19");
            AddItem("GIÀY SUPERSTAR", "Originals", "Cloud White / Core Black / Cloud White", "2.600.000₫", "20");
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var sp = (sanpham_trangchu)item;
                sp.Visible = sp.sp_ten.Text.ToLower().ToLower().Contains(tb_timkiem.Text.Trim().ToLower());
            }

        }

        private void tb_timkiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || tb_timkiem.Text.Trim().Length == 0)
            {
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    var sp = (sanpham_trangchu)item;
                    sp.Visible = sp.sp_ten.Text.ToLower().ToLower().Contains(tb_timkiem.Text.Trim().ToLower());
                }
            }
        }

        private void pb_giohang_Click(object sender, EventArgs e)
        {
            this.Hide();
            GioHang gioHang = new GioHang();
            gioHang.ShowDialog();
            this.Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan login = new TaiKhoan();
            login.ShowDialog();
            this.Close();
        }
    }
}