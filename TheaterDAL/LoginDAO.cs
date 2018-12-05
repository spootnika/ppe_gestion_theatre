using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TheaterBO;

namespace TheaterDAL
{
    public class LoginDAO
    {
        private static LoginDAO unUtilisateurDAO;

        // Accesseur en lecture, renvoi une instance
        public static LoginDAO GetUser()
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
            int id;
            string password;
            bool isAdmin;
     
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM AppUser WHERE user_pseudo = '" + pseudo + "'";

            SqlDataReader monReader = cmd.ExecuteReader();
         
            id = Int32.Parse(monReader["user_id"].ToString());
            password = monReader["user_password"].ToString();
            isAdmin = (bool)monReader["user_isAdmin"];
            AppUser unUtilisateur = new AppUser(id, pseudo, password, isAdmin);

            
            // Fermeture de la connexion
            maConnexion.Close();
            return unUtilisateur;
        }
       }
   }
