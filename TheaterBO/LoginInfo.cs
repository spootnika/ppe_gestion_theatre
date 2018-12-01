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

        public LoginInfo(AppUser currentUser)
        {
            this.username = currentUser.User_pseudo;
            this.isAdmin = currentUser.User_isAdmin;
        }

        public string Username { get => username; set => username = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}
