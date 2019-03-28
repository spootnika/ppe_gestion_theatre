using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDAL
{
    public class SyntheseDAO
    {
        // objet SyntheseDAO
        private static SyntheseDAO uneSyntheseDAO;

        // Accesseur en lecture, renvoi une instance
        public static SyntheseDAO GetSyntheseDAO()
        {
            if (uneSyntheseDAO == null)
            {
                uneSyntheseDAO = new SyntheseDAO();
            }
            return uneSyntheseDAO;
        }


    }
}
