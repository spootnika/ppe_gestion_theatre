﻿using System;
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

        public int Author_id { get => author_id; set => author_id = value; }
        public string Author_lastname { get => author_lastname; set => author_lastname = value; }
        public string Author_firstname { get => author_firstname; set => author_firstname = value; }
    }
}
