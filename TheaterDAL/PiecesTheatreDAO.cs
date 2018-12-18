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
            int id = 0;
            string nom = "";
            string description = "";
            float duree = 0;
            float prix = 0;
            Company laCompagnie = null;
            Author leAuteur = null;
            List<Nationality> lesNationalites = new List<Nationality>();
            PublicType leType = null;
            Theme leTheme = null;
   
            TheaterPiece unePieceTheatre;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objet TheaterPiece
            List<TheaterPiece> lesTheatres = new List<TheaterPiece>();

            SqlCommand cmdPiecesTheatre = new SqlCommand();
            cmdPiecesTheatre.Connection = maConnexion;
            cmdPiecesTheatre.CommandText = "SELECT * FROM Theater_piece";

            SqlCommand cmdAuteur = new SqlCommand();
            cmdAuteur.Connection = maConnexion;
            cmdAuteur.CommandText = "SELECT * FROM Author";

            SqlCommand cmdNationalites = new SqlCommand();
            cmdNationalites.Connection = maConnexion;
            cmdNationalites.CommandText = "SELECT * FROM Nationality";

            SqlCommand cmdAuteurNationalite = new SqlCommand();
            cmdAuteurNationalite.Connection = maConnexion;
            cmdAuteurNationalite.CommandText = "SELECT * FROM To_be_of";

            SqlCommand cmdTheme = new SqlCommand();
            cmdTheme.Connection = maConnexion;
            cmdTheme.CommandText = "SELECT * FROM Theme";

            SqlCommand cmdTypePublic = new SqlCommand();
            cmdTypePublic.Connection = maConnexion;
            cmdTypePublic.CommandText = "SELECT * FROM Public_Type";

            SqlCommand cmdCompagnie = new SqlCommand();
            cmdCompagnie.Connection = maConnexion;
            cmdCompagnie.CommandText = "SELECT * FROM Company";

            SqlDataReader readerPiecesTheatre = cmdPiecesTheatre.ExecuteReader();
            SqlDataReader readerAuteur = cmdAuteur.ExecuteReader();
            SqlDataReader readerNationalites = cmdNationalites.ExecuteReader();
            SqlDataReader readerTheme = cmdTheme.ExecuteReader();
            SqlDataReader readerTypePublic = cmdTypePublic.ExecuteReader();
            SqlDataReader readerAuteurNationalite = cmdAuteurNationalite.ExecuteReader();
            SqlDataReader readerCompagnie = cmdCompagnie.ExecuteReader();
            
            // Remplissage de la liste
            while (readerPiecesTheatre.Read())
            {
                id = Int32.Parse(readerPiecesTheatre["theaterPiece_id"].ToString());
                nom = readerPiecesTheatre["theaterPiece_name"].ToString();
                description = readerPiecesTheatre["theaterPiece_description"].ToString();
                duree = float.Parse(readerPiecesTheatre["theaterPiece_duration"].ToString());
                prix = float.Parse(readerPiecesTheatre["theaterPiece_seatsPrice"].ToString());
                int idDeLAuteur = Int32.Parse(readerPiecesTheatre["theaterPiece_author"].ToString());
                int idDeLaCompagnie = Int32.Parse(readerPiecesTheatre["theaterPiece_company"].ToString());
                int idDuTypePublic = Int32.Parse(readerPiecesTheatre["theaterPiece_publicType"].ToString());
                int idDuTheme = Int32.Parse(readerPiecesTheatre["theaterPiece_theme"].ToString());

                // Company
                while (readerCompagnie.Read())
                {
                    int idCompagnie = Int32.Parse(readerCompagnie["company_id"].ToString());

                    if(idDeLaCompagnie == idCompagnie)
                    {
                        string nomCompagnie = readerCompagnie["company_name"].ToString();
                        string villeCompagnie = readerCompagnie["company_city"].ToString();
                        string regionCompagnie = readerCompagnie["company_region"].ToString();
                        string directeurArtistique = readerCompagnie["company_artisticDirector"].ToString();

                        laCompagnie = new Company(idCompagnie, nomCompagnie, villeCompagnie, regionCompagnie, directeurArtistique);
                    }
                }
                readerCompagnie.Close();
                readerCompagnie = cmdCompagnie.ExecuteReader();

                // Author
                while (readerAuteur.Read())
                {
                    int idAuteur = Int32.Parse(readerAuteur["author_id"].ToString());

                    if (idDeLAuteur == idAuteur)
                    {
                        string nomAuteur = readerAuteur["author_lastname"].ToString();
                        string prenomAuteur = readerAuteur["author_firstname"].ToString();

                        List<int> lesIdsNationalites = new List<int>();

                        while (readerAuteurNationalite.Read())
                        {
                            int idComparerAuteur = Int32.Parse(readerAuteurNationalite["toBeOf_author"].ToString());
                            if (idAuteur == idComparerAuteur)
                            {
                                int idNatio = Int32.Parse(readerAuteurNationalite["toBeOf_nationality"].ToString());
                                lesIdsNationalites.Add(idNatio);
                            }
                        }
                        readerAuteurNationalite.Close();
                        readerAuteurNationalite = cmdAuteurNationalite.ExecuteReader();

                        foreach (int unIdNatio in lesIdsNationalites)
                        {
                            while (readerNationalites.Read())
                            {
                                int idNationalite = Int32.Parse(readerNationalites["nationality_id"].ToString());
                                if (unIdNatio == idNationalite)
                                {
                                    Nationality laNationalite;
                                    string nomNationalite = readerNationalites["nationality_name"].ToString();

                                    laNationalite = new Nationality(idNationalite, nomNationalite);
                                    lesNationalites.Add(laNationalite);
                                }

                            }
                            readerNationalites.Close();
                            readerNationalites = cmdNationalites.ExecuteReader();
                            
                        }

                        leAuteur = new Author(idAuteur, nomAuteur, prenomAuteur, lesNationalites);
                    }
                }
                readerAuteur.Close();
                readerAuteur = cmdAuteur.ExecuteReader();

                // Public type
                while (readerTypePublic.Read())
                {
                    int idType = Int32.Parse(readerTypePublic["publicType_id"].ToString());

                    if (idType == idDuTypePublic)
                    {
                        string nomType = readerTypePublic["publicType_name"].ToString();

                        leType = new PublicType(idType, nomType);
                    }
                }
                readerTypePublic.Close();
                readerTypePublic = cmdTypePublic.ExecuteReader();

                // Theme
                while (readerTheme.Read())
                {
                    int idTheme = Int32.Parse(readerTheme["theme_id"].ToString());

                    if (idTheme == idDuTheme)
                    {
                        string nomTheme = readerTheme["theme_name"].ToString();

                        leTheme = new Theme(idTheme, nomTheme);
                    }
                }
                readerTheme.Close();
                readerTheme = cmdTheme.ExecuteReader();

                unePieceTheatre = new TheaterPiece(id, nom, description, duree, prix, laCompagnie, leAuteur, leType, leTheme);
                lesTheatres.Add(unePieceTheatre);
            }
            readerCompagnie.Close();
            readerAuteurNationalite.Close();
            readerNationalites.Close();
            readerAuteur.Close();
            readerTypePublic.Close();
            readerTheme.Close();
            readerPiecesTheatre.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return lesTheatres;
              
        }
    }
}
