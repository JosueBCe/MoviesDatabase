using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesDatabase.Data;
using MoviesDatabase.Models;

namespace MoviesDatabase.Pages.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly MoviesDatabase.Data.ScriptureJournalContext _context;

        public DeleteModel(MoviesDatabase.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Scriptured Movie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Scriptured == null)
            {
                return NotFound();
            }

            var movie = await _context.Scriptured.FirstOrDefaultAsync(m => m.ID == id);

            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Scriptured == null)
            {
                return NotFound();
            }
            var movie = await _context.Scriptured.FindAsync(id);

            if (movie != null)
            {
                Movie = movie;
                _context.Scriptured.Remove(Movie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
