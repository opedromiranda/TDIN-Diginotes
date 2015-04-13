using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace TDIN_Diginote.Models
{
    class User
    {
        [JsonProperty(PropertyName = "username")]
        public String Username;

        [JsonProperty(PropertyName = "password")]
        public String Password;

        public User(String username, String password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
