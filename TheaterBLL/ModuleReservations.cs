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
            //List<Spectator> lesReservations = ReservationsDAO.GetSpectators();

            List<Spectator> lesReservations = new List<Spectator>();
            Company company1 = new Company(1, "Act for fun", "Paris", "IDF", "Dubois");

            Nationality nationality1 = new Nationality(1, "Anglais");
            List<Nationality> lesNationalites  = new List<Nationality>();
            lesNationalites.Add(nationality1);

            PublicType publicType1 = new PublicType(1, "famille");

            Theme theme1 = new Theme(1, "Comique");

            Author author1 = new Author(1, "Moliere", "nnn", lesNationalites);
            TheaterPiece piece1 = new TheaterPiece(1, "la pièce 1", "c'est une piece", 2.5f, 25, company1, author1, publicType1, theme1);

            WeekDays jour1 = new WeekDays(1, "Lundi");
            WeekDays jour2 = new WeekDays(2, "Mardi");
            List<WeekDays> lesJours1 = new List<WeekDays>();
            lesJours1.Add(jour1);
            lesJours1.Add(jour2);
            PriceRate taux1 = new PriceRate(1, "apremSem", new DateTime(2018,01,01,12,00,00), new DateTime(2018,01,01,17,00,00), 10, lesJours1);
            Show show1 = new Show(1, new DateTime(2018,12,14,15,00,00), 140, taux1, piece1);
            Spectator reserv1 = new Spectator(1, "Dupont", "Jean", "email@mail.com", "0000000000", show1, 3);

            lesReservations.Add(reserv1);

            return lesReservations;
        }
    }
}
