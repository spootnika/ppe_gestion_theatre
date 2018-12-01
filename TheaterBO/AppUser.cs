using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class AppUser
    {
        private int user_id;
        private string user_pseudo;
        private string user_password;
        private bool user_isAdmin;

        public AppUser(int id, string pseudo, string password, bool isAdmin)
        {
            this.user_id = id;
            this.user_pseudo = pseudo;
            this.user_password = password;
            this.user_isAdmin = isAdmin;
        }

        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }

        public string User_pseudo
        {
            get
            {
                return user_pseudo;
            }

            set
            {
                user_pseudo = value;
            }
        }

        public string User_password
        {
            get
            {
                return user_password;
            }

            set
            {
                user_password = value;
            }
        }

        public bool User_isAdmin
        {
            get
            {
                return user_isAdmin;
            }

            set
            {
                user_isAdmin = value;
            }
        }


    }
}
