using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class Author
    {
        private int author_id;
        private string author_lastname;
        private string author_firstname;
        private List<Nationality> author_nationalities;

        public int Author_id
        {
            get
            {
                return author_id;
            }

            set
            {
                author_id = value;
            }
        }

        public string Author_lastname
        {
            get
            {
                return author_lastname;
            }

            set
            {
                author_lastname = value;
            }
        }

        public string Author_firstname
        {
            get
            {
                return author_firstname;
            }

            set
            {
                author_firstname = value;
            }
        }

        public List<Nationality> Author_nationalities
        {
            get
            {
                return author_nationalities;
            }

            set
            {
                author_nationalities = value;
            }
        }

        public Author(int id, string lastname, string firstname, List<Nationality> nationalities)
        {
            this.Author_id = id;
            this.Author_lastname = lastname;
            this.Author_firstname = firstname;
            this.Author_nationalities = nationalities;
        }

       
    }
}
