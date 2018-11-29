using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class Theme
    {
        private int theme_id;
        private string theme_name;

        public int Theme_id { get => theme_id; set => theme_id = value; }
        public string Theme_name { get => theme_name; set => theme_name = value; }
    }
}
