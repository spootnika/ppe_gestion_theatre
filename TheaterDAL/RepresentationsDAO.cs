using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterBO;

namespace TheaterDAL
{
    public class RepresentationsDAO
    {
        // objet PiecesTheatreDAO
        private static RepresentationsDAO uneRepresentationDAO;

        // Accesseur en lecture, renvoi une instance
        public static RepresentationsDAO GetRepresentationDAO()
        {
            if (uneRepresentationDAO == null)
            {
                uneRepresentationDAO = new RepresentationsDAO();
            }
            return uneRepresentationDAO;
        }

        // Renvoie la liste des représentations
        // Utilise la DAO PiecesTheatres pour avoir la liste des pièces
        // besoin du taux (et donc des jours)

        public static List<Show> GetShows()
        {
            //variables
            int idShow;
            DateTime uneDateHeure; //besoin de date et heure
            int nbPlaces;
            TheaterPiece laPiece; //besoin de nomPiece, durée 
            PriceRate letaux; //calcul du prix pour date, heure, semaine
            Show uneRepresentation=null;
    
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Show";

            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                idShow = Int32.Parse(monReader["show_id"].ToString());
                uneDateHeure = (DateTime)monReader["show_dateTime"];
                nbPlaces = Int32.Parse(monReader["show_seats"].ToString());
                letaux = (PriceRate)(monReader["show_priceRate"]);
                laPiece = (TheaterPiece)(monReader["show_theaterPiece"]);

                uneRepresentation = new Show(idShow, uneDateHeure,nbPlaces,letaux,laPiece);
                lesRepresentations.Add(uneRepresentation);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesRepresentations;
        }

        //renvoie le nombre de places réservées pour une représentation
        public int GetSeatsBooks(int idRepresentation, int nbPlacesTotal)
        {
            int nbPlacesRestantesPourUneRepresentation = 0;
            int nbPlacesReserveesPourUneRepresentation = 0;
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            SqlParameter paramid = new SqlParameter("@idShow", SqlDbType.NChar);
            paramid.Value = idRepresentation;
            cmd.CommandText = "SELECT * FROM To_book WHERE toBook_show == @idShow";
            cmd.Parameters.Add(paramid);

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                nbPlacesReserveesPourUneRepresentation = Int32.Parse(monReader["seatsBooked"].ToString());

            }
            // Fermeture de la connexion
            maConnexion.Close();

           
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Show WHERE show_id == @idShow";
            cmd2.Parameters.Add(paramid);
            SqlDataReader monReader2 = cmd2.ExecuteReader();
            while (monReader2.Read())
            {
                nbPlacesTotal = Int32.Parse(monReader["show_seats"].ToString());
            }
            // Fermeture de la connexion
            maConnexion.Close();

            nbPlacesRestantesPourUneRepresentation = nbPlacesTotal - nbPlacesRestantesPourUneRepresentation;
            
            return nbPlacesRestantesPourUneRepresentation;
        }

        // Renvoie la liste des représentations correspondant aux dates passées en paramètres
        public static List<Show> GetFilterShowsDate(DateTime dateDebutChoisie, DateTime dateFinChoisie)
        {
            //variables
            int idShow;
            DateTime uneDateHeure; //besoin de date et heure
            int nbPlaces;
            TheaterPiece laPiece; //besoin de nomPiece, durée 
            PriceRate letaux; //calcul du prix pour date, heure, semaine
            Show uneRepresentation;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            //paramètres
            
            SqlParameter paramDateDeb = new SqlParameter("@dateDeb", SqlDbType.NChar);
            paramDateDeb.Value = dateDebutChoisie;
            SqlParameter paramDateFin = new SqlParameter("@dateFin", SqlDbType.NChar);
            paramDateFin.Value = dateFinChoisie;

            //requête
            cmd.CommandText = "SELECT * FROM Show WHERE show_dateTime BETWEEN(@dateDeb AND @dateFin)";
            //ajout params
            cmd.Parameters.Add(paramDateDeb);
            cmd.Parameters.Add(paramDateFin);

            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                idShow = Int32.Parse(monReader["show_id"].ToString());
                uneDateHeure = (DateTime)monReader["show_dateTime"];
                nbPlaces = Int32.Parse(monReader["show_seats"].ToString());
                letaux = (PriceRate)(monReader["show_priceRate"]);
                laPiece = (TheaterPiece)(monReader["show_theaterPiece"]);

                uneRepresentation = new Show(idShow, uneDateHeure, nbPlaces, letaux, laPiece);
                lesRepresentations.Add(uneRepresentation);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesRepresentations;

        }

