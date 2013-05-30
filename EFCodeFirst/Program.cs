using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a user with 2 adresses
            Models.User user = new Models.User
            {
                FirstName = "John",
                LastName = "Doe",
                Gender = Models.Gender.Male
            };

            user.Addresses.Add(new Models.Address
            {
                HouseNumber = "5 bis",
                StreetName = "rue du longpot",
                PostalCode = "59000",
                Town = "Lille",
                Country = "France"
            });

            user.Addresses.Add(new Models.Address
            {
                HouseNumber = "165",
                StreetName = "avenue de bretagne",
                PostalCode = "59000",
                Town = "Lille",
                Country = "France"
            });

            using (EFCodeFirst.Context context = new EFCodeFirst.Context())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
