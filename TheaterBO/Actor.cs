using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class Actor
    {
        private int actor_id;
        private string actor_lastName;
        private string actor_firstName;
        private int actor_age;
        private Company actor_company;
        private List<Nationality> actor_nationalities;

        public Actor(int id, string lastname, string firstname, int age, Company company, List<Nationality> nationalities)
        {
            this.actor_id = id;
            this.actor_lastName = lastname;
            this.actor_firstName = firstname;
            this.actor_age = age;
            this.actor_company = company;
            this.Actor_nationalities = nationalities;
        }

        public int Actor_id
        {
            get
            {
                return actor_id;
            }

            set
            {
                actor_id = value;
            }
        }

        public string Actor_lastName
        {
            get
            {
                return actor_lastName;
            }

            set
            {
                actor_lastName = value;
            }
        }

        public string Actor_firstName
        {
            get
            {
                return actor_firstName;
            }

            set
            {
                actor_firstName = value;
            }
        }

        public int Actor_age
        {
            get
            {
                return actor_age;
            }

            set
            {
                actor_age = value;
            }
        }

        public Company Actor_company
        {
            get
            {
                return actor_company;
            }

            set
            {
                actor_company = value;
            }
        }

        public List<Nationality> Actor_nationalities
        {
            get
            {
                return actor_nationalities;
            }

            set
            {
                actor_nationalities = value;
            }
        }
    }
}
