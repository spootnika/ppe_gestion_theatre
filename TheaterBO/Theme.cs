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
        private List<TheaterPiece> theme_theaterPieces;

        public Theme(int id, string name, List<TheaterPiece> theaterPieces)
        {
            this.Theme_id = id;
            this.Theme_name = name;
            this.Theme_theaterPieces = theaterPieces;
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

        public List<TheaterPiece> Theme_theaterPieces
        {
            get
            {
                return theme_theaterPieces;
            }

            set
            {
                theme_theaterPieces = value;
            }
        }
    }
}
