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
        public static List<Spectator> GetSpectators()
        {
            // Définition des variables
            List<Spectator> lesReservations = new List<Spectator>();

            Spectator uneReservation;
            int id = 0;
            string nom = "";
            string prenom = "";
            string email = "";
            string telephone = "";
            int nbPlaces = 0;
            Show laRepresentation = null;
            SqlConnection maConnexion;

            // Récupération de la liste des représentations
            List<Show> lesRepresentations = RepresentationsDAO.GetShows();
            
            // Connexion à la DB
            maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Initialisation de deux readers
            SqlDataReader readerSpectators = null;
            SqlDataReader readearToBook = null;

            // Initialisation et écriture d'une requête SQL pour récupérer tous les spectators
            SqlCommand cmdSpectators = new SqlCommand();
            cmdSpectators.Connection = maConnexion;
            cmdSpectators.CommandText = "SELECT * FROM Spectator";
            
            // Initialisation et écriture d'une requête SQL pour récupérer la table To Book
            SqlCommand cmdToBook = new SqlCommand();
            cmdToBook.Connection = maConnexion;
            cmdToBook.CommandText = "SELECT * FROM To_book";

            // Execution du reader spectators
            readerSpectators = cmdSpectators.ExecuteReader();
            readearToBook = cmdToBook.ExecuteReader();

            // Verification de la valeur du retour
            if (readerSpectators.HasRows)
            {
                // while reader
                while (readerSpectators.Read())
                {
                    // assignation des valeurs retournées par la requêtes aux variables concernées
                    id = Convert.ToInt32(readerSpectators["spectator_id"].ToString());
                    nom = readerSpectators["spectator_lastname"].ToString();
                    prenom = readerSpectators["spectator_firstname"].ToString();
                    email = readerSpectators["spectator_email"].ToString();
                    telephone = readerSpectators["spectator_phone"].ToString();
                    
                    // Déclanchement du reader sur la table To Book pour récupérer la liaison avec le show et le nbPlaces
                    while (readearToBook.Read())
                    {
                        int idSpect = Convert.ToInt32(readearToBook["toBook_spectator"].ToString());

                        // Si l'id du spectateur de to book est égale à celui de la requête précédente
                        if (idSpect == id)
                        {
                            // on récupère l'id du show et le nb de places
                            int idShow = Convert.ToInt32(readearToBook["toBook_show"].ToString());
                            nbPlaces = Convert.ToInt32(readearToBook["seatsBooked"].ToString());

                            bool trouve = false;
                            int i = 0;

                            // On trouve dans la liste des show celui correspondant à l'id
                            while (trouve == false && i < lesRepresentations.Count)
                            {
                                if(lesRepresentations[i].Show_id == idShow)
                                {
                                    // Si on l'a, on l'ajoute
                                    laRepresentation = lesRepresentations[i];
                                    trouve = true;
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }
                    // Initialisation d'une nouvelle réservation et ajout dans la liste
                    uneReservation = new Spectator(id, nom, prenom, email, telephone, laRepresentation, nbPlaces);
                    lesReservations.Add(uneReservation);
                }

            }

            readerSpectators.Close();
            readearToBook.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return lesReservations;
        }

    }
}
