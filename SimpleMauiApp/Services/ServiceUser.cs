using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMauiApp.Model;

namespace SimpleMauiApp.Services
{
    public class ServiceUser
    {
        public List<User> GetUsers()
        {
            return new List<User>
            {
                new User("Alicia", "alicia@gmail.com"),
                new User("Pepe", "pepe@gmail"),
                new User("Manuel", "manuel@gmail.com"),
                new User("Paco", "paco@gmail.com")
            };
        }
    }
}
