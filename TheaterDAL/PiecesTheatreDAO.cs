using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterBO; // Référence à la couche BO
using System.Data.SqlClient;

namespace TheaterDAL
{
    public class PiecesTheatreDAO
    {
        // objet PiecesTheatreDAO
        private static PiecesTheatreDAO unePieceTheatreDAO;

        // Accesseur en lecture, renvoi une instance
        public static PiecesTheatreDAO GetPiecesTheatreDAO()
        {
            if (unePieceTheatreDAO == null)
            {
                unePieceTheatreDAO = new PiecesTheatreDAO();
            }
            return unePieceTheatreDAO;
        }

        // Renvoie toutes les pièces de théâtre, liste
        public static List<TheaterPiece> GetTheaterPieces()
        {
            int id;
            string nom;
            string description;
            float duree;
            float prix;
            Company laCompagnie;
            Author leAuteur;
            PublicType leType;
            Theme leTheme;
   
            TheaterPiece unePieceTheatre;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objet TheaterPiece
            List<TheaterPiece> lesTheatres = new List<TheaterPiece>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Theater_piece";

            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["theaterPiece_id"].ToString());
                if (monReader["theaterPiece_name"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["theaterPiece_name"].ToString();
                }

                if (monReader["theaterPiece_description"] == DBNull.Value)
                {
                    description = default(string);
                }
                else
                {
                    description = monReader["theaterPiece_description"].ToString();
                }

                duree = float.Parse(monReader["theaterPiece_duration"].ToString());
                prix = float.Parse(monReader["theaterPiece_seatsPrice"].ToString());
                laCompagnie = (Company)monReader["theaterPiece_company"];
                leAuteur = (Author)monReader["theaterPiece_author"];
                leType = (PublicType)monReader["theaterPiece_publicType"];
                leTheme = (Theme)monReader["theaterPiece_theme"];

                unePieceTheatre = new TheaterPiece(id, nom, description, duree, prix, laCompagnie, leAuteur, leType, leTheme);
                lesTheatres.Add(unePieceTheatre);
            }

            // Fermeture de la connexion
            maConnexion.Close();

            return lesTheatres;
              
        }
    }
}
