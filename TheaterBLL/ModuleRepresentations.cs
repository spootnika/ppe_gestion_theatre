using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterBO;
using TheaterDAL;

namespace TheaterBLL
{
    public class ModuleRepresentations
    {
        // objet BL
        private static ModuleRepresentations moduleRepresentations; 

        // Accesseur en lecture objet BLL
        public static ModuleRepresentations GetModuleRepresentations()
        {
            if (moduleRepresentations == null)
            {
                moduleRepresentations = new ModuleRepresentations();
            }
            return moduleRepresentations;
        }
        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL 
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }


        // Récupère la liste des représentations de la DAO, renvoie la liste
        // GetShows()
        public static List<Show> GetShows()
        {
            return RepresentationsDAO.GetShows();
        }

        // Récupère la liste des représentations filtrées de la DAO, renvoie la liste
        // GetFilterShows()

        public static List<Show> GetFilterShows(int idPiece, DateTime dateDeb, DateTime dateFin)
        {
            List<Show> lesRepresentationsFiltrees = new List<Show>();
            lesRepresentationsFiltrees = RepresentationsDAO.GetFilterShows(idPiece, dateDeb, dateFin);


            return lesRepresentationsFiltrees;
            
        }
        //surcharge s'il n'y a que la piece de choisie
        public static List<Show> GetFilterShows(int idPiece)
        {
            List<Show> lesRepresentationsFiltrees = new List<Show>();
            lesRepresentationsFiltrees = RepresentationsDAO.GetFilterShowsTheaterPiece(idPiece);


            return lesRepresentationsFiltrees;

        }
        //surcharge si il n'y a que les dates de choisies
        public static List<Show> GetFilterShows(DateTime dateDeb, DateTime dateFin)
        {
            List<Show> lesRepresentationsFiltrees = new List<Show>();
            lesRepresentationsFiltrees = RepresentationsDAO.GetFilterShowsDate(dateDeb, dateFin);


            return lesRepresentationsFiltrees;

        }

        // Renvoie le nombre de places restante pour une pièce
        public static int GetRemainingSeats(Show laRepres)
        {
            int nbRestant = RepresentationsDAO.GetSeatsBooked(laRepres.Show_id, laRepres.Show_seats);

            return nbRestant;
        }
    }
}
