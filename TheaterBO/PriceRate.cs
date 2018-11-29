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
    }
}
