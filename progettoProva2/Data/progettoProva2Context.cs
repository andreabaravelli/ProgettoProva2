using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using progettoProva2.Models;

namespace progettoProva2.Data
{
    public class progettoProva2Context : DbContext
    {
        public progettoProva2Context (DbContextOptions<progettoProva2Context> options)
            : base(options)
        {
        }

        public DbSet<progettoProva2.Models.Job> Job { get; set; } = default!;
    }
}
