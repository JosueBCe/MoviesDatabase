using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesDatabase.Data;
using MoviesDatabase.Models;

namespace MoviesDatabase.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MoviesDatabase.Data.ScriptureJournalContext _context;

        public CreateModel(MoviesDatabase.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Scriptured Movie { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Scriptured == null || Movie == null)
            {
                return Page();
            }

            _context.Scriptured.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
