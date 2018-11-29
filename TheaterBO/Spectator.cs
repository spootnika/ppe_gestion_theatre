using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class Spectator
    {
        private int spectator_id;
        private string spectator_lastname;
        private string spectator_firstname;
        private string spectator_email;
        private string spectator_phone;
        private Show spectator_show;
        private int spactator_seatsBooked;

        public int Spectator_id
        {
            get
            {
                return spectator_id;
            }

            set
            {
                spectator_id = value;
            }
        }

        public string Spectator_lastname
        {
            get
            {
                return spectator_lastname;
            }

            set
            {
                spectator_lastname = value;
            }
        }

        public string Spectator_firstname
        {
            get
            {
                return spectator_firstname;
            }

            set
            {
                spectator_firstname = value;
            }
        }

        public string Spectator_email
        {
            get
            {
                return spectator_email;
            }

            set
            {
                spectator_email = value;
            }
        }

        public string Spectator_phone
        {
            get
            {
                return spectator_phone;
            }

            set
            {
                spectator_phone = value;
            }
        }

        public int Spactator_seatsBooked { get => spactator_seatsBooked; set => spactator_seatsBooked = value; }
        public Show Spectator_show { get => spectator_show; set => spectator_show = value; }
    }
}
