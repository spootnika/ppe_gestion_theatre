using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class Show
    {
        private int show_id;
        private DateTime show_dateTime;
        private int show_seats;
        private PriceRate show_priceRate;
        private TheaterPiece show_theaterPiece;

        public int Show_id { get => show_id; set => show_id = value; }
        public DateTime Show_dateTime { get => show_dateTime; set => show_dateTime = value; }
        public int Show_seats { get => show_seats; set => show_seats = value; }
        public PriceRate Show_priceRate { get => show_priceRate; set => show_priceRate = value; }
        public TheaterPiece Show_theaterPiece { get => show_theaterPiece; set => show_theaterPiece = value; }
    }
}
