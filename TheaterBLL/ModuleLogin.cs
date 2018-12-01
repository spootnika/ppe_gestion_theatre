using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterBO;

namespace TheaterBLL
{
    public class ModuleLogin
    {

        // objet BLL
        private static ModuleLogin moduleLogin;

        // Accesseur en lecture

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL 

        // Méthode qui renvoit un objet User correspondant au pseudo passé en paramètre
        public static AppUser GetUser(string pseudo)
        {

        }

        // Méthode qui créer ET RENVOIE un objet de LoginInfo avec les attributs de l'objet User passé en paramètre
        public static LoginInfo CreateLoginInfo(AppUser currentUser)
        {

        }

    }
}
