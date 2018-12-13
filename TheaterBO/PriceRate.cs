using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class PriceRate
    {
        private int priceRate_id;
        private string priceRate_name;
        private DateTime priceRate_startTime; //pour avoir le format heure: var.ToString("HH:mm");
        private DateTime priceRate_endTime;
        private float priceRate_rate;
        private List<WeekDays> priceRate_weekDays;
        private List<Show> priceRate_shows;

        public PriceRate(int id, string name, DateTime startTime, DateTime endTime, float rate, List<WeekDays> weekDays, List<Show> shows)
        {
            this.priceRate_id = id;
            this.priceRate_name = name;
            this.priceRate_startTime = startTime;
            this.priceRate_endTime = endTime;
            this.priceRate_rate = rate;
            this.PriceRate_weekDays = weekDays;
            this.PriceRate_shows = shows;
        }

        public int PriceRate_id
        {
            get
            {
                return priceRate_id;
            }

            set
            {
                priceRate_id = value;
            }
        }

        public string PriceRate_name
        {
            get
            {
                return priceRate_name;
            }

            set
            {
                priceRate_name = value;
            }
        }

        public DateTime PriceRate_startTime
        {
            get
            {
                return priceRate_startTime;
            }

            set
            {
                priceRate_startTime = value;
            }
        }

        public DateTime PriceRate_endTime
        {
            get
            {
                return priceRate_endTime;
            }

            set
            {
                priceRate_endTime = value;
            }
        }

        public float PriceRate_rate
        {
            get
            {
                return priceRate_rate;
            }

            set
            {
                priceRate_rate = value;
            }
        }

        public List<WeekDays> PriceRate_weekDays
        {
            get
            {
                return priceRate_weekDays;
            }

            set
            {
                priceRate_weekDays = value;
            }
        }

        public List<Show> PriceRate_shows
        {
            get
            {
                return priceRate_shows;
            }

            set
            {
                priceRate_shows = value;
            }
        }
    }
}
