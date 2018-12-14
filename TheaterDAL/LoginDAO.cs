using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TheaterBO;
using System.Data;

namespace TheaterDAL
{
    public class LoginDAO
    {
        private static LoginDAO unUtilisateurDAO;

        // Accesseur en lecture, renvoi une instance de LoginDAO
        public static LoginDAO GetUtilisateurDAO()
        {
            if (unUtilisateurDAO == null)
            {
                unUtilisateurDAO = new LoginDAO();
            }
            return unUtilisateurDAO;
        }


        //retourne un utilisateur en fonction de son pseudo
        public static AppUser GetUser(string pseudo)
        {
            // définition des variables
            AppUser unUtilisateur;
            int id = 0;
            string password = "";
            bool isAdmin = false;
            SqlConnection maConnexion;
            
            // Connexion à la BD
            maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
           
            // initialisationn d'un reader
            SqlDataReader monReader = null;
            
            // initialisation et écriture d'une requête sql
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            SqlParameter paramPseudo = new SqlParameter("@pseudo", SqlDbType.NChar);
            paramPseudo.Value = pseudo;
          
            cmd.CommandText = "SELECT * FROM AppUser WHERE user_pseudo = @pseudo";
            cmd.Parameters.Add(paramPseudo);
            // execution du reader
            monReader = cmd.ExecuteReader();

            // vérif si retourne quelque chose ou non
            if (monReader.HasRows)
            {
                // while reader

                while (monReader.Read())
                {
                    id = Convert.ToInt32(monReader["user_id"].ToString());
                    password = monReader["user_password"].ToString();
                    isAdmin = (bool)monReader["user_isAdmin"];
                }
            }

            unUtilisateur = new AppUser(id, pseudo, password, isAdmin);
            monReader.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return unUtilisateur;

        }
    }
}
