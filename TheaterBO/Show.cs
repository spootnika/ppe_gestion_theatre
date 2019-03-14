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

        public int Show_id
        {
            get
            {
                return show_id;
            }

            set
            {
                show_id = value;
            }
        }

        public DateTime Show_dateTime
        {
            get
            {
                return show_dateTime;
            }

            set
            {
                show_dateTime = value;
            }
        }

        public int Show_seats
        {
            get
            {
                return show_seats;
            }

            set
            {
                show_seats = value;
            }
        }

        public PriceRate Show_priceRate
        {
            get
            {
                return show_priceRate;
            }

            set
            {
                show_priceRate = value;
            }
        }

        public TheaterPiece Show_theaterPiece
        {
            get
            {
                return show_theaterPiece;
            }

            set
            {
                show_theaterPiece = value;
            }
        }
        

        public Show(int id, DateTime dateTime, int seats, PriceRate priceRate, TheaterPiece theaterPiece)
        {
            this.Show_id = id;
            this.Show_dateTime = dateTime;
            this.Show_seats = seats;
            this.Show_priceRate = priceRate;
            this.Show_theaterPiece = theaterPiece;
        }
        public Show( DateTime dateTime, int seats, TheaterPiece theaterPiece)
        {
            this.Show_dateTime = dateTime;
            this.Show_seats = seats;
            this.Show_theaterPiece = theaterPiece;
        }


    }
}
