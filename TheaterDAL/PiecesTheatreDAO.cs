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

        

        //public static List<Company> GetCompagnies()
        //{
        //    List<Company> lesCompagnies = new List<Company>();

        //    int id;
        //    string name;
        //    string city;
        //    string region;
        //    string artisticDirector;

        //    Company uneCompagnie;

        //    // Connexion à la BD 
        //    SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = maConnexion;
        //    cmd.CommandText = "SELECT * FROM Company";
        //    SqlDataReader monReader = cmd.ExecuteReader();

        //    while (monReader.Read())
        //    {
        //        id = Int32.Parse(monReader["company_id"].ToString());
        //        name = monReader["company_name"].ToString();
        //        city = monReader["company_city"].ToString();
        //        region = monReader["company_region"].ToString());
        //        artisticDirector = monReader["company_artisticDirector"].ToString();

        //        uneCompagnie = new Company(id, name, city, region, artisticDirector);
        //        lesCompagnies.Add(uneCompagnie);

                
        //    }
        //    return lesCompagnies;

        //}

        // Renvoie toutes les pièces de théâtre, liste
        public static List<TheaterPiece> GetTheaterPieces()
        {
            // Création d'une liste vide d'objet TheaterPiece
            List<TheaterPiece> lesPiecesTheatre = new List<TheaterPiece>();

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

            List<Company> lesCompagnies = new List<Company>(); //GetCompagnies();
            List<Author> lesAuteurs = new List<Author>();
            List<PublicType> lesTypes = new List<PublicType>();
            List<Theme> lesThemes = new List<Theme>();


            // Connexion à la BD 
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Theater_piece";
            SqlDataReader monReader = cmd.ExecuteReader();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = maConnexion;
            cmd2.CommandText = "SECLECT * FROM Author";
            SqlDataReader monReader2 = cmd2.ExecuteReader();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = maConnexion;
            cmd3.CommandText = "SELECT * FROM Theme";
            SqlDataReader monReader3 = cmd3.ExecuteReader();

            SqlCommand cmd4 = new SqlCommand();
            cmd4.Connection = maConnexion;
            cmd4.CommandText = "SECLECT * FROM Public_Type";
            SqlDataReader monReader4 = cmd4.ExecuteReader();

            SqlCommand cmd5 = new SqlCommand();
            cmd5.Connection = maConnexion;
            cmd5.CommandText = "SECLECT * FROM Company";
            SqlDataReader monReader5 = cmd5.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                id = Int32.Parse(monReader["theaterPiece_id"].ToString());
                nom = monReader["theaterPiece_name"].ToString();
                description = monReader["theaterPiece_description"].ToString();
                duree = float.Parse(monReader["theaterPiece_duration"].ToString());
                prix = float.Parse(monReader["theaterPiece_seatsPrice"].ToString());

                int idCompagnie = Convert.ToInt32(monReader["company_id"].ToString());
                int idAuteur = Convert.ToInt32(monReader["author_id"].ToString());
                int idTheme = Convert.ToInt32(monReader["theme_id"].ToString());
                int idType = Convert.ToInt32(monReader["typePublic_id"].ToString());


                // recupère id de la company dans la table piece de theatre
                // apres un while du reader de la compagnie et dedans comparer les id (1 id de la compagnie de la table piece de theatre et id de la compagnie de la table company) + while a la suite des autres 
                // si c'est ok




                while (monReader5.Read())
                {
                    int company_id = Convert.ToInt32(monReader5["company_id"].ToString());

                    if (idCompagnie == company_id)
                    {

                        bool trouve = false;
                        int i = 0;

                        // On trouve dans la liste des compagnies celui correspondant à l'id
                        while (trouve == false && i < lesCompagnies.Count)
                        {
                            if (lesCompagnies[i].Company_id == idCompagnie)
                            {
                                // Si on l'a, on l'ajoute
                                laCompagnie = lesCompagnies[i];
                                trouve = true;
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                }

                while (monReader2.Read())
                {
                    int author_id = Convert.ToInt32(monReader2["author_id"].ToString());

                    if (idAuteur == author_id)
                    {
                        bool trouve = false;
                        int i = 0;

                        // On trouve dans la liste des show celui correspondant à l'id
                        while (trouve == false && i < lesAuteurs.Count)
                        {
                            if (lesAuteurs[i].Author_id == idAuteur)
                            {
                                // Si on l'a, on l'ajoute
                                leAuteur = lesAuteurs[i];
                                trouve = true;
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                }

                while (monReader3.Read())
                {
                    int theme_id = Convert.ToInt32(monReader3["theme_id"].ToString());

                    if (idTheme == theme_id)
                    {
                        bool trouve = false;
                        int i = 0;

                        // On trouve dans la liste des show celui correspondant à l'id
                        while (trouve == false && i < lesThemes.Count)
                        {
                            if (lesThemes[i].Theme_id == idTheme)
                            {
                                // Si on l'a, on l'ajoute
                                leTheme = lesThemes[i];
                                trouve = true;
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                }

                while (monReader4.Read())
                {
                    int type_id = Convert.ToInt32(monReader4["typePublic_id"].ToString());

                    if (idType == type_id)
                    {
                        bool trouve = false;
                        int i = 0;

                        // On trouve dans la liste des show celui correspondant à l'id
                        while (trouve == false && i < lesTypes.Count)
                        {
                            if (lesTypes[i].PublicType_id == idType)
                            {
                                // Si on l'a, on l'ajoute
                                leType = lesTypes[i];
                                trouve = true;
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                }

                unePieceTheatre = new TheaterPiece(id, nom, description, duree, prix, laCompagnie, leAuteur, leType, leTheme);
                lesPiecesTheatre.Add(unePieceTheatre);
            }



            monReader.Close();
            monReader2.Close();
            monReader3.Close();
            monReader4.Close();
            monReader5.Close();


            // Fermeture de la connexion
            maConnexion.Close();

            return lesPiecesTheatre;
              
        }
    }
}
