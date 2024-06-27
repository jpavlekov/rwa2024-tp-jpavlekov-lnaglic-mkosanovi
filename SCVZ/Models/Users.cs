using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCVZ.Models
{
    public class Users
    {
        public int ID_User { get; set; }
        public int ID_Role { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int X { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool PasswordCorrect(string password)
        {
            return Password == password;
        }
    }
}
