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
        private int spectator_seatsBooked;

        public Spectator(int id, string lastname, string firstname, string email, string phone, Show show, int seatsBooked)
        {
            this.spectator_id = id;
            this.spectator_lastname = lastname;
            this.spectator_firstname = firstname;
            this.spectator_email = email;
            this.spectator_phone = phone;
            this.Spectator_show = show;
            this.Spectator_seatsBooked = seatsBooked;
        }
        public Spectator(string lastname, string firstname, string email, string phone, Show show, int seatsBooked)
        {
            this.spectator_lastname = lastname;
            this.spectator_firstname = firstname;
            this.spectator_email = email;
            this.spectator_phone = phone;
            this.Spectator_show = show;
            this.Spectator_seatsBooked = seatsBooked;
        }

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

        public Show Spectator_show
        {
            get
            {
                return spectator_show;
            }

            set
            {
                spectator_show = value;
            }
        }

        public int Spectator_seatsBooked
        {
            get
            {
                return spectator_seatsBooked;
            }

            set
            {
                spectator_seatsBooked = value;
            }
        }
    }
}
