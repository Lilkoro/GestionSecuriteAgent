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
    public partial class mainForm : Form
    {
        Form frm_score = new frm_score();
        EnreCompt frm_enre = new EnreCompt();
        gestPerso frm_perso = new gestPerso();
        public mainForm()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_score.ShowDialog();
        }

        private void enregistrementCompetiteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_enre.ShowDialog();
        }

        private void gestionPersonnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_perso.ShowDialog();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
