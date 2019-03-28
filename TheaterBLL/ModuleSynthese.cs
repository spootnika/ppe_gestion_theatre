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
            return SyntheseDAO.GetShows(laPiece); //faire surcharge de getShow(lapice)
        }

        //- une méthode qui renvoie le nombre de représentations SUR UNE PERIODE pour une pièce    *GetNbShows(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin) *
        //  Appel de la requête SQL GetFilterShowsDate(), puis tris de la liste pour en construire une avec seulement les shows concernés par la pièce passée en param et renvoie cette nouvelle liste
        public static int GetNbShows(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetFilterShowsDate(laPiece, dateDebut, dateFin);
        }
        //- une méthode qui renvoie le nombre total de spectateur pour une pièce    *GetNbSpectators(TheaterPiece laPiece) *
        //  Appel de la requête SQL GetSpectators(), on compte le nombre de spectateurs (addition de tous les seatsBooked) qui sont concernés par la pièce passée en param(spectator.show.piece.id == laPiece.id) et on renvoie ce nombre.
        public static int GetNbSpectators(TheaterPiece laPiece)
        {
            return SyntheseDAO.GetSpectators(laPiece);
        }
        //- une méthode qui renvoie le nombre total de spectateur SUR UNE PERIODE pour une pièce* GetNbSpectators(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)*
        //  Appel de la requête SQL GetSpectators() et appel de la requête SQL GetFilterShowsDate(), on compte le nombre de spectateurs(addition de tous les seatsBooked) qui sont concernés par ces show et on renvoie ce nombre.
        public static int GetNbSpectators(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetSpectators(laPiece, dateDebut, dateFin);
        }
        //- une méthode qui renvoie le CA total réalisé pour une pièce* GetCaTotal(TheaterPiece laPiece)*
        //  Appel de la requête SQL GetSpectators(), pour chaque spectator concerné par la pièce passée en param, on calcule le prix qu'il a payé et on l'ajoute à une variable qui récupère le total.On renvoi ce total.
        public static float GetCaTotal(TheaterPiece laPiece)
        {
            return SyntheseDAO.GetCatotal(laPiece);
        }
        //- une méthode qui renvoie le CA total réalisé SUR UNE PERIODE pour une pièce   *GetCaTotal(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin) *
        //  Appel de la requête SQL GetSpectators() et appel de la requête SQL GetFilterShowsDate(), pour chaque spectator concerné par un des shows de la période, on calcule le prix qu'il a payé et on l'ajoute à une variable qui récupère le total. On renvoi ce total.
        public static float GetCaTotal(TheaterPiece laPiece, DateTime dateDebut, DateTime dateFin)
        {
            return SyntheseDAO.GetCatotal(laPiece, dateDebut, dateFin);
        }
        //Les deux valeurs moyennes dont on a besoin peuvent être calculées en dur dans l'appli :
        //- nb de spectateur moyen = nb de spectateurs / nb de représentations
        //- CA moyen réalisé = CA total réalise / nb de représentations
    }
}
