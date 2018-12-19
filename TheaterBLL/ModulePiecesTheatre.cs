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
    public class ModulePiecesTheatre
    {
        // objet BLL
        private static ModulePiecesTheatre modulePieceTheatre;

        // Accesseur en lecture objet BLL
        public static ModulePiecesTheatre GetModulePiecesTheatre()
        {
            if (modulePieceTheatre == null)
            {
                modulePieceTheatre = new ModulePiecesTheatre();
            }
            return modulePieceTheatre;
        }

        // Récupère la liste des pièces de la DAO, renvoie la liste
        public static List<TheaterPiece> GetTheaterPieces()
        {
            List<TheaterPiece> lesPiecesTheatre = PiecesTheatreDAO.GetTheaterPieces();
            return lesPiecesTheatre;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

    }
}
