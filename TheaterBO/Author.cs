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

        public Author(int id, string lastname, string firstname, List<Nationality> nationalities)
        {
            this.author_id = id;
            this.author_lastname = lastname;
            this.author_firstname = firstname;
            this.author_nationalities = nationalities;
        }

        public int Author_id { get => author_id; set => author_id = value; }
        public string Author_lastname { get => author_lastname; set => author_lastname = value; }
        public string Author_firstname { get => author_firstname; set => author_firstname = value; }
        public List<Nationality> Author_nationalities { get => author_nationalities; set => author_nationalities = value; }
    }
}
