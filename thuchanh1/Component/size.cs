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
    public partial class size : UserControl
    {
        public size()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button3.BackColor = Color.Black;
            button3.ForeColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button10.BackColor = Color.Black;
            button10.ForeColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button8.BackColor = Color.Black;
            button8.ForeColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button9.BackColor = Color.Black;
            button9.ForeColor = Color.White;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button7.BackColor = Color.Black;
            button7.ForeColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button6.BackColor = Color.Black;
            button6.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button5.BackColor = Color.Black;
            button5.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Button> lisbtn = new List<Button>
            {
                button3, button4, button5, button6, button7, button8, button9, button10
            };
            foreach (Button button in lisbtn)
            {

                if (button.BackColor == Color.Black)
                {
                    button.BackColor = Color.WhiteSmoke;
                    button.ForeColor = Color.Black;
                    break;
                }
            }
            button4.BackColor = Color.Black;
            button4.ForeColor = Color.White;
        }
    }
}
