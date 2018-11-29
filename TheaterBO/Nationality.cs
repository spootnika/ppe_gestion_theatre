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

        public int Nationality_id { get => nationality_id; set => nationality_id = value; }
        public string Nationality_name { get => nationality_name; set => nationality_name = value; }
    }
}
