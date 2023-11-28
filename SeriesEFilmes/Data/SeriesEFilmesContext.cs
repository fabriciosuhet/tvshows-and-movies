using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeriesEFilmes.Models;

namespace SeriesEFilmes.Data
{
    public class SeriesEFilmesContext : DbContext
    {
        public SeriesEFilmesContext (DbContextOptions<SeriesEFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<SeriesEFilmes.Models.Movie> Movie { get; set; } = default!;
    }
}
