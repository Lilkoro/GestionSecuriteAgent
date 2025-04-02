using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public class test
    {
        public void aaa()
        {
            // Création d'un connecteur, une requête SQL pour récupérer les utilisateurs pouvant se connecter, passage des info dans les Objets.
            string connectionString = "Server=localhost;Port=3306;Database=csharp;Uid=root;Pwd=";
            string mysql = "SELECT login, password, droit FROM users";
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                MySqlCommand command = new MySqlCommand(mysql, conn);
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();

                // Remplir la liste avec les utilisateurs
                while (reader.Read())
                {
                    string login = reader["login"].ToString();
                    string password = reader["password"].ToString();
                    int droit = int.Parse(reader["droit"].ToString());
                }
                reader.Close();
                conn.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
