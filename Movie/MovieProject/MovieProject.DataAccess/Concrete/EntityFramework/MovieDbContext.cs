using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using MovieProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.DataAccess.Concrete.EntityFramework
{
    public class MovieDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MovieDb;Trusted_Connection=true");
        }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Core.Entities.Concrete.User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
