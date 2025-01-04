using Microsoft.EntityFrameworkCore;
using ProjectC.SharedEntities;
using Shared.Database.MainDatabase.Repositories;

namespace Shared.Database.MainDatabase;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var dbContext = new MainDbContext();
        //var repo = new MessageRepository(dbContext);
        var repo = new UserRepository(dbContext);
        Console.WriteLine(repo.VerifyPassword(2, "hjgjhj"));
        Console.WriteLine(repo.VerifyPassword(2, "dfsjgfgug"));
        Console.WriteLine(repo.VerifyPassword(2, "passwordtest"));

        //repo.Create(new User()
        //{
        //    Email = "testPass@gmail.com",
        //    PasswordHash = "passwordtest",
        //    Age = 30,
        //    Gender = true,
        //    IsActiv = true,
        //    FirstName = "Masha",
        //    SecondName = "Petrova"

        //});


        //var message = repo.Get(1);
        // if (message != null)
        // {
        //     Console.WriteLine(message.Body);
        // }

        //repo.GetRangeByIds([1, 2, 3 ], 10);
        //var b = repo.Update(new Message()
        //{ 
        //    AuthorID = 1,
        //    Body = "Hellow",
        //    Title = "Test",
        //    UniqId = 1,    
        //});

        //if (b)
        //{
        //    Console.WriteLine("OK");
        //}
        //else
        //{
        //    Console.WriteLine("Повторите позже");
        //}


        //dbContext.Messages.Add(new Message()
        //{
        //    Body = "cs",
        //    Title = "Message",
        //    AuthorID = 1

        //});

        //dbContext.SaveChanges();
        //var mes = dbContext.Messages.Include(x => x.Producer). FirstOrDefault();
        //Console.WriteLine(mes.Producer.Email);


        ////dbContext.Users.Add(new User()
        ////{
        ////    FirstName = "Oleg",
        ////    SecondName = "Ivanov",
        ////    Email = "Test2",
        ////    PasswordHash = "Password2",
        ////    Age = 22,
        ////    Gender = false,

        ////});
        ////dbContext.SaveChanges();

        //Console.WriteLine("===================================");

        ////var user = dbContext.Users.AsNoTracking().FirstOrDefault(u => u.Id == 4); -- без отслеживания
        ////var user = dbContext.Users.FirstOrDefault(u => u.Id == 4);

        ////if (user != null)
        ////{

        ////    Console.WriteLine($" User found. ID:{user.Id}, Name: {user.FirstName}.");

        ////}
        ////else
        ////{
        ////    Console.WriteLine("User not found.");
        ////}

        //Console.WriteLine("===================================");
        //var users = dbContext.Users.Where(u => u.Age <25);
        ////dbContext.Users.Add(new User()
        ////{
        ////    FirstName = "Vasya5",
        ////    SecondName = "Petrov5",
        ////    Email = "Test5",
        ////    PasswordHash = "Password5",
        ////    Age = 18,
        ////    Gender = false,
        ////});
        ////foreach (var u in users)
        ////{
        ////    Console.WriteLine($" User found. ID:{u.Id}, Name: {u.FirstName}.");

        ////}

        ////dbContext.Users.Remove(new User() { Id = 5 });
        ////user.Email = "ho-ho-ho";
        ////dbContext.Users.Update(user);
        ////{
        ////    Id = 4,
        ////    FirstName = "Vasya",
        ////    SecondName = "Petrov",
        ////    Email = "Test2",
        ////    PasswordHash = "Password2",
        ////    Age = 55,
        ////    Gender = false,
        ////}

        //dbContext.SaveChanges();

        //Console.WriteLine("===================================");

        //users = dbContext.Users.Where(u => u.Age > 25);//.Skip(10).Take(10);
        //foreach (var u in users)
        //{
        //    Console.WriteLine($" User found. ID:{u.Id}, Name: {u.FirstName}.");

        //}

    }


}
