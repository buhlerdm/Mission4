using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        // Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                    new ApplicationResponse
                    {
                        ApplicationId = 1,
                        Category = "Action",
                        Title = "Star Wars Revenge of the Sith",
                        Year = 2005,
                        Director = "George Lucas",
                        Rating = "PG-13",
                        Edited = true,
                        LentTo = "Mitch",
                        Notes = "Solid Movie"
                    },
                    new ApplicationResponse
                    {
                        ApplicationId = 2,
                        Category = "Action",
                        Title = "Star Wars Return of the Jedi",
                        Year = 1983,
                        Director = "Richard Marquand",
                        Rating = "PG",
                        Edited = true,
                        LentTo = "Max",
                        Notes = "A Classic"
                    },
                    new ApplicationResponse
                    {
                        ApplicationId = 3,
                        Category = "American sports drama",
                        Title = "Rocky",
                        Year = 1976,
                        Director = "John G. Avildsen",
                        Rating = "PG",
                        Edited = false,
                        LentTo = "Glenn",
                        Notes = "The greatest"
                    }
                );
        }
    }
}
