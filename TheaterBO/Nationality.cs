using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class Nationality
    {
        private int nationality_id;
        private string nationality_name;

        public Nationality(int id, string name)
        {
            this.Nationality_id = id;
            this.Nationality_name = name;
        }

        public int Nationality_id
        {
            get
            {
                return nationality_id;
            }

            set
            {
                nationality_id = value;
            }
        }

        public string Nationality_name
        {
            get
            {
                return nationality_name;
            }

            set
            {
                nationality_name = value;
            }
        }
    }
}
