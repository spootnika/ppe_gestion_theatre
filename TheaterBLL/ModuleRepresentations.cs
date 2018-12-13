using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheaterDAL;

namespace TheaterBLL
{
    public class ModuleRepresentations
    {
        // objet BL
        private static ModuleRepresentations moduleRepresentations; 

        // Accesseur en lecture objet BLL
        public static ModuleRepresentations GetModuleRepresentations()
        {
            if (moduleRepresentations == null)
            {
                moduleRepresentations = new ModuleRepresentations();
            }
            return moduleRepresentations;
        }

        

        // Récupère la liste des représentations de la DAO, renvoie la liste
        // GetShows()

        // Récupère la liste des représentations filtrées de la DAO, renvoie la liste
        // GetFilterShows()
    }
}
