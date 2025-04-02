using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Forms
{
    internal class Inscription
    {
        public Inscription(string login, string password, int droit) {
            SetNewMember(login,password,droit);
        }
        public bool SetNewMember(string login, string password, int droit)
        {
            classSqlConnection sqlConn = new classSqlConnection();
            List<User> users = sqlConn.GetUsersFromDatabase();
            foreach(var uuser in users)
            {
                if(uuser.Login == login && uuser.Password == password)
                {
                    MessageBox.Show("Il y a eu un problème ! ", "Ajout Membre", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            string conf = "Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=";
            using (MySqlConnection conn = new MySqlConnection(conf))
            {
                string query = "INSERT INTO `users` (`id`, `login`, `password`, `droit`) VALUES (NULL, @login, @password, @droit);";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    // Ouverture de la connexion
                    conn.Open();

                    // Ajout des paramètres pour éviter les injections SQL
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@droit", droit - 1);

                    // Exécution de la requête
                    int result = command.ExecuteNonQuery(); // Retourne le nombre de lignes affectées
                    if (result > 0)
                    {
                        MessageBox.Show("Vous avez ajouté un nouveaux membre !", "Ajout Membre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Il y a eu un problème ! ", "Ajout Membre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

        }
    }
}
