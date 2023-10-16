using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesDatabase.Models;

namespace MoviesDatabase.Data
{
    public class MoviesDatabaseContext : DbContext
    {
        public MoviesDatabaseContext (DbContextOptions<MoviesDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesDatabase.Models.Movie> Movie { get; set; } = default!;
    }
}
