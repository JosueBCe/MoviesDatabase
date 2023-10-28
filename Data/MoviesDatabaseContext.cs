using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesDatabase.Models;

namespace MoviesDatabase.Data
{
    public class ScriptureJournalContext : DbContext
    {
        public ScriptureJournalContext (DbContextOptions<ScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesDatabase.Models.Scriptured> Scriptured { get; set; } = default!;
    }
}
