using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh1.Component
{
    public partial class in4chitiet : UserControl
    {
        public in4chitiet()
        {
            InitializeComponent();


        }

        public in4chitiet(string tenanh, string lbnb1, string txnb1, string lbnb2, string txnb2, string lbnb3, string txnb3, string lbmt1, string txmt1, string txct1, string txct2, string txct3, string txct4)
        {
            InitializeComponent();

            in4_lbnb1 = lbnb1;
            in4_txnb1 = txnb1;
            in4_imgnb1 = Image.FromFile("Resources/" + tenanh + "a.jpg");

            in4_lbnb2 = lbnb2;
            in4_txnb2 = txnb2;
            in4_imgnb2 = Image.FromFile("Resources/" + tenanh + "b.jpg");

            in4_lbnb3 = lbnb3;
            in4_txnb3 = txnb3;
            in4_imgnb3 = Image.FromFile("Resources/" + tenanh + "c.jpg");

            in4_lbmt1 = lbmt1;
            in4_txmt1 = txmt1;
            in4_imgmt1 = Image.FromFile("Resources/" + tenanh + "d.jpg");

            in4_txct1 = txct1;
            in4_txct2 = txct2;
            in4_txct3 = txct3;
            in4_txct4 = txct4;


        }


        public string in4_lbnb1 { get => label3.Text; set => label3.Text = value; }
        public string in4_txnb1 { get => label4.Text; set => label4.Text = value; }
        public Image in4_imgnb1 { get => pictureBox6.BackgroundImage; set => pictureBox6.BackgroundImage = value; }


        public string in4_lbnb2 { get => label8.Text; set => label8.Text = value; }
        public string in4_txnb2 { get => label7.Text; set => label7.Text = value; }
        public Image in4_imgnb2 { get => pictureBox7.BackgroundImage; set => pictureBox7.BackgroundImage = value; }


        public string in4_lbnb3 { get => label10.Text; set => label10.Text = value; }
        public string in4_txnb3 { get => label9.Text; set => label9.Text = value; }
        public Image in4_imgnb3 { get => pictureBox8.BackgroundImage; set => pictureBox8.BackgroundImage = value; }

        public string in4_lbmt1 { get => label13.Text; set => label13.Text = value; }
        public string in4_txmt1 { get => label12.Text; set => label12.Text = value; }
        public Image in4_imgmt1 { get => pictureBox9.BackgroundImage; set => pictureBox9.BackgroundImage = value; }


        public string in4_txct1 { get => label15.Text; set => label15.Text = value; }
        public string in4_txct2 { get => label16.Text; set => label16.Text = value; }
        public string in4_txct3 { get => label17.Text; set => label17.Text = value; }
        public string in4_txct4 { get => label18.Text; set => label18.Text = value; }
        public string in4_txct5 { get => label19.Text; set => label19.Text = value; }
        public string in4_txct6 { get => label20.Text; set => label20.Text = value; }



        private string tenanh;
        public string tenAnh { get => tenanh; set => tenanh = value; }
    }
}
