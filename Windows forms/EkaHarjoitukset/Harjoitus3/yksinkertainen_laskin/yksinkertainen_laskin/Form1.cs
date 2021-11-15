using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yksinkertainen_laskin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LukuYksiTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComBoxCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LakuriBT_Click(object sender, EventArgs e)
        {
            float lasku = 0;
            float luk1 = float.Parse(LukuYksiTB.Text);
            float luk2 = float.Parse(LukuKaksiTB.Text);
            string LasTapa = LaskutoimitusCB.Text;

            switch (LasTapa)
            {
                case ("+"):
                    lasku = (luk1 + luk2);
                    break;
                case ("-"):
                    lasku = (luk1 - luk2);
                    break;
                case ("*"):
                    lasku = (luk1 * luk2);
                    break;
                case ("/"):
                    if(luk2 == 0)
                    {
                        TekstiLB.Text = "jokin meni pieleen :(";
                        goto HYPPY;
                    }
                    else
                    {
                    lasku = (luk1 / luk2);
                    }
                    break;
                default:
                    TekstiLB.Text = "jokin meni pieleen :(";
                    goto HYPPY;
                    break;
            }
            TekstiLB.Text = lasku + "";
            HYPPY:
            TekstiLB.Visible = true;

        }
    }
}
