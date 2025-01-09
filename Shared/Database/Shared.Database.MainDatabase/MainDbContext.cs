using Microsoft.EntityFrameworkCore;
using ProjectC.SharedEntities;
using Shared.Database.MainDatabase.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Database.MainDatabase;

public class MainDbContext : DbContext
{    
    public DbSet<User> Users { get; set; }
    public DbSet<Message> Messages { get; set; }

    public MainDbContext()
    {
        
        //Database.EnsureCreated();
        //Database.EnsureDeleted();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=main_db;Username=main_user;Password=main_password");

        //optionsBuilder.UseSqlite("Data Source=C:\\Users\\User\\Desktop\\IrinaC\\test_db_study_2024_11.db");
        optionsBuilder.UseSqlServer("workstation id=StudyDatabase14.mssql.somee.com;packet size=4096;user id=IrinaKu;pwd=IrinaKu14;data source=StudyDatabase14.mssql.somee.com;persist security info=False;initial catalog=StudyDatabase14;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasData(new User()
        { 
        Id = 1,
        FirstName="Admin",
        SecondName="Main",
        Age=50,
        Email="admin@mail.com",
        PasswordHash="password",
        PasswordSalt="password1",
        Gender = true,
        });

        modelBuilder.ApplyConfiguration(new MessageCreatingConfiguration());
    }

}
