using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDAL
{
    public class ReservationsDAO
    {
        // objet ReservationDAO
        private static ReservationsDAO uneReservationDAO;

        // Accesseur en lecture, renvoi une instance
        public static ReservationsDAO GetReservationsDAO()
        {
            if(uneReservationDAO == null)
            {
                uneReservationDAO = new ReservationsDAO();
            }
            return uneReservationDAO;
        }

        // Renvoie la liste des réservations
        // Nécessite les représentations et pièces de théâtre
        // Besoin des tables spectator et toBook
        // GetSpectators()

    }
}
