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

        public TheaterPiece(int id, string name, string description, float duration, float seatsPrice, Company company, Author author, PublicType publicType, Theme theme)
        {
            this.theaterPiece_id = id;
            this.theaterPiece_name = name;
            this.theaterPiece_description = description;
            this.theaterPiece_duration = duration;
            this.theaterPiece_seatsPrice = seatsPrice;
            this.theaterPiece_company = company;
            this.theaterPiece_author = author;
            this.theaterPiece_publicType = publicType;
            this.theaterPiece_theme = theme;
        }

        public int TheaterPiece_id { get => theaterPiece_id; set => theaterPiece_id = value; }
        public string TheaterPiece_name { get => theaterPiece_name; set => theaterPiece_name = value; }
        public string TheaterPiece_description { get => theaterPiece_description; set => theaterPiece_description = value; }
        public float TheaterPiece_duration { get => theaterPiece_duration; set => theaterPiece_duration = value; }
        public float TheaterPiece_seatsPrice { get => theaterPiece_seatsPrice; set => theaterPiece_seatsPrice = value; }
        public Company TheaterPiece_company { get => theaterPiece_company; set => theaterPiece_company = value; }
        public Author TheaterPiece_author { get => theaterPiece_author; set => theaterPiece_author = value; }
        public PublicType TheaterPiece_publicType { get => theaterPiece_publicType; set => theaterPiece_publicType = value; }
        public Theme TheaterPiece_theme { get => theaterPiece_theme; set => theaterPiece_theme = value; }
    }
}
