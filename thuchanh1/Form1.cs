namespace thuchanh1
{
    public partial class Form1 : Form
    {
        public Form1()
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
            var newForm = new LichSuMuaHang();
            newForm.Show();
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
        private void Form1_Shown(object sender, EventArgs e)
        {
            AddItem("Adidas1", "Ori", "Trang", "10", "1");
            AddItem("Adidas2", "Ori", "Trang", "10", "2");
            AddItem("Adidas3", "Ori", "Trang", "10", "3");
            AddItem("Adidas4", "Ori", "Trang", "10", "4");
            AddItem("Adidas5", "Ori", "Trang", "10", "5");
            AddItem("Adidas6", "Ori", "Trang", "10", "6");
            AddItem("Adidas7", "Ori", "Trang", "10", "7");
            AddItem("Adidas8", "Ori", "Trang", "10", "8");
            AddItem("Adida9", "Ori", "Trang", "10", "9");
            AddItem("Adidas10", "Ori", "Trang", "10", "10");

            AddItem("Adidas11", "Ori", "Trang", "10", "11");
            AddItem("Adidas12", "Ori", "Trang", "10", "12");
            AddItem("Adidas13", "Ori", "Trang", "10", "13");
            AddItem("Adidas14", "Ori", "Trang", "10", "14");
            AddItem("Adidas15", "Ori", "Trang", "10", "15");
            AddItem("Adidas16", "Ori", "Trang", "10", "16");
            AddItem("Adidas17", "Ori", "Trang", "10", "17");
            AddItem("Adidas18", "Ori", "Trang", "10", "18");
            AddItem("Adidas19", "Ori", "Trang", "10", "19");
            AddItem("Adidas20", "Ori", "Trang", "10", "20");
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
    }
}