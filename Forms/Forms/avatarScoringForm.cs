using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frm_score : Form
    {
        // Variables accessibles dans tout le code
        int cptScore = 0;
        int score = 0;
        int[] tab = new int[99];

        public frm_score()
        {
            InitializeComponent();

        }

        private void frm_score_Load(object sender, EventArgs e)
        {
            //Affichage du score 
            lab_score.Text = "SCORE : " + cptScore;
        }


		private void list_plat_SelectedIndexChanged(object sender, EventArgs e)
		{
            // Initialisation des instances d'image dans leurs chemin relatif.
            string imgJeux = (listPlatform.Text).ToLower();
            switch(imgJeux)
            {
                case "ordinateur":
                    Bitmap pc = new Bitmap(@"../../img/ordi.png");
                    imgChange.Image = pc;
                    break;
                case "nintendo switch":
                    Bitmap nswitch = new Bitmap("../../img/switch.png");
                    imgChange.Image = nswitch;
                    break;
                case "playstation 5":
                    Bitmap ps5 = new Bitmap("../../img/ps5.jpg");
                    imgChange.Image = ps5;
                    break;
                case "playstation 4":
                    Bitmap ps4 = new Bitmap("../../img/ps4.png");
                    imgChange.Image = ps4;
                    break;
                case "xbox serie s":
                    Bitmap serieS = new Bitmap("../../img/serieS.png");
                    imgChange.Image = serieS;
                    break;
                case "xbox one":
                    Bitmap one = new Bitmap("../../img/one.png");
                    imgChange.Image = one;
                    break;
                case "xbox 360":
                    Bitmap x360 = new Bitmap("../../img/360.jpg");
                    imgChange.Image = x360;
                    break;

            }
		}

		private void button3_Click(object sender, EventArgs e)
		{
            // Calcule des toute les valeurs qui sont dans la list tab.
			tot_scr.Visible = true;
			tot_scr.Text = "Totale des scores : " + tab.Sum();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
            // Rendre visible la partie score seulement lorsque les derniers radio button sont validés.
            bool check1 = rBtnH1.Checked;
            bool check3 = rBtnH3.Checked;
            bool check2 = rBtnH2.Checked;

            if (check1 == true || check2 == true || check3 == true)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

		private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
		{
            // Lorsque l'utilisateur appuie sur entrée après avoir rentré un score il est comptabilisé directement.
            if (e.KeyChar == (char)Keys.Return)
            {
                button1_Click(sender, e);
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            // Gestion de l'ajout des scores dans la liste.
            cptScore++;
            score = int.Parse(txtScore.Text);
			tab[cptScore] = score;
            txtScore.Clear();
			lab_score.Text = "SCORE : " + cptScore;
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            clear();
        }

        public void clear()
        {
            txtPseudo.Text = "";
            txtAge.Text = "";
            rBtnF.Checked = false;
            rBtnM.Checked = false;
            listPlatform.SelectedIndex = default;
            imgChange.Image = default;
            rBtnH1.Checked = false;
            rBtnH2.Checked = false;
            rBtnH3.Checked = false;
            txtScore.Text = null;
            cptScore = 0;
        }
    }
}
