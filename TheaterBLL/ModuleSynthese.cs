using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterBO; // Réference la couche BO
using TheaterDAL; // Réference la couche DAL
using System.Configuration;

namespace TheaterBLL
{
    public class ModuleSynthese
    {
        // objet BL
        private static ModuleSynthese moduleSynthese;

        // Accesseur en lecture objet BLL
        public static ModuleSynthese GetModuleRepresentations()
        {
            if (moduleSynthese == null)
            {
                moduleSynthese = new ModuleSynthese();
            }
            return moduleSynthese;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL 
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }


        //- une méthode qui renvoie toutes les pièces(ça c'est simple)    *GetTheaterPieces()*
        //  Appel de la requête SQL GetTheaterPieces(), puis renvoie de la liste complète
       public static List<TheaterPiece> GetTheaterPieces()
        {
            List<TheaterPiece> theaterPieces = PiecesTheatreDAO.GetTheaterPieces();
            return theaterPieces;
        }

        //- une méthode qui renvoie le nombre de représentations pour une pièce* GetNbShows(TheaterPiece laPiece) *
        //  Appel de la requête SQL GetShows(), puis tris de la liste pour en construire une avec seulement les shows concernés par la pièce passée en param et renvoie cette nouvelle liste
        public static int GetNbShows(TheaterPiece laPiece)
        {
            List<Show> shows= RepresentationsDAO.GetShows();
            int nbShows = 0;
            foreach (Show unshow in shows)
            {
                if (unshow.Show_theaterPiece.TheaterPiece_id == laPiece.TheaterPiece_id)
                {
                    nbShows++;
                }
            }
            return nbShows;
        }

        //- une méthode qui renvoie le nombre de représentations SUR UNE PERIODE pour une pièce    *GetNbShows(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin) *
        //  Appel de la requête SQL GetFilterShowsDate(), puis tris de la liste pour en construire une avec seulement les shows concernés par la pièce passée en param et renvoie cette nouvelle liste
        public static int GetNbShows(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)
        {
            List<Show> shows= RepresentationsDAO.GetFilterShows(laPiece.TheaterPiece_id, dateDebut, dateFin);
            int nbShows = 0;
            foreach (Show unshow in shows)
            {
                if (unshow.Show_theaterPiece.TheaterPiece_id == laPiece.TheaterPiece_id)
                {
                    nbShows++;
                }
            }
            return nbShows;
        }
        //- une méthode qui renvoie le nombre total de spectateur pour une pièce    *GetNbSpectators(TheaterPiece laPiece) *
        //  Appel de la requête SQL GetSpectators(), on compte le nombre de spectateurs (addition de tous les seatsBooked) qui sont concernés par la pièce passée en param(spectator.show.piece.id == laPiece.id) et on renvoie ce nombre.
        public static int GetNbSpectators(TheaterPiece laPiece)
        {
            List<Spectator> spectators= ReservationsDAO.GetSpectators();
            int nbSpectators = 0;
            foreach (Spectator unSpectateur in spectators)
            {
                if (unSpectateur.Spectator_show.Show_theaterPiece.TheaterPiece_id == laPiece.TheaterPiece_id)
                {
                    nbSpectators = nbSpectators + unSpectateur.Spectator_seatsBooked;
                }              
            }
            return nbSpectators;

        }
        //- une méthode qui renvoie le nombre total de spectateur SUR UNE PERIODE pour une pièce* GetNbSpectators(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)*
        //  Appel de la requête SQL GetSpectators() et appel de la requête SQL GetFilterShowsDate(), on compte le nombre de spectateurs(addition de tous les seatsBooked) qui sont concernés par ces show et on renvoie ce nombre.
        public static int GetNbSpectators(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)
        {
            List<Spectator> spectators = ReservationsDAO.GetSpectators(); //liste spectateurs
            List<Show> shows = RepresentationsDAO.GetFilterShows(laPiece.TheaterPiece_id, dateDebut, dateFin);//listes des shows à une date donnée
            int nbSpectators = 0;
            foreach(Show unShow in shows)
            {
                foreach(Spectator unSpectateur in spectators)
                {
                    if(laPiece.TheaterPiece_id== unSpectateur.Spectator_show.Show_theaterPiece.TheaterPiece_id && laPiece.TheaterPiece_id == unShow.Show_theaterPiece.TheaterPiece_id)
                    {
                        nbSpectators = nbSpectators + unSpectateur.Spectator_seatsBooked;
                    }
                }
            }
            return nbSpectators;

        }
        //- une méthode qui renvoie le CA total réalisé pour une pièce* GetCaTotal(TheaterPiece laPiece)*
        //  Appel de la requête SQL GetSpectators(), pour chaque spectator concerné par la pièce passée en param, on calcule le prix qu'il a payé et on l'ajoute à une variable qui récupère le total.On renvoi ce total.
        public static float GetCaTotal(TheaterPiece laPiece)
        {
            List<Spectator> spectators = ReservationsDAO.GetSpectators();
            float prixTotal = 0;
            foreach(Spectator unSpectateur in spectators)
            {
                if(laPiece.TheaterPiece_id == unSpectateur.Spectator_show.Show_theaterPiece.TheaterPiece_id)
                {
                    float prixaPayer = unSpectateur.Spectator_seatsBooked * (laPiece.TheaterPiece_seatsPrice + laPiece.TheaterPiece_seatsPrice * unSpectateur.Spectator_show.Show_priceRate.PriceRate_rate);
                    prixTotal = prixTotal + prixaPayer;
                }
            }
            return prixTotal;
           
        }
        //- une méthode qui renvoie le CA total réalisé SUR UNE PERIODE pour une pièce   *GetCaTotal(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin) *
        //  Appel de la requête SQL GetSpectators() et appel de la requête SQL GetFilterShowsDate(), pour chaque spectator concerné par un des shows de la période, on calcule le prix qu'il a payé et on l'ajoute à une variable qui récupère le total. On renvoi ce total.
        public static float GetCaTotal(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)
        {
            List<Spectator> spectators = ReservationsDAO.GetSpectators(); //liste spectateurs
            List<Show> shows = RepresentationsDAO.GetFilterShows(laPiece.TheaterPiece_id, dateDebut, dateFin);//listes des shows à une date donnée
            float prixTotal = 0;
            foreach (Show unShow in shows)
            {
                foreach (Spectator unSpectateur in spectators)
                {
                    if (laPiece.TheaterPiece_id == unSpectateur.Spectator_show.Show_theaterPiece.TheaterPiece_id && laPiece.TheaterPiece_id == unShow.Show_theaterPiece.TheaterPiece_id)
                    {
                        float prixaPayer = unSpectateur.Spectator_seatsBooked * (laPiece.TheaterPiece_seatsPrice + laPiece.TheaterPiece_seatsPrice * unSpectateur.Spectator_show.Show_priceRate.PriceRate_rate);
                        prixTotal = prixTotal + prixaPayer;
                    }
                }
            }
            return prixTotal;
        }
        //Les deux valeurs moyennes dont on a besoin peuvent être calculées en dur dans l'appli :
        //- nb de spectateur moyen = nb de spectateurs / nb de représentations
        //- CA moyen réalisé = CA total réalise / nb de représentations
    }
}
