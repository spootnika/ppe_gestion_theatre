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
    public class ModuleReservations
    {

        private static ModuleReservations moduleReservation; // objet BLL

        // Accesseur en lecture
        public static ModuleReservations GetModuleReservation()
        {
            if (moduleReservation == null)
            {
                moduleReservation = new ModuleReservations();
            }
            return moduleReservation;
        }



        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL 
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

        // Récupère la liste des réservations de la DAO, renvoie la liste
        public static List<Spectator> GetSpectators()
        {
            List<Spectator> lesReservations = ReservationsDAO.GetSpectators();

            return lesReservations;
        }

        // Ajoute une réservation dans la DB
        public static void AddSpectator(Spectator uneReservation)
        {
            ReservationsDAO.AddSpectator(uneReservation);
        }
    }
}
