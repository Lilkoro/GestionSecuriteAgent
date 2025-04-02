using System;
using Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics.PerformanceData;

namespace Forms
{
    public partial class connForm : Form
    {
        Form form_central = new mainForm();

        Point middlePanel2 = new Point(326, 150);
        Point middlePanel1 = new Point(326, 66);

        classSqlConnection sqlConf = new classSqlConnection();
        
        public connForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelConn.Hide();
            panelInscr.Hide();
            erreurs.Hide();
            comboDroit.SelectedIndex = 0;
            List<Droit> droits = sqlConf.GetDroitFromDatabase();
            foreach (var droit in droits)
            {
                comboDroit.Items.Add(droit.id + " - " + droit.label);
            }
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            // VARIABLES
            string log = txtLogin.Text;
            string pass = txtPassword.Text;
            bool isValid = false;

            // Récupérer les utilisateurs à partir de sqlConf
            List<User> users = sqlConf.GetUsersFromDatabase();
            foreach (var user in users)
            {
                if (user.Login == log && user.Password == pass)
                {
                    isValid = true;
                    break;  // On peut arrêter la boucle si on a trouvé une correspondance
                }
            }

            if (isValid)
            {
                //MessageBox.Show("Vous êtes connecté", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                erreurs.Hide();
                form_central.Show();
                this.Hide();
            }
            else
            {
                erreurs.Show();
                //MessageBox.Show("Login ou Mot de passe incorrect, ressayé", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
		{
            if(e.KeyChar == (char)Keys.Return)
            {
                btnConn_Click(sender,e);
            }
		}

        private void btnMenuInscr_Click(object sender, EventArgs e)
        {
            panelConn.Hide();
            panelInscr.Show();
            panelInscr.Location = middlePanel1;

        }

        private void btnMenuConn_Click(object sender, EventArgs e)
        {
            panelConn.Location = middlePanel1;
            panelConn.Show();
            panelMenu.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelConn.Hide();
            panelMenu.Location = middlePanel2;
            erreurs.Hide();
            panelMenu.Show();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            panelInscr.Hide();
            panelInscr.Location = middlePanel2;
            erreurs.Hide();
            panelMenu.Show();
        }

        private void btnInscri1_Click(object sender, EventArgs e)
        {
            string login = txtIdd.Text;
            string mdp1 = txtPwd.Text;
            string mdp2 = txtConf.Text;
            int droit = comboDroit.SelectedIndex + 1;

            if(mdp1 != mdp2)
            {
                MessageBox.Show("Mots de passe différent ! ", "Erreur Mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Inscription inscription = new Inscription(login, mdp1, droit);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == char.Parse("*"))
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = char.Parse("*");
            }
        }
    }
}
