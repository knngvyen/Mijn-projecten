using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circusdieren
{
    public partial class Hoofdmenu : Form
    {
        public Hoofdmenu()
        {
            InitializeComponent();
        }
        Trein treintje = new Trein();
        private void btnvoegdiertoe_Click(object sender, EventArgs e)
        {
            bool vleeseter = false;
            Grootte grootte = new Grootte();

            if (tbnaamdier.Text == "")
            {
                MessageBox.Show("Voer iets in");

            }

            if (cbvleesteter.Checked)
            {
                vleeseter = true;
            }

            if (rdbklein.Checked)
            {
                grootte = Grootte.Klein;
            }

            if (rdbnormaal.Checked)
            {
                grootte = Grootte.Middel;
            }

            if (rdbgroot.Checked)
            {
                grootte = Grootte.Groot;
            }

            treintje.VoegDierToe((new Dier(tbnaamdier.Text, vleeseter, grootte)));
            int y = 0;
            foreach (Wagon w in treintje.wagonlijst)
            {
                Label l = new Label();
                l.Text = w.ToString();
                l.Location = new Point(10, 25 * y + 10);
                l.AutoSize = true;
                y += 1;
                pbwagon.Controls.Add(l);
;           }
        }

      
    }
}
