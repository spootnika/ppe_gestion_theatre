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

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = maConnexion;
            cmd2.CommandText = "SECLECT * FROM Author";

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = maConnexion;
            cmd3.CommandText = "SELECT * FROM Theme";

            SqlCommand cmd4 = new SqlCommand();
            cmd4.Connection = maConnexion;
            cmd4.CommandText = "SECLECT * FROM Public_Type";

            SqlCommand cmd5 = new SqlCommand();
            cmd5.Connection = maConnexion;
            cmd5.CommandText = "SECLECT * FROM Public_Type";

            SqlDataReader monReader = cmd.ExecuteReader();
            SqlDataReader monReader2 = cmd2.ExecuteReader();
            SqlDataReader monReader3 = cmd3.ExecuteReader();
            SqlDataReader monReader4 = cmd4.ExecuteReader();
            SqlDataReader monReader5 = cmd5.ExecuteReader();

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
                

                while (monReader2.Read())
                {
                    leAuteur = (Author)monReader2["author_lastname"];

                    while (monReader3.Read())
                    {
                        leTheme = (Theme)monReader["theme_name"];

                        while (monReader4.Read())
                        {
                            leType = (PublicType)monReader["publicType_name"];

                            while (monReader5.Read())
                            {
                                laCompagnie = (Company)monReader["theaterPiece_company"];

                                unePieceTheatre = new TheaterPiece(id, nom, description, duree, prix, laCompagnie, leAuteur, leType, leTheme);
                                lesTheatres.Add(unePieceTheatre);
                            }                                                       
                        }
                    }
                }                
            }
            

           


            // Fermeture de la connexion
            maConnexion.Close();

            return lesTheatres;
              
        }
    }
}
