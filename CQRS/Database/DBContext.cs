using CQRS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Database
{
    public class DBContext
    {
        public static IEnumerable<User> Users { get; set; }
     
        public DBContext()
        {
            Users = new List<User>()
            {
                new User(1,"juan","Pass", new DateTime(1997, 06, 12)),
                new User(2,"juanito","Password", new DateTime(1999, 06, 12)),
            };
        }

    }
}
