using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterBO
{
    public class LoginInfo
    {
        private string username;
        private bool isAdmin;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }

            set
            {
                isAdmin = value;
            }
        }

        public LoginInfo(AppUser currentUser)
        {
            this.Username = currentUser.User_pseudo;
            this.IsAdmin = currentUser.User_isAdmin;
        }

       
    }
}
