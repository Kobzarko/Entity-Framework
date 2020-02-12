using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeSecond
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Users;
                foreach (User item in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", item.Id, item.Name, item.Age);
                }
            }

            Console.ReadKey();

        }
    }
}
