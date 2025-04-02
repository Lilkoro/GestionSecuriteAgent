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
    public partial class EnreCompt : Form
    {
        public EnreCompt()
        {
            InitializeComponent();
        }

        private candidats[] list_candidats = new candidats[100];
        private int nbCandidats = 0;
        private void majListCandidats()
        {
            listCandidats.Items.Clear();
            for (int i = 0; i < nbCandidats; i++)
            {
                listCandidats.Items.Add(list_candidats[i].getNom() + " " + list_candidats[i].getPrenom() + " est en compétition, age : " + list_candidats[i].getAge());
            }
        }

        private void rechercheAgeMax()
        {
            if(nbCandidats == 0)
            {
                txtBPlusAge.Text = " ";
            } else
            {
                int ageMax = 0;
                for(int k = 1; k < nbCandidats; k++)
                {
                    if (list_candidats[k].getAge() > list_candidats[ageMax].getAge())
                    {
                        ageMax = k;
                    }
                }
                txtBPlusAge.Text = list_candidats[ageMax].getNom() + " - " + list_candidats[ageMax].getPrenom() + " - " + list_candidats[ageMax].getAge() + " ans";
            }
        }

        private void txtBAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                candidats c_indivi = new candidats(txtBNom.Text, txtBPrenom.Text, int.Parse(txtBAge.Text));
                if(c_indivi.getAge() >= 20)
                {
                    txt_aff_indivi.Text = c_indivi.getNom() + " " + c_indivi.getPrenom() + " est en compétition, age : " + c_indivi.getAge();
                    nbCandidats++;
                    list_candidats[nbCandidats - 1] = c_indivi;
                    majListCandidats();
                    rechercheAgeMax();
                } else
                {
                    txt_aff_indivi.Text = "Hors classement !";
                }
                txtBPrenom.Clear();
                txtBNom.Clear();
                txtBAge.Clear();
            }
        }

        private void EnreCompt_Load(object sender, EventArgs e)
        {

        }
    }
}
