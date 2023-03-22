namespace thuchanh1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }

        ImageList imgList;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        void LoadImageView()
        {
            imgList = new ImageList();
            imgList.ImageSize = new Size(250, 250);
            String[] paths = { };
            paths = Directory.GetFiles("D:\\thuc_hanh\\c#\\thuchanh1\\thuchanh1\\Images\\trangchu\\");
            try
            {
                foreach (String path in paths)
                {
                    imgList.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void LoadListView()
        {
            LoadImageView();

            listView1.LargeImageList = imgList;
            listView1.Items.Add("Gi�y Forum 84 Low", 0);
            listView1.Items.Add("Gi�y Superstar Ayoon", 1);
            listView1.Items.Add("Gi�y Adi2000 X", 2);
            listView1.Items.Add("D�p Adilette Ayoon", 3);
            listView1.Items.Add("Gi�y Forum 84 Low", 4);
            listView1.Items.Add("Gi�y NMD_R1", 5);
            listView1.Items.Add("D�p adilette Lite", 6);
            listView1.Items.Add("D�p Sandal adidas �tir", 7);
            listView1.Items.Add("hello", 8);
            listView1.Items.Add("hello", 9);
            listView1.Items.Add("hello", 10);
            listView1.Items.Add("hello", 11);
            listView1.Items.Add("hello", 12);
            listView1.Items.Add("Gi�y Forum Low", 13);
            listView1.Items.Add("Gi�y SAMBAROSE", 14);
            listView1.Items.Add("Gi�y Stan Smith", 15);
            listView1.Items.Add("Gi�y Superstar", 16);
            listView1.Items.Add("hello", 17);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;

        }
    }
}