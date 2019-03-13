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

        public static TheaterPiece GetOneTheaterPiece(string nomPiece)
        {
            int id = 0;
            string nom = "";
            string description = "";
            float duree = 0;
            float prix = 0;
            Company laCompagnie = null;
            Author leAuteur = null;
            PublicType leType = null;
            Theme leTheme = null;

            TheaterPiece unePieceTheatre = null;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

           
            // Commande sql qui récupère les informations de la table Theatre_piece
            SqlCommand cmdPiecesTheatre = new SqlCommand();
            cmdPiecesTheatre.Connection = maConnexion;
            cmdPiecesTheatre.CommandText = "SELECT * FROM Theater_piece";

            // Commande sql qui récupère les informations de la table Author
            SqlCommand cmdAuteur = new SqlCommand();
            cmdAuteur.Connection = maConnexion;
            cmdAuteur.CommandText = "SELECT * FROM Author";

            // Commande sql qui récupère les informations de la table Nationality
            SqlCommand cmdNationalites = new SqlCommand();
            cmdNationalites.Connection = maConnexion;
            cmdNationalites.CommandText = "SELECT * FROM Nationality";

            // Commande sql qui récupère les informations de la table To_be_of
            SqlCommand cmdAuteurNationalite = new SqlCommand();
            cmdAuteurNationalite.Connection = maConnexion;
            cmdAuteurNationalite.CommandText = "SELECT * FROM To_be_of";

            // Commande sql qui récupère les informations de la table Theme
            SqlCommand cmdTheme = new SqlCommand();
            cmdTheme.Connection = maConnexion;
            cmdTheme.CommandText = "SELECT * FROM Theme";

            // Commande sql qui récupère les informations de la table Public_Type
            SqlCommand cmdTypePublic = new SqlCommand();
            cmdTypePublic.Connection = maConnexion;
            cmdTypePublic.CommandText = "SELECT * FROM Public_Type";

            // Commande sql qui récupère les informations de la table Company
            SqlCommand cmdCompagnie = new SqlCommand();
            cmdCompagnie.Connection = maConnexion;
            cmdCompagnie.CommandText = "SELECT * FROM Company";


            // Execution des requetes 
            SqlDataReader readerPiecesTheatre = cmdPiecesTheatre.ExecuteReader();
            SqlDataReader readerAuteur = cmdAuteur.ExecuteReader();
            SqlDataReader readerNationalites = cmdNationalites.ExecuteReader();
            SqlDataReader readerTheme = cmdTheme.ExecuteReader();
            SqlDataReader readerTypePublic = cmdTypePublic.ExecuteReader();
            SqlDataReader readerAuteurNationalite = cmdAuteurNationalite.ExecuteReader();
            SqlDataReader readerCompagnie = cmdCompagnie.ExecuteReader();

            // Remplissage de la liste
            // Pieces de theatre
            while (readerPiecesTheatre.Read())
            {
                nom = readerPiecesTheatre["theaterPiece_name"].ToString();

                if (nom == nomPiece)
                {
                    
                    id = Int32.Parse(readerPiecesTheatre["theaterPiece_id"].ToString());
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

                        if (idDeLaCompagnie == idCompagnie)
                        {
                            string nomCompagnie = readerCompagnie["company_name"].ToString();
                            string villeCompagnie = readerCompagnie["company_city"].ToString();
                            string regionCompagnie = readerCompagnie["company_region"].ToString();
                            string directeurArtistique = readerCompagnie["company_artisticDirector"].ToString();

                            laCompagnie = new Company(idCompagnie, nomCompagnie, villeCompagnie, regionCompagnie, directeurArtistique);
                        }
                    }
                    // Fermeture reader
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
                            // Fermeture reader
                            readerAuteurNationalite.Close();
                            readerAuteurNationalite = cmdAuteurNationalite.ExecuteReader();

                            List<Nationality> lesNationalites = new List<Nationality>();
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
                                // Fermeture reader
                                readerNationalites.Close();
                                readerNationalites = cmdNationalites.ExecuteReader();

                            }

                            leAuteur = new Author(idAuteur, nomAuteur, prenomAuteur, lesNationalites);
                        }
                    }
                    // Fermeture reader
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
                    // Fermeture reader
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
                    // Fermeture reader
                    readerTheme.Close();
                    readerTheme = cmdTheme.ExecuteReader();

                    unePieceTheatre = new TheaterPiece(id, nom, description, duree, prix, laCompagnie, leAuteur, leType, leTheme);
                }
            }
            // Fermeture reader
            readerCompagnie.Close();
            readerAuteurNationalite.Close();
            readerNationalites.Close();
            readerAuteur.Close();
            readerTypePublic.Close();
            readerTheme.Close();
            readerPiecesTheatre.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return unePieceTheatre;
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
            PublicType leType = null;
            Theme leTheme = null;
            
            // Création objet TheaterPiece
            TheaterPiece unePieceTheatre;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objet TheaterPiece
            List<TheaterPiece> lesTheatres = new List<TheaterPiece>();

            // Commande sql qui récupère les informations de la table Theater_piece
            SqlCommand cmdPiecesTheatre = new SqlCommand();
            cmdPiecesTheatre.Connection = maConnexion;
            cmdPiecesTheatre.CommandText = "SELECT * FROM Theater_piece";

            // Commande sql qui récupère les informations de la table Author
            SqlCommand cmdAuteur = new SqlCommand();
            cmdAuteur.Connection = maConnexion;
            cmdAuteur.CommandText = "SELECT * FROM Author";

            // Commande sql qui récupère les informations de la table Nationality
            SqlCommand cmdNationalites = new SqlCommand();
            cmdNationalites.Connection = maConnexion;
            cmdNationalites.CommandText = "SELECT * FROM Nationality";

            // Commande sql qui récupère les informations de la table To_be_of
            SqlCommand cmdAuteurNationalite = new SqlCommand();
            cmdAuteurNationalite.Connection = maConnexion;
            cmdAuteurNationalite.CommandText = "SELECT * FROM To_be_of";

            // Commande sql qui récupère les informations de la table Theme
            SqlCommand cmdTheme = new SqlCommand();
            cmdTheme.Connection = maConnexion;
            cmdTheme.CommandText = "SELECT * FROM Theme";

            // Commande sql qui récupère les informations de la table Public_Type
            SqlCommand cmdTypePublic = new SqlCommand();
            cmdTypePublic.Connection = maConnexion;
            cmdTypePublic.CommandText = "SELECT * FROM Public_Type";

            // Commande sql qui récupère les informations de la table Company
            SqlCommand cmdCompagnie = new SqlCommand();
            cmdCompagnie.Connection = maConnexion;
            cmdCompagnie.CommandText = "SELECT * FROM Company";

            // Execution des requetes sql
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
                // Fermeture reader
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
                        // Fermerure reader
                        readerAuteurNationalite.Close();
                        readerAuteurNationalite = cmdAuteurNationalite.ExecuteReader();

                        List<Nationality> lesNationalites = new List<Nationality>();
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
                            // Fermeture reader
                            readerNationalites.Close();
                            readerNationalites = cmdNationalites.ExecuteReader();
                            
                        }

                        leAuteur = new Author(idAuteur, nomAuteur, prenomAuteur, lesNationalites);
                    }
                }
                // Fermeture reader
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
                // Fermeture reader
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
                // Fermeture reader
                readerTheme.Close();
                readerTheme = cmdTheme.ExecuteReader();

                unePieceTheatre = new TheaterPiece(id, nom, description, duree, prix, laCompagnie, leAuteur, leType, leTheme);
                lesTheatres.Add(unePieceTheatre);
            }

            // Fermeture reader
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

        public static List<Author> GetAuthors()
        {
            Author leAuteur = null;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objet TheaterPiece
            
            List<Author> lesAuteurs = new List<Author>();

            // Commande sql qui récupère les informations de la table Theater_piece
            SqlCommand cmdPiecesTheatre = new SqlCommand();
            cmdPiecesTheatre.Connection = maConnexion;
            cmdPiecesTheatre.CommandText = "SELECT * FROM Theater_piece";

            // Commande sql qui récupère les informations de la table Author
            SqlCommand cmdAuteur = new SqlCommand();
            cmdAuteur.Connection = maConnexion;
            cmdAuteur.CommandText = "SELECT * FROM Author";

            // Commande sql qui récupère les informations de la table Nationality
            SqlCommand cmdNationalites = new SqlCommand();
            cmdNationalites.Connection = maConnexion;
            cmdNationalites.CommandText = "SELECT * FROM Nationality";

            // Commande sql qui récupère les informations de la table To_be_of
            SqlCommand cmdAuteurNationalite = new SqlCommand();
            cmdAuteurNationalite.Connection = maConnexion;
            cmdAuteurNationalite.CommandText = "SELECT * FROM To_be_of";


            

            // Execution des requetes sql
            SqlDataReader readerPiecesTheatre = cmdPiecesTheatre.ExecuteReader();
            SqlDataReader readerAuteur = cmdAuteur.ExecuteReader();
            SqlDataReader readerNationalites = cmdNationalites.ExecuteReader();
            SqlDataReader readerAuteurNationalite = cmdAuteurNationalite.ExecuteReader();
            
           

            // Author
            while (readerAuteur.Read())
            {
                int idAuteur = Int32.Parse(readerAuteur["author_id"].ToString());
                
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
                    // Fermerure reader
                    readerAuteurNationalite.Close();
                    readerAuteurNationalite = cmdAuteurNationalite.ExecuteReader();

                    List<Nationality> lesNationalites = new List<Nationality>();
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
                        // Fermeture reader
                        readerNationalites.Close();
                        readerNationalites = cmdNationalites.ExecuteReader();
                            
                    }

                    leAuteur = new Author(idAuteur, nomAuteur, prenomAuteur, lesNationalites);
                    lesAuteurs.Add(leAuteur);
                    
            }
            // Fermeture reader
            readerAuteur.Close();
            readerAuteur = cmdAuteur.ExecuteReader();

                
                

            // Fermeture reader
            readerAuteurNationalite.Close();
            readerNationalites.Close();
            readerAuteur.Close();
            readerPiecesTheatre.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return lesAuteurs;
              
        }

        public static List<Theme> GetThemes()
        {
            Theme leTheme = null;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objet TheaterPiece

            List<Theme> lesThemes = new List<Theme>();

            // Commande sql qui récupère les informations de la table Theater_piece
            SqlCommand cmdTheme = new SqlCommand();
            cmdTheme.Connection = maConnexion;
            cmdTheme.CommandText = "SELECT * FROM Theme";




            // Execution des requetes sql
            SqlDataReader readerTheme = cmdTheme.ExecuteReader();



            // Theme
            while (readerTheme.Read())
            {
                int idTheme = Int32.Parse(readerTheme["theme_id"].ToString());
                string nomTheme = readerTheme["theme_name"].ToString();

                leTheme = new Theme(idTheme, nomTheme);
                lesThemes.Add(leTheme);
                
            }
            // Fermeture reader
            readerTheme.Close();
            readerTheme = cmdTheme.ExecuteReader();
            // Fermeture reader
            readerTheme.Close();

            // Fermeture de la connexion
            maConnexion.Close();

            return lesThemes;

        }

        public static List<PublicType> GetTypesPublic()
        {
            PublicType leType = null;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objet TheaterPiece

            List<PublicType> lesTypes = new List<PublicType>();

            // Commande sql qui récupère les informations de la table Theater_piece
            SqlCommand cmdTypePublic = new SqlCommand();
            cmdTypePublic.Connection = maConnexion;
            cmdTypePublic.CommandText = "SELECT * FROM Public_Type";




            // Execution des requetes sql
            SqlDataReader readerTypePublic = cmdTypePublic.ExecuteReader();



            // Public type
            while (readerTypePublic.Read())
            {
                int idType = Int32.Parse(readerTypePublic["publicType_id"].ToString());
                
                string nomType = readerTypePublic["publicType_name"].ToString();

                leType = new PublicType(idType, nomType);
                lesTypes.Add(leType);


            }
            // Fermeture reader
            readerTypePublic.Close();
            readerTypePublic = cmdTypePublic.ExecuteReader();

            // Fermeture de la connexion
            maConnexion.Close();

            return lesTypes;

        }

        public static List<Company> GetCompagnies()
        {
            Company laCompagnie = null;

            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();


            List<Company> lesCompagnies = new List<Company>();

            SqlCommand cmdCompagnie = new SqlCommand();
            cmdCompagnie.Connection = maConnexion;
            cmdCompagnie.CommandText = "SELECT * FROM Company";




            // Execution des requetes sql
            SqlDataReader readerCompagnie = cmdCompagnie.ExecuteReader();



            // Company
            while (readerCompagnie.Read())
            {
                int idCompagnie = Int32.Parse(readerCompagnie["company_id"].ToString());
                
                string nomCompagnie = readerCompagnie["company_name"].ToString();
                string villeCompagnie = readerCompagnie["company_city"].ToString();
                string regionCompagnie = readerCompagnie["company_region"].ToString();
                string directeurArtistique = readerCompagnie["company_artisticDirector"].ToString();

                laCompagnie = new Company(idCompagnie, nomCompagnie, villeCompagnie, regionCompagnie, directeurArtistique);
                lesCompagnies.Add(laCompagnie);
                
            }
            // Fermeture reader
            readerCompagnie.Close();
            readerCompagnie = cmdCompagnie.ExecuteReader();

            // Fermeture de la connexion
            maConnexion.Close();

            return lesCompagnies;

        }

        // Ajout d'une nouvelle réservation
        public static void AddTheaterPiece(TheaterPiece unePiece)
        {
            try
            {
                SqlConnection connexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                string reqAdd = "INSERT INTO Theater_piece (theaterPiece_name, theaterPiece_description, theaterPiece_duration, theaterPiece_seatsPrice, theaterPiece_company, theaterPiece_author, theaterPiece_publicType, theaterPiece_theme) " + "VALUES (@name, @description, @duration, @seatsPrice, @company, , @author, @publicType, @theme); SELECT SCOPE_IDENTITY()";

                SqlCommand commAddPiece = new SqlCommand(reqAdd, connexion);

                commAddPiece.Parameters.Add(new SqlParameter("@name", System.Data.SqlDbType.VarChar, 255));
                commAddPiece.Parameters.Add(new SqlParameter("@description", System.Data.SqlDbType.VarChar, 255));
                commAddPiece.Parameters.Add(new SqlParameter("@duration", System.Data.SqlDbType.Int, 255));
                commAddPiece.Parameters.Add(new SqlParameter("@seatsPrice", System.Data.SqlDbType.Int, 255));
                commAddPiece.Parameters.Add(new SqlParameter("@company", System.Data.SqlDbType.VarChar, 255));
                commAddPiece.Parameters.Add(new SqlParameter("@author", System.Data.SqlDbType.VarChar, 255));
                commAddPiece.Parameters.Add(new SqlParameter("@publicType", System.Data.SqlDbType.VarChar, 255));
                commAddPiece.Parameters.Add(new SqlParameter("@theme", System.Data.SqlDbType.VarChar, 255));

                commAddPiece.Parameters["@name"].Value = unePiece.TheaterPiece_name;
                commAddPiece.Parameters["@description"].Value = unePiece.TheaterPiece_description;
                commAddPiece.Parameters["@duration"].Value = unePiece.TheaterPiece_duration;
                commAddPiece.Parameters["@seatsPrice"].Value = unePiece.TheaterPiece_seatsPrice;
                commAddPiece.Parameters["@company"].Value = unePiece.TheaterPiece_company;
                commAddPiece.Parameters["@author"].Value = unePiece.TheaterPiece_author;
                commAddPiece.Parameters["@publicType"].Value = unePiece.TheaterPiece_publicType;
                commAddPiece.Parameters["@theme"].Value = unePiece.TheaterPiece_theme;
                
            }
            catch (Exception e)
            {
                //Message box erreur
                string test = e.ToString();
            }

        }
    }
}
