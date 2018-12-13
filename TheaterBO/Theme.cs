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

        public Theme(int id, string name)
        {
            this.Theme_id = id;
            this.Theme_name = name;
        }

        public int Theme_id
        {
            get
            {
                return theme_id;
            }

            set
            {
                theme_id = value;
            }
        }

        public string Theme_name
        {
            get
            {
                return theme_name;
            }

            set
            {
                theme_name = value;
            }
        }
        
    }
}
