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
            int idShow = 0;
            DateTime uneDateHeure = new DateTime(2018, 01, 01, 00, 00, 00); //besoin de date et heure
            int nbPlaces = 0;
            TheaterPiece laPiece = null; //besoin de nomPiece, durée 
            PriceRate letaux = null; //calcul du prix pour date, heure, semaine
            Show uneRepresentation = null;


            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();

            // Récupération de la liste des pièces de théâtre
            List<TheaterPiece> lesPiecesDeTheatre = PiecesTheatreDAO.GetTheaterPieces();

            // Récupération de la liste des taux
            List<PriceRate> lesTaux = GetPriceRateWeeksDays();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

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
                int idDutaux = Convert.ToInt32(monReader["show_priceRate"].ToString());
                int idPiece = Convert.ToInt32(monReader["show_theaterPiece"].ToString());

                // On trouve dans la liste des pièces de théâtres celle correspondant à l'id
                bool trouve = false;
                int i = 0;
                while (trouve == false && i < lesPiecesDeTheatre.Count)
                {
                    if (lesPiecesDeTheatre[i].TheaterPiece_id == idPiece)
                    {
                        // Si on l'a, on l'ajoute
                        laPiece = lesPiecesDeTheatre[i];
                        trouve = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                bool trouve2 = false;
                int i2 = 0;
                while (trouve2 == false && i2 < lesTaux.Count)
                {
                    if (lesTaux[i2].PriceRate_id == idDutaux)
                    {
                        // Si on l'a, on l'ajoute
                        letaux = lesTaux[i2];
                        trouve2 = true;
                    }
                    else
                    {
                        i2++;
                    }
                }
                uneRepresentation = new Show(idShow, uneDateHeure, nbPlaces, letaux, laPiece);
                lesRepresentations.Add(uneRepresentation);
            }

            monReader.Close();

            // Fermeture de la connexion
            maConnexion.Close();
            return lesRepresentations;
        }

        //ajout d'une représentation
        public static int AddShow(Show uneRepresentation)
        {
            int nb;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "INSERT INTO Show(show_dateTime,show_seats,show_priceRate,show_theaterPiece) values( @dateRepresentation ,@nbPlacesRepresentation,@priceRateRepresentation, @pieceDeTheatreRepresentation)";
            //param
            SqlParameter dateRep = new SqlParameter("@dateRepresentation", SqlDbType.DateTime);
            dateRep.Value = uneRepresentation.Show_dateTime;
            cmd.Parameters.Add(dateRep);
            SqlParameter nbPlaces = new SqlParameter("@nbPlacesRepresentation", SqlDbType.Int);
            nbPlaces.Value = uneRepresentation.Show_seats;
            cmd.Parameters.Add(nbPlaces);
            SqlParameter priceRate = new SqlParameter("@priceRateRepresentation", SqlDbType.Int);
            priceRate.Value = uneRepresentation.Show_priceRate.PriceRate_id;
            cmd.Parameters.Add(priceRate);
            SqlParameter pieceDeTheatre = new SqlParameter("@pieceDeTheatreRepresentation", SqlDbType.Int);
            pieceDeTheatre.Value = uneRepresentation.Show_theaterPiece.TheaterPiece_id;
            cmd.Parameters.Add(pieceDeTheatre);
            //fin param
            nb = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nb;
        }

        //suppression d'un représentation
        public static int DelShow(int IdRep)
        {
            int nb;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "DELETE FROM Show WHERE show_id = @idShow";
            //param
            SqlParameter idShow = new SqlParameter("@idShow", SqlDbType.Int);
            idShow.Value = IdRep;
            cmd.Parameters.Add(idShow);
            //fin param
            nb = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            maConnexion.Close();

            return nb;
        }
        //modification d'un représentation
        public static int ModifShow(Show uneRepresentation)
        {
            try
            {
                int nb;

                // Connexion à la BD
                SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                cmd.CommandText = "UPDATE Show SET show_dateTime=@dateRepresentation, show_seats=@nbPlacesRepresentation, show_priceRate=@priceRateRepresentation, show_theaterPiece=@pieceDeTheatreRepresentation WHERE show_id = @idShow";
                //param
                SqlParameter idShow = new SqlParameter("@idShow", SqlDbType.Int);
                idShow.Value = uneRepresentation.Show_id;
                cmd.Parameters.Add(idShow);
                SqlParameter dateRep = new SqlParameter("@dateRepresentation", SqlDbType.DateTime);
                dateRep.Value = uneRepresentation.Show_dateTime;
                cmd.Parameters.Add(dateRep);
                SqlParameter nbPlaces = new SqlParameter("@nbPlacesRepresentation", SqlDbType.Int);
                nbPlaces.Value = uneRepresentation.Show_seats;
                cmd.Parameters.Add(nbPlaces);
                SqlParameter priceRate = new SqlParameter("@priceRateRepresentation", SqlDbType.Int);
                priceRate.Value = uneRepresentation.Show_priceRate.PriceRate_id;
                cmd.Parameters.Add(priceRate);
                SqlParameter pieceDeTheatre = new SqlParameter("@pieceDeTheatreRepresentation", SqlDbType.Int);
                pieceDeTheatre.Value = uneRepresentation.Show_theaterPiece.TheaterPiece_id;
                cmd.Parameters.Add(pieceDeTheatre);
                //fin param
                nb = cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                maConnexion.Close();

                return nb;
            }
            catch(Exception e)
            {
                string error = e.Message;
                return 0;
            }
        }
        //renvoie le nombre de places réservées pour une représentation
        public static int GetSeatsBooked(int idRepresentation, int nbPlacesTotal)
        {
            int nbPlacesRestantesPourUneRepresentation = 0;
            int nbPlacesReserveesPourUneRepresentation = 0;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM To_book WHERE toBook_show = @idShow";

            SqlParameter paramid = new SqlParameter("@idShow", SqlDbType.NChar);
            paramid.Value = idRepresentation;
            cmd.Parameters.Add(paramid);

            SqlDataReader monReader = cmd.ExecuteReader();
            while (monReader.Read())
            {
                nbPlacesReserveesPourUneRepresentation += Int32.Parse(monReader["seatsBooked"].ToString());

            }
            monReader.Close();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = maConnexion;
            cmd2.CommandText = "SELECT * FROM Show WHERE show_id = @idShow";

            SqlParameter paramid2 = new SqlParameter("@idShow", SqlDbType.NChar);
            paramid2.Value = idRepresentation;
            cmd2.Parameters.Add(paramid2);

            SqlDataReader monReader2 = cmd2.ExecuteReader();

            while (monReader2.Read())
            {
                nbPlacesTotal = Int32.Parse(monReader2["show_seats"].ToString());
            }
            monReader2.Close();
            // Fermeture de la connexion
            maConnexion.Close();

            nbPlacesRestantesPourUneRepresentation = nbPlacesTotal - nbPlacesReserveesPourUneRepresentation;

            return nbPlacesRestantesPourUneRepresentation;
        }

        // Renvoie la liste des représentations correspondant aux dates passées en paramètres
        public static List<Show> GetFilterShowsDate(DateTime dateDebutChoisie, DateTime dateFinChoisie)
        {
            //variables
            int idShow;
            DateTime uneDateHeure; //besoin de date et heure
            int nbPlaces;
            int idPiece; //besoin de nomPiece, durée 
            int idtaux; //calcul du prix pour date, heure, semaine
            Show uneRepresentation;
            PriceRate letaux = null;
            TheaterPiece laPiece = null;
            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();
            // Récupération de la liste des pièces de théâtre
            List<TheaterPiece> lesPiecesDeTheatre = PiecesTheatreDAO.GetTheaterPieces();
            // Récupération de la liste des taux
            List<PriceRate> lesTaux = GetPriceRateWeeksDays();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

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
                idtaux = Convert.ToInt32(monReader["show_priceRate"].ToString());
                idPiece = Convert.ToInt32(monReader["show_theaterPiece"]);

                // On trouve dans la liste des pièces de théâtres celle correspondant à l'id
                bool trouve = false;
                int i = 0;
                while (trouve == false && i < lesPiecesDeTheatre.Count)
                {
                    if (lesPiecesDeTheatre[i].TheaterPiece_id == idPiece)
                    {
                        // Si on l'a, on l'ajoute
                        laPiece = lesPiecesDeTheatre[i];
                        trouve = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                // On trouve dans la liste des pièces de théâtres celle correspondant à l'id
                bool trouve2 = false;
                int i2 = 0;
                while (trouve2 == false && i2 < lesTaux.Count)
                {
                    if (lesTaux[i2].PriceRate_id == idtaux)
                    {
                        // Si on l'a, on l'ajoute
                        letaux = lesTaux[i2];
                        trouve2 = true;
                    }
                    else
                    {
                        i2++;
                    }
                }
                uneRepresentation = new Show(idShow, uneDateHeure, nbPlaces, letaux, laPiece);
                lesRepresentations.Add(uneRepresentation);
            }
            monReader.Close();
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
            int idTaux;
            int idPiece;
            TheaterPiece laPiece = null; //besoin de nomPiece, durée 
            PriceRate letaux = null; //calcul du prix pour date, heure, semaine
            Show uneRepresentation;

            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();
            // Récupération de la liste des taux
            List<PriceRate> lesTaux = GetPriceRateWeeksDays();
            // Récupération de la liste des pièces de théâtre
            List<TheaterPiece> lesPiecesDeTheatre = PiecesTheatreDAO.GetTheaterPieces();

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            //paramètre
            SqlParameter paramIdPiece = new SqlParameter("@idPiece", SqlDbType.NChar);
            paramIdPiece.Value = idTheaterPiece;

            //requête
            cmd.CommandText = "SELECT show_id,show_dateTime, show_seats, show_priceRate, show_theaterPiece FROM Show, Theater_piece WHERE show_theaterPiece=theaterPiece_id AND theaterPiece_id=@idPiece ";
            //ajout params
            cmd.Parameters.Add(paramIdPiece);


            SqlDataReader monReader = cmd.ExecuteReader();
            // Remplissage de la liste
            while (monReader.Read())
            {
                idShow = Int32.Parse(monReader["show_id"].ToString());
                uneDateHeure = (DateTime)monReader["show_dateTime"];
                nbPlaces = Int32.Parse(monReader["show_seats"].ToString());
                idTaux = Int32.Parse(monReader["show_priceRate"].ToString());
                idPiece = Int32.Parse(monReader["show_theaterPiece"].ToString());

                bool trouve = false;
                int i = 0;
                while (trouve == false && i < lesPiecesDeTheatre.Count)
                {
                    if (lesPiecesDeTheatre[i].TheaterPiece_id == idPiece)
                    {
                        // Si on l'a, on l'ajoute
                        laPiece = lesPiecesDeTheatre[i];
                        trouve = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                // On trouve dans la liste des pièces de théâtres celle correspondant à l'id
                bool trouve2 = false;
                int i2 = 0;
                while (trouve2 == false && i2 < lesTaux.Count)
                {
                    if (lesTaux[i2].PriceRate_id == idTaux)
                    {
                        // Si on l'a, on l'ajoute
                        letaux = lesTaux[i2];
                        trouve2 = true;
                    }
                    else
                    {
                        i2++;
                    }
                }
                uneRepresentation = new Show(idShow, uneDateHeure, nbPlaces, letaux, laPiece);
                lesRepresentations.Add(uneRepresentation);
            }
            monReader.Close();
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
            int idTaux;
            int idPiece;
            TheaterPiece laPiece = null; //besoin de nomPiece, durée 
            PriceRate letaux = null; //calcul du prix pour date, heure, semaine
            Show uneRepresentation;
            // Récupération de la liste des pièces de théâtre
            List<TheaterPiece> lesPiecesDeTheatre = PiecesTheatreDAO.GetTheaterPieces();
            // Récupération de la liste des taux
            List<PriceRate> lesTaux = GetPriceRateWeeksDays();
            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            // Création d'une liste vide d'objets lesRepresentations
            List<Show> lesRepresentations = new List<Show>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            //paramètres

            SqlParameter paramIdPiece = new SqlParameter("@idPiece", SqlDbType.Int);
            paramIdPiece.Value = idTheaterPiece;
            SqlParameter paramDateDeb = new SqlParameter("@dateDeb", SqlDbType.VarChar);
            string date1;
            date1 = dateDebutChoisie.ToString("yyyy/MM/dd");
            paramDateDeb.Value = date1;
            SqlParameter paramDateFin = new SqlParameter("@dateFin", SqlDbType.VarChar);
            string date2;
            date2 = dateFinChoisie.ToString("yyyy/MM/dd");
            paramDateFin.Value = date2;
            //requête
            cmd.CommandText = "SELECT show_id,show_dateTime, show_seats, show_priceRate, show_theaterPiece FROM Show, Theater_piece WHERE show_theaterPiece = theaterPiece_id AND theaterPiece_id = @idPiece AND CAST(show_dateTime as DATE) BETWEEN @dateDeb AND @dateFin";
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
                idTaux = Int32.Parse(monReader["show_priceRate"].ToString());
                idPiece = Int32.Parse(monReader["show_theaterPiece"].ToString());
                bool trouve = false;
                int i = 0;
                while (trouve == false && i < lesPiecesDeTheatre.Count)
                {
                    if (lesPiecesDeTheatre[i].TheaterPiece_id == idPiece)
                    {
                        // Si on l'a, on l'ajoute
                        laPiece = lesPiecesDeTheatre[i];
                        trouve = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                // On trouve dans la liste des pièces de théâtres celle correspondant à l'id
                bool trouve2 = false;
                int i2 = 0;
                while (trouve2 == false && i2 < lesTaux.Count)
                {
                    if (lesTaux[i2].PriceRate_id == idTaux)
                    {
                        // Si on l'a, on l'ajoute
                        letaux = lesTaux[i2];
                        trouve2 = true;
                    }
                    else
                    {
                        i2++;
                    }
                }
                uneRepresentation = new Show(idShow, uneDateHeure, nbPlaces, letaux, laPiece);
                lesRepresentations.Add(uneRepresentation);
            }
            monReader.Close();
            // Fermeture de la connexion
            maConnexion.Close();
            return lesRepresentations;

        }

        //GetPriceRateWeeksDays renvoie la liste des taux en fonction de la semaine
        public static List<PriceRate> GetPriceRateWeeksDays()
        {
            List<PriceRate> lesTaux = new List<PriceRate>();
            List<WeekDays> lesJoursSemaine = new List<WeekDays>();
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            //récupération de la liste des semaines
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = maConnexion;
            cmd2.CommandText = "SELECT * FROM Week_days";
            SqlDataReader monReader2 = cmd2.ExecuteReader();
            int idJour;
            string nomJour;
            WeekDays leJour = null;
            // Remplissage de la liste
            while (monReader2.Read())
            {
                idJour = Int32.Parse(monReader2["weekDays_id"].ToString());
                nomJour = monReader2["weekDays_name"].ToString();

                leJour = new WeekDays(idJour, nomJour);

                lesJoursSemaine.Add(leJour);
            }
            monReader2.Close();

            //récupération de la liste des priceRate en fonction du jour de la semaine
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            int idTaux;
            string nomTaux;
            TimeSpan debutHeure;
            TimeSpan finHeure;
            float tauxApplique;
            PriceRate leTaux;


            cmd.CommandText = "SELECT * from Price_rate";

            SqlCommand cmdConcern = new SqlCommand();
            cmdConcern.Connection = maConnexion;
            cmdConcern.CommandText = "SELECT * FROM To_concern";

            SqlDataReader monReader = cmd.ExecuteReader();

            while (monReader.Read())
            {
                List<WeekDays> lesJoursTaux = new List<WeekDays>();
                idTaux = Int32.Parse(monReader["priceRate_id"].ToString());
                nomTaux = monReader["priceRate_name"].ToString();
                debutHeure = (TimeSpan)monReader["priceRate_startTime"];
                finHeure = (TimeSpan)monReader["priceRate_endTime"];
                tauxApplique = float.Parse(monReader["priceRate_rate"].ToString());

                SqlDataReader readerConcern = cmdConcern.ExecuteReader();
                while (readerConcern.Read())
                {
                    int idConcernTaux = Int32.Parse(readerConcern["toConcern_priceRate"].ToString());

                    if (idTaux == idConcernTaux)
                    {
                        int idConcernJour = Int32.Parse(readerConcern["toConcern_weekDays"].ToString());

                        bool trouve = false;
                        int ind = 0;

                        while (trouve == false && ind < lesJoursSemaine.Count)
                        {
                            if (lesJoursSemaine[ind].WeekDays_id == idConcernJour)
                            {
                                lesJoursTaux.Add(lesJoursSemaine[ind]);
                                trouve = true;
                            }
                            else
                            {
                                ind++;
                            }
                        }
                    }
                }
                readerConcern.Close();

                leTaux = new PriceRate(idTaux, nomTaux, debutHeure, finHeure, tauxApplique, lesJoursTaux);
                lesTaux.Add(leTaux);
            }
            monReader.Close();
            // Fermeture de la connexion
            maConnexion.Close();
            return lesTaux;
        }
    }
}
