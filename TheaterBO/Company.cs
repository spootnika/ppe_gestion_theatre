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
    }
}
