using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDIN_Diginote.Models
{
    class User
    {
        public String Username;
        public String Password;

        public User(String username, String password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
