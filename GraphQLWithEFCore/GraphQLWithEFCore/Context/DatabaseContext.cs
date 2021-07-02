using GraphQLWithEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLWithEFCore.Context
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id=1,
                    Name="Raiyan",
                    Roll="1001"
                },
                new Student
                {
                    Id = 2,
                    Name = "Sharif",
                    Roll = "1002"
                },
                new Student
                {
                    Id = 3,
                    Name = "Rohit",
                    Roll = "1003"
                }
                );
        }
    }
}
