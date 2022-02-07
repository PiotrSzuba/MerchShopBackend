using MerchShop.Data;
using MerchShop.Models;
using MerchShop.Utilities;
using Microsoft.EntityFrameworkCore;

namespace MerchShop.DefaultData
{
    public class DefaultUsers
    {
        public static void Initialize(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = "sakonir@gmail.com",
                    UserName = "Admin",
                    Password = Hasher.HashEncode256("12345"),
                    Role = "admin",
                    Name = "Piotr",
                    Surname = "Szuba",
                },
                new User
                {
                    Id = 2,
                    Email = "sakonir2@gmail.com",
                    UserName = "RegularUser1",
                    Password = Hasher.HashEncode256("12345"),
                    Role = "regular",
                    Name = "War",
                    Surname = "Wick",
                },
                new User
                {
                    Id = 3,
                    Email = "sakonir3@gmail.com",
                    UserName = "RegularWorker",
                    Password = Hasher.HashEncode256("1234"),
                    Role = "worker",
                    Name = "Ur",
                    Surname = "Got",
                }
            );
        }
    }
}
