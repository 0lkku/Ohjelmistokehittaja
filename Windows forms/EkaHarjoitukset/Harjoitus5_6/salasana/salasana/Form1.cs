using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salasana
{
    public partial class SalasanaForm : Form
    {

        static string kayt = "Jyri";
        static string sala = "Ja@kk0ku1ta";

        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KayttajaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void SalasanaTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TarkistaTB_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == kayt && SalasanaTB.Text == sala)
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;

            } 
            else if(KayttajaTB.Text != kayt && SalasanaTB.Text == sala)
            {
                VirheViestiLB.Text = "Käyttäjätunnus on virheellinen!";
                VirheViestiLB.Visible = true;
                MessageBox.Show("ERROR: #001", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(VirheViestiLB.Text, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(KayttajaTB.Text == kayt && SalasanaTB.Text != sala)
            {
                VirheViestiLB.Text = "Salasana on virheellinen!";
                VirheViestiLB.Visible = true;
                MessageBox.Show("ERROR: #002", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(VirheViestiLB.Text, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VirheViestiLB.Text = "Käyttäjätunnus ja salasana ovat virheellisiä!";
                VirheViestiLB.Visible = true;
                MessageBox.Show("ERROR: #003", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(VirheViestiLB.Text, "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
