using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Films.API.Model;

namespace Films.API.Data
{
    public class FilmsAPIContext : DbContext
    {
        public FilmsAPIContext (DbContextOptions<FilmsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Films.API.Model.Movie> Movie { get; set; } = default!;
    }
}
