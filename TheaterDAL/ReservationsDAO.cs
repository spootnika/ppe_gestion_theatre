using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterBO;
using System.Data.SqlClient;
using System.Data;


namespace TheaterDAL
{
    public class ReservationsDAO
    {
        // objet ReservationDAO
        private static ReservationsDAO uneReservationDAO;

        // Accesseur en lecture, renvoi une instance
        public static ReservationsDAO GetReservationsDAO()
        {
            if(uneReservationDAO == null)
            {
                uneReservationDAO = new ReservationsDAO();
            }
            return uneReservationDAO;
        }

        // Renvoie la liste des réservations
        // Nécessite les représentations et pièces de théâtre
        // Besoin des tables spectator et toBook
        // GetSpectators()
        public static List<Spectator> GetSpectators()
        {
            // Définition des variables
            List<Spectator> lesReservations;
            int id = 0;
            string nom = "";
            string prenom = "";
            string email = "";
            string telephone = "";
            int nbPlaces = 0;
            SqlConnection maConnexion;

            // Récupération de la liste des représentations
            List<Show> lesRepresentations;
            lesRepresentations = GetShows();

            // Connexion à la DB
            maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Initialisation d'un reader
            SqlDataReader monReader = null;

            // Initialisation et écriture d'une requête SQL

            // Execution du reader

            // Verification de la valeur du retour

            // Fermeture de la connexion
            lesRepresentations = new Spectator();

            return lesReservations;
        }

    }
}
