using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TheaterBO; // Réference la couche BO
using TheaterDAL; // Réference la couche DAL
using System.Text.RegularExpressions;

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
            List<Spectator> lesReservations = ReservationsDAO.GetSpectators();

            return lesReservations;
        }

        // Ajoute une réservation dans la DB
        public static void AddSpectator(Spectator uneReservation)
        {
            ReservationsDAO.AddSpectator(uneReservation);
        }

        // Renvoie le nombre de place réservées pour une représentation
        public static int GetNbPlacesReservees(Show laRepresentation)
        {
            return ReservationsDAO.GetNbPlacesReservees(laRepresentation);
        }

        // Suppression d'une réservation
        public static string DeleteReservation(Spectator laReservation)
        {
            return ReservationsDAO.DeleteSpectator(laReservation);
        }

        #region Validation Champs
        public static bool ValidChampTxt(string text, out string errMsg)
        {
            if (text.Length <= 0)
            {
                errMsg = "Ce champs est obligatoire !";
                return false;
            }
            else
            {
                errMsg = String.Empty;
                return true;
            }
        }

        public static bool ValidChampEmail(string text, out string errMsg)
        {
            if (text.Length > 0)
            {
                int indMail = text.IndexOf("@");
                if (indMail >= 0)
                {
                    string validEmail = text.Substring(indMail, text.Length - indMail);
                    if (validEmail.IndexOf('.') > validEmail.IndexOf('@'))
                    {
                        errMsg = String.Empty;
                        return true;
                    }
                    else
                    {
                        errMsg = "L'adresse email doit respecter le format suivant : \n exemple@mail.com";
                        return false;
                    }

                }
                else
                {
                    errMsg = "L'adresse email doit respecter le format suivant : \n exemple@mail.com";
                    return false;
                }
            }
            else
            {
                errMsg = "Ce champs est obligatoire !";
                return false;
            }
        }

        public static bool ValidChampNb(string text, int nbPlacesRest, out string errMsg)
        {
            if (text.Length > 0)
            {
                int test;
                if (int.TryParse(text, out test))
                {
                    if(test <= nbPlacesRest)
                    {
                        errMsg = String.Empty;
                        return true;
                    }
                    else
                    {

                        errMsg = "Il n'y a pas assez de places disponibles.";
                        return false;
                    }
                }
                else
                {
                    errMsg = "Veuillez entrer un nombre entier !";
                    return false;
                }
            }
            else
            {
                errMsg = "Ce champs est obligatoire !";
                return false;
            }
        }


        public static bool ValidChampPhone(string text, out string errMsg)
        {
            if (text.Length > 0)
            {
                long test;
                if (long.TryParse(text, out test))
                {
                    if (text.Length == 10)
                    {
                        errMsg = String.Empty;
                        return true;
                    }
                    else
                    {
                        errMsg = "Le numéro doit être composé de 10 chiffres !";
                        return false;
                    }
                }
                else
                {
                    errMsg = "Le numéro de téléphone doit être numérique !";
                    return false;
                }
            }
            else
            {
                errMsg = "Ce champs est obligatoire !";
                return false;
            }

        }
        #endregion Validation Champs
    }
}
