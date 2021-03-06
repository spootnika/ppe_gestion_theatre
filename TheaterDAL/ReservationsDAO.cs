﻿using System;
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
            if (uneReservationDAO == null)
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
            SqlDataReader readerToBook = null;

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
            readerToBook = cmdToBook.ExecuteReader();

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
                    while (readerToBook.Read())
                    {
                        int idSpect = Convert.ToInt32(readerToBook["toBook_spectator"].ToString());

                        // Si l'id du spectateur de to book est égale à celui de la requête précédente
                        if (idSpect == id)
                        {
                            // on récupère l'id du show et le nb de places
                            int idShow = Convert.ToInt32(readerToBook["toBook_show"].ToString());
                            nbPlaces = Convert.ToInt32(readerToBook["seatsBooked"].ToString());

                            bool trouve = false;
                            int i = 0;

                            // On trouve dans la liste des show celui correspondant à l'id
                            while (trouve == false && i < lesRepresentations.Count)
                            {
                                if (lesRepresentations[i].Show_id == idShow)
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
                    readerToBook.Close();
                    readerToBook = cmdToBook.ExecuteReader();

                    // Initialisation d'une nouvelle réservation et ajout dans la liste
                    uneReservation = new Spectator(id, nom, prenom, email, telephone, laRepresentation, nbPlaces);
                    lesReservations.Add(uneReservation);
                }

            }

            readerSpectators.Close();
            readerToBook.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return lesReservations;
        }

        // Ajout d'une nouvelle réservation
        public static void AddSpectator(Spectator uneReservation)
        {
            try
            {
                // Ouverture connaxion
                SqlConnection connexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                // Requête SQL ajout table Spectator
                // SELECT SCOPE_IDENTITY() : renvoie l'id de la ligne qui vient d'être ajoutée
                string reqAdd = "INSERT INTO Spectator (spectator_lastname, spectator_firstname, spectator_email, spectator_phone) VALUES (@lastname, @firstname, @email, @phone); SELECT SCOPE_IDENTITY()";

                SqlCommand commAddSpec = new SqlCommand(reqAdd, connexion);

                commAddSpec.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.VarChar, 255));
                commAddSpec.Parameters.Add(new SqlParameter("@firstname", System.Data.SqlDbType.VarChar, 255));
                commAddSpec.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 255));
                commAddSpec.Parameters.Add(new SqlParameter("@phone", System.Data.SqlDbType.VarChar, 255));

                commAddSpec.Parameters["@lastname"].Value = uneReservation.Spectator_lastname;
                commAddSpec.Parameters["@firstname"].Value = uneReservation.Spectator_firstname;
                commAddSpec.Parameters["@email"].Value = uneReservation.Spectator_email;
                commAddSpec.Parameters["@phone"].Value = uneReservation.Spectator_phone;

                // Exécution de la requête et récupération de l'id de la ligne qui vient d'être ajoutée
                int idSpec = Convert.ToInt32(commAddSpec.ExecuteScalar());

                // Requête SQL ajout table To_Book
                string reqAddBook = "INSERT INTO To_book (toBook_spectator, toBook_show, seatsBooked) VALUES (@spectator, @show, @seatsBooked)";
                connexion.Close();

                SqlConnection connexionBook = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand commAddBook = new SqlCommand(reqAddBook, connexionBook);

                commAddBook.Parameters.Add(new SqlParameter("@spectator", System.Data.SqlDbType.Int));
                commAddBook.Parameters.Add(new SqlParameter("@show", System.Data.SqlDbType.Int));
                commAddBook.Parameters.Add(new SqlParameter("@seatsBooked", System.Data.SqlDbType.Int));

                commAddBook.Parameters["@spectator"].Value = idSpec;
                commAddBook.Parameters["@show"].Value = uneReservation.Spectator_show.Show_id;
                commAddBook.Parameters["@seatsBooked"].Value = uneReservation.Spectator_seatsBooked;

                // Execution de la requête
                commAddBook.ExecuteNonQuery();

                // Connexion fermée
                connexionBook.Close();
            }
            catch (Exception e)
            {
                //Message box erreur
                string test = e.ToString();
            }

        }

        // Récupère le nombre de places prises pour une représentation
        public static int GetNbPlacesReservees(Show laRepresentation)
        {
            // Initialisation de la variable à un nombre négatif
            int nbPlacesReservees = -1;
            try
            {
                // Connexion DB
                SqlConnection connexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                // Requête SQL select nbplaces
                string reqPlacesRest = "SELECT SUM(seatsBooked) AS 'Nb Places Reservees' FROM To_book, Show WHERE toBook_show = show_id AND show_id = @idShow;";

                SqlCommand commPlacesRest = new SqlCommand(reqPlacesRest, connexion);

                commPlacesRest.Parameters.Add(new SqlParameter("@idShow", System.Data.SqlDbType.Int));
                commPlacesRest.Parameters["@idShow"].Value = laRepresentation.Show_id;

                SqlDataReader readerPlacesRest = null;
                readerPlacesRest = commPlacesRest.ExecuteReader();

                if (readerPlacesRest.HasRows)
                {
                    while (readerPlacesRest.Read())
                    {
                        nbPlacesReservees = Int32.Parse(readerPlacesRest["Nb Places Reservees"].ToString());
                    }
                }
                connexion.Close();
            }
            catch (Exception e)
            {

            }

            // Retourne le nombre de places réservées
            return nbPlacesReservees;
        }

        // Suppression d'une réservation
        public static string DeleteSpectator(Spectator laReservation)
        {
            try
            {
                SqlConnection connexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                string reqDelSpec = "DELETE FROM To_book WHERE toBook_spectator = @idSpec ; DELETE FROM Spectator WHERE spectator_id = @idSpec; ";

                SqlCommand commDelSpec = new SqlCommand(reqDelSpec, connexion);

                commDelSpec.Parameters.Add(new SqlParameter("@idSpec", System.Data.SqlDbType.Int));
                commDelSpec.Parameters["@idSpec"].Value = laReservation.Spectator_id;

                commDelSpec.ExecuteNonQuery();

                connexion.Close();

                return "Suppression effectuée";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        // Suppression des réservations en fonction de la pièce
        public static void RemoveSpectators(TheaterPiece unePiece)
        {
            try
            {
                SqlConnection connexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                string reqDelSpec = "DELETE FROM To_book WHERE toBook_show IN (SELECT show_id FROM Show WHERE show_theaterPiece = @idPiece) ; DELETE FROM Spectator WHERE spectator_id IN (SELECT toBook_spectator FROM To_Book, Show WHERE toBook_show = show_id AND show_theaterPiece = @idPiece ); ";

                SqlCommand commDelSpec = new SqlCommand(reqDelSpec, connexion);

                commDelSpec.Parameters.Add(new SqlParameter("@idPiece", System.Data.SqlDbType.Int));
                commDelSpec.Parameters["@idPiece"].Value = unePiece.TheaterPiece_id;

                commDelSpec.ExecuteNonQuery();

                connexion.Close();
            }
            catch (Exception e)
            {
                string error = e.Message;
            }
        }

        // Suppression des réservations en fonction du show
        public static void RemoveSpectators(int idShow)
        {
            try
            {
                SqlConnection connexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                string reqDelSpec = "DELETE FROM To_book WHERE toBook_show = @idShow ; DELETE FROM Spectator WHERE spectator_id IN (SELECT toBook_spectator FROM To_Book WHERE toBook_show =  @idShow ); ";

                SqlCommand commDelSpec = new SqlCommand(reqDelSpec, connexion);

                commDelSpec.Parameters.Add(new SqlParameter("@idShow", System.Data.SqlDbType.Int));
                commDelSpec.Parameters["@idShow"].Value = idShow;

                commDelSpec.ExecuteNonQuery();

                connexion.Close();
            }
            catch (Exception e)
            {
                string error = e.Message;
            }
        }

        // Edition d'une réservation
        public static string EditSpectator(Spectator laReservation)
        {
            try
            {
                SqlConnection connexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

                string reqEditSpec = "UPDATE Spectator SET spectator_lastname = @lastname, spectator_firstname = @firstname, spectator_email = @email, spectator_phone = @phone WHERE spectator_id = @id; UPDATE To_book SET toBook_show = @idShow, seatsBooked = @seatsBooked WHERE toBook_spectator = @id;";

                SqlCommand commeEditSpec = new SqlCommand(reqEditSpec, connexion);

                commeEditSpec.Parameters.Add(new SqlParameter("@id", System.Data.SqlDbType.Int));
                commeEditSpec.Parameters["@id"].Value = laReservation.Spectator_id;

                commeEditSpec.Parameters.Add(new SqlParameter("@lastname", System.Data.SqlDbType.VarChar, 255));
                commeEditSpec.Parameters["@lastname"].Value = laReservation.Spectator_lastname;

                commeEditSpec.Parameters.Add(new SqlParameter("@firstname", System.Data.SqlDbType.VarChar, 255));
                commeEditSpec.Parameters["@firstname"].Value = laReservation.Spectator_firstname;

                commeEditSpec.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 255));
                commeEditSpec.Parameters["@email"].Value = laReservation.Spectator_email;

                commeEditSpec.Parameters.Add(new SqlParameter("@phone", System.Data.SqlDbType.VarChar, 255));
                commeEditSpec.Parameters["@phone"].Value = laReservation.Spectator_phone;

                commeEditSpec.Parameters.Add(new SqlParameter("@idShow", System.Data.SqlDbType.Int));
                commeEditSpec.Parameters["@idShow"].Value = laReservation.Spectator_show.Show_id;

                commeEditSpec.Parameters.Add(new SqlParameter("@seatsBooked", System.Data.SqlDbType.Int));
                commeEditSpec.Parameters["@seatsBooked"].Value = laReservation.Spectator_seatsBooked;

                commeEditSpec.ExecuteNonQuery();

                connexion.Close();

                return "Edition effectuée avec succès !";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }

    }

}
