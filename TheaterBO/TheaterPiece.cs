using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class TheaterPiece
    {
        private int theaterPiece_id;
        private string theaterPiece_name;
        private string theaterPiece_description;
        private float theaterPiece_duration;
        private float theaterPiece_seatsPrice;
        private Company theaterPiece_company;
        private Author theaterPiece_author;
        private PublicType theaterPiece_publicType;
        private Theme theaterPiece_theme;
        private List<Show> theaterPiece_shows;

        public int TheaterPiece_id
        {
            get
            {
                return theaterPiece_id;
            }

            set
            {
                theaterPiece_id = value;
            }
        }

        public string TheaterPiece_name
        {
            get
            {
                return theaterPiece_name;
            }

            set
            {
                theaterPiece_name = value;
            }
        }

        public string TheaterPiece_description
        {
            get
            {
                return theaterPiece_description;
            }

            set
            {
                theaterPiece_description = value;
            }
        }

        public float TheaterPiece_duration
        {
            get
            {
                return theaterPiece_duration;
            }

            set
            {
                theaterPiece_duration = value;
            }
        }

        public float TheaterPiece_seatsPrice
        {
            get
            {
                return theaterPiece_seatsPrice;
            }

            set
            {
                theaterPiece_seatsPrice = value;
            }
        }

        public Company TheaterPiece_company
        {
            get
            {
                return theaterPiece_company;
            }

            set
            {
                theaterPiece_company = value;
            }
        }

        public Author TheaterPiece_author
        {
            get
            {
                return theaterPiece_author;
            }

            set
            {
                theaterPiece_author = value;
            }
        }

        public PublicType TheaterPiece_publicType
        {
            get
            {
                return theaterPiece_publicType;
            }

            set
            {
                theaterPiece_publicType = value;
            }
        }

        public Theme TheaterPiece_theme
        {
            get
            {
                return theaterPiece_theme;
            }

            set
            {
                theaterPiece_theme = value;
            }
        }


        public List<Show> TheaterPiece_shows
        {
            get
            {
                return TheaterPiece_shows;
            }

            set
            {
                TheaterPiece_shows = value;
            }
        }

        public TheaterPiece(int id, string name, string description, float duration, float seatsPrice, Company company, Author author, PublicType publicType, Theme theme, List<Show> shows)
        {
            this.TheaterPiece_id = id;
            this.TheaterPiece_name = name;
            this.TheaterPiece_description = description;
            this.TheaterPiece_duration = duration;
            this.TheaterPiece_seatsPrice = seatsPrice;
            this.TheaterPiece_company = company;
            this.TheaterPiece_author = author;
            this.TheaterPiece_publicType = publicType;
            this.TheaterPiece_theme = theme;
            this.TheaterPiece_shows = shows;
        }

       
    }
}
