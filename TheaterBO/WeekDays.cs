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

        public WeekDays(int id, string name)
        {
            this.WeekDays_id = id;
            this.WeekDays_name = name;
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
    }
}
