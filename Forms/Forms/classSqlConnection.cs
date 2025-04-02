using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    // Utilisation d'une class pour récuperer tout les utilisateurs de la base de données
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Droit { get; set; }
    }

    public class Droit
    {
        public string label { get; set;}
        public int id { get; set;}
    }
    public class classSqlConnection
    {
        // Création d'un connecteur, une requête SQL pour récupérer les utilisateurs pouvant se connecter, passage des info dans les Objets.
        string connectionString = "Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=";
        string selectUsers = "SELECT * FROM user";
        string selectDroit = "SELECT * FROM Droit;";
        // Déclaration de la liste d'utilisateurs en public
        public List<User> users { get; private set; } = new List<User>();
        public List<User> GetUsersFromDatabase()
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(selectUsers, conn);
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                // Remplir la liste avec les utilisateurs
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string login = reader["login"].ToString();
                    string password = reader["password"].ToString();
                    int droit = int.Parse(reader["droit"].ToString());

                    users.Add(new User { Id = id, Login = login, Password = password, Droit = droit });
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return users;
        }

        public List<Droit> droits { get; private set; } = new List<Droit>();
        public List<Droit> GetDroitFromDatabase()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(selectDroit, conn);
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                // Remplir la liste avec les utilisateurs
                while (reader.Read())
                {
                    string label = reader["label"].ToString();
                    int id = int.Parse(reader["id"].ToString());

                    droits.Add(new Droit { label = label, id = id});
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return droits;
        }

    }
    // Classe publique User pour stocker login et password


}
