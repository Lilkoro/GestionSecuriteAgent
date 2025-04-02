using MySql.Data.MySqlClient;
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
    public partial class gestAgents : Form
    {
        public gestAgents()
        {
            InitializeComponent();
        }

        classSqlConnection sqlConf = new classSqlConnection();
        public List<User> users { get; private set; } = new List<User>();

        private void gestAgents_Load(object sender, EventArgs e)
        {
            users = sqlConf.GetUsersFromDatabase(); // Remplir la liste users
            foreach (var agent in users)
            {
                comboAgent.Items.Add("ID : " + agent.Id + " - Droit : " + agent.Droit + " - Login : " + agent.Login);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string txtPassword = txtPass.Text;
            string txtLogin = txtLog.Text;
            int selectedIndex = comboAgent.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < comboAgent.Items.Count)
            {
                string selectedItem = comboAgent.Items[selectedIndex].ToString();
                string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
                string idPart = parts[0]; // "ID : {Id}"
                string idValue = idPart.Split(new string[] { "ID : " }, StringSplitOptions.None)[1].Trim();

                // Convertir l'ID en entier
                if (int.TryParse(idValue, out int id))
                {
                    string query = "UPDATE `user` SET `login` = @login, `password` = @password WHERE `id` = @id;";
                    string conf = "Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=";

                    using (MySqlConnection conn = new MySqlConnection(conf))
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        // Ouverture de la connexion
                        conn.Open();

                        // Ajout des paramètres pour éviter les injections SQL
                        command.Parameters.AddWithValue("@login", txtLogin);
                        command.Parameters.AddWithValue("@password", txtPassword);
                        command.Parameters.AddWithValue("@id", id);

                        // Exécution de la requête
                        int result = command.ExecuteNonQuery(); // Retourne le nombre de lignes affectées
                        if (result > 0)
                        {
                            MessageBox.Show("Les informations de l'utilisateur ont été mises à jour avec succès !", "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Il y a eu un problème lors de la mise à jour des informations de l'utilisateur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné ou index hors limites.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cBoxMDP_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == char.Parse("*"))
            {
                txtPass.PasswordChar = (char)0;
            }
            else
            {
                txtPass.PasswordChar = char.Parse("*");
            }
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboAgent.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < comboAgent.Items.Count)
            {
                string selectedItem = comboAgent.Items[selectedIndex].ToString();
                string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);
                string idPart = parts[0]; // "ID : {Id}"
                string idValue = idPart.Split(new string[] { "ID : " }, StringSplitOptions.None)[1].Trim();

                // Convertir l'ID en entier
                if (int.TryParse(idValue, out int id))
                {
                    // Parcourir la liste des agents pour trouver l'agent correspondant à l'ID
                    User agent = users.FirstOrDefault(a => a.Id == id);
                    if (agent != null)
                    {
                        string login = agent.Login;
                        string motDePasse = agent.Password; // Assumant que la propriété MotDePasse existe dans la classe User
                        labSelAgent.Text = "Selection de l'agent : ";
                        labSelAgent.Text = labSelAgent.Text + login;
                        txtLog.Text = login;
                        txtPass.Text = motDePasse;
                        panel1.Visible = true;
                        Console.WriteLine($"Agent trouvé : ID = {agent.Id}, Login = {login}, MotDePasse = {motDePasse}");
                    }
                    else
                    {
                        Console.WriteLine("Aucun agent trouvé avec cet ID.");
                    }
                }
                else
                {
                    Console.WriteLine("ID invalide.");
                }
            }
            else
            {
                Console.WriteLine("Aucun élément sélectionné ou index hors limites.");
            }
        }
    }
}
