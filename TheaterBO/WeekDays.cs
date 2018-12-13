using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class WeekDays
    {
        private int weekDays_id;
        private string weekDays_name;
        private List<PriceRate> weekDays_priceRates;

        public WeekDays(int id, string name, List<PriceRate> priceRates)
        {
            this.WeekDays_id = id;
            this.WeekDays_name = name;
            this.WeekDays_priceRates = priceRates;
        }

        public int WeekDays_id
        {
            get
            {
                return weekDays_id;
            }

            set
            {
                weekDays_id = value;
            }
        }

        public string WeekDays_name
        {
            get
            {
                return weekDays_name;
            }

            set
            {
                weekDays_name = value;
            }
        }

        public List<PriceRate> WeekDays_priceRates
        {
            get
            {
                return weekDays_priceRates;
            }

            set
            {
                weekDays_priceRates = value;
            }
        }
    }
}
