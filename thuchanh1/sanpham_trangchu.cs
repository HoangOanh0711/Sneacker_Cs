using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh1
{
    public partial class sanpham_trangchu : UserControl
    {
        public event EventHandler OnSekect = null;
        public sanpham_trangchu()
        {
            InitializeComponent();
        }

        private void sp_anh_Click(object sender, EventArgs e)
        {

        }

        private void sanpham_trangchu_Click(object sender, EventArgs e)
        {
            OnSekect?.Invoke(this, e);
        }
        public string spTien { get => sp_giatien.Text; set => sp_giatien.Text = value; }
        public string spTen { get => sp_ten.Text; set => sp_ten.Text = value; }
        public string spLoai { get => sp_loai.Text; set => sp_loai.Text = value; }
        public string spMau { get => sp_mau.Text; set => sp_mau.Text = value; }
        public Image spAnh { get => sp_anh.BackgroundImage; set => sp_anh.BackgroundImage = value; }
    }
}
