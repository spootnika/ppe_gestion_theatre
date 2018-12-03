using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TheaterBO; // Réference la couche BO
using TheaterDAL; // Réference la couche DAL

namespace TheaterBLL
{
    public class ModuleLogin
    {
        
        private static ModuleLogin moduleLogin; // objet BLL
        
        // Accesseur en lecture
        public static ModuleLogin GetModuleLogin()
        {
            if (moduleLogin == null)
            {
                moduleLogin = new ModuleLogin();
            }
            return moduleLogin;
        }



        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL 
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Méthode qui renvoit un objet User correspondant au pseudo passé en paramètre
        public static AppUser GetUser(string pseudo)
        {
            return LoginDAO.GetUser(pseudo);
        }

        // Méthode qui créer ET RENVOIE un objet de LoginInfo avec les attributs de l'objet User passé en paramètre
        public static LoginInfo CreateLoginInfo(AppUser currentUser)
        {
            LoginInfo login;
            login = new LoginInfo(currentUser);

            return login;
        }

    }
}
