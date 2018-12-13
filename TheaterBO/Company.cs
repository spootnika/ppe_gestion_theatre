using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class Company
    {
        private int company_id;
        private string company_name;
        private string company_city;
        private string company_region;
        private string company_artisticDirector;
        private List<Actor> company_actors;

        public Company(int id, string name, string city, string region, string artisticDirector, List<Actor> actors)
        {
            this.Company_id = id;
            this.Company_name = name;
            this.Company_city = city;
            this.Company_region = region;
            this.Company_artisticDirector = artisticDirector;
            this.Company_actors = actors;
        }
        
        public int Company_id
        {
            get
            {
                return company_id;
            }

            set
            {
                company_id = value;
            }
        }

        public string Company_name
        {
            get
            {
                return company_name;
            }

            set
            {
                company_name = value;
            }
        }

        public string Company_city
        {
            get
            {
                return company_city;
            }

            set
            {
                company_city = value;
            }
        }

        public string Company_region
        {
            get
            {
                return company_region;
            }

            set
            {
                company_region = value;
            }
        }

        public string Company_artisticDirector
        {
            get
            {
                return company_artisticDirector;
            }

            set
            {
                company_artisticDirector = value;
            }
        }

        public List<Actor> Company_actors {
            get
            {
                return company_actors;
            }
            set
            {
                company_actors = value;
            }
        }
    }
}