        // Renvoie la liste des représentations correspondant à la pièce de théâtre passée en paramètre
        public static List<Show> GetFilterShowsTheaterPiece(int idTheaterPiece)
        {
            //variables
            int idShow;
            DateTime uneDateHeure; //besoin de date et heure
            int nbPlaces;
            TheaterPiece laPiece; //besoin de nomPiece, durée 
            PriceRate letaux; //calcul du prix pour date, heure, semaine
            Show uneRepresentation;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            //paramètre
            SqlParameter paramIdPiece = new SqlParameter("@idPiece", SqlDbType.NChar);
            paramIdPiece.Value = idTheaterPiece;

            //requête
            cmd.CommandText = "SELECT show_id,show_dateTime, show_seats, show_priceRate, show_theaterPiece FROM Show, To_concern,  WHERE show_theaterPiece==theaterPiece_id AND theaterPiece_id==@idPiece ";
            //ajout params
            cmd.Parameters.Add(paramIdPiece);
 

            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                idShow = Int32.Parse(monReader["show_id"].ToString());
                uneDateHeure = (DateTime)monReader["show_dateTime"];
                nbPlaces = Int32.Parse(monReader["show_seats"].ToString());
                letaux = (PriceRate)(monReader["show_priceRate"]);
                laPiece = (TheaterPiece)(monReader["show_theaterPiece"]);

                uneRepresentation = new Show(idShow, uneDateHeure, nbPlaces, letaux, laPiece);
                lesRepresentations.Add(uneRepresentation);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesRepresentations;

        }

        // Renvoie la liste des représentations correspondant à la pièce de théatres ayant lieu durant une période passée en paramètres
        public static List<Show> GetFilterShows(int idTheaterPiece, DateTime dateDebutChoisie, DateTime dateFinChoisie)
        {
            //variables
            int idShow;
            DateTime uneDateHeure; //besoin de date et heure
            int nbPlaces;
            TheaterPiece laPiece; //besoin de nomPiece, durée 
            PriceRate letaux; //calcul du prix pour date, heure, semaine
            Show uneRepresentation;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            //paramètres

            SqlParameter paramIdPiece = new SqlParameter("@idPiece", SqlDbType.NChar);
            paramIdPiece.Value = idTheaterPiece;
            SqlParameter paramDateDeb = new SqlParameter("@dateDeb", SqlDbType.NChar);
            paramDateDeb.Value = dateDebutChoisie;
            SqlParameter paramDateFin = new SqlParameter("@dateFin", SqlDbType.NChar);
            paramDateFin.Value = dateFinChoisie;
            //requête
            cmd.CommandText = "SELECT show_id,show_dateTime, show_seats, show_priceRate, show_theaterPiece FROM Show, To_concern,  WHERE show_theaterPiece==theaterPiece_id AND theaterPiece_id==@idPiece AND show_dateTime BETWEEN(@dateDeb AND @dateFin)";
            //ajout params
            cmd.Parameters.Add(paramIdPiece);
            cmd.Parameters.Add(paramDateDeb);
            cmd.Parameters.Add(paramDateFin);


            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                idShow = Int32.Parse(monReader["show_id"].ToString());
                uneDateHeure = (DateTime)monReader["show_dateTime"];
                nbPlaces = Int32.Parse(monReader["show_seats"].ToString());
                letaux = (PriceRate)(monReader["show_priceRate"]);
                laPiece = (TheaterPiece)(monReader["show_theaterPiece"]);

                uneRepresentation = new Show(idShow, uneDateHeure, nbPlaces, letaux, laPiece);
                lesRepresentations.Add(uneRepresentation);
            }
            // Fermeture de la connexion
            maConnexion.Close();
            return lesRepresentations;

        }

    }
}
