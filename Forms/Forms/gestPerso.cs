using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class gestPerso : Form
    {
        public gestPerso()
        {
            InitializeComponent();
        }

        // List typé par le paramètre <Personnel>
        private List<Personnel> lesPersonnels = new List<Personnel>();

        //Fonction de remplissage de la liste 
        private void majList()
        {
            listBPerso.Items.Clear();
            foreach(Personnel unePers in lesPersonnels)
            {
                // Ajoute info() redéfinie selon la class fille concernée.
                listBPerso.Items.Add(unePers.info());
            }
        }

        private void gestPerso_Load(object sender, EventArgs e)
        {
            radEns.Checked = true;

        }

        private void radEns_CheckedChanged(object sender, EventArgs e)
        {
            if (radEns.Checked == true)
            {
                labHeure.Visible = true;
                txtBHeure.Visible = true;
                labSer.Visible = false;
                txtBService.Visible = false;
            }
            else
            {
                labHeure.Visible = false;
                txtBHeure.Visible = false;
                labSer.Visible = true;
                txtBService.Visible = true;
            }
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            // Permet de faciliter l'instanciation des Class fille : Class var = new class(..) devient => var = new class(..)
            Personnel unePers;
            
            //ajout d'un personnel selon son type
            if(radEns.Checked)
            {
                unePers = new enseignant(txtBNom.Text, txtBPre.Text, int.Parse(txtBHeure.Text));
            } else
            {
                unePers = new admin(txtBNom.Text, txtBPre.Text, txtBService.Text);
            }

            lesPersonnels.Add(unePers);
            majList();
            txtBService.Clear();
            txtBPre.Clear();
            txtBNom.Clear();
            txtBHeure.Clear();
        }
    }
}
