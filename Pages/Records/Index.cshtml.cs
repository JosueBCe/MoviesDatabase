using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesDatabase.Data;
using MoviesDatabase.Models;

namespace MoviesDatabase.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MoviesDatabase.Data.ScriptureJournalContext _context;

        public IndexModel(MoviesDatabase.Data.ScriptureJournalContext context)
        {
            _context = context;
        }

        // Search Functionality by search string and Book
        [BindProperty(SupportsGet = true)]
        public string SortByDate { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SortByBook { get; set; }


        public IList<Scriptured> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public SelectList Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string MovieBook { get; set; }



        public async Task OnGetAsync()
        {

            IQueryable<string> BookQuery = from m in _context.Scriptured
                                            orderby m.Book
                                            select m.Book;

            // Getting the movies from the Database
            var movies = from m in _context.Scriptured
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                // Filter for what is in the search bar
                movies = movies.Where(s => s.Scripture.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieBook))
            {
                // Filter by category
                movies = movies.Where(movie => movie.Book == MovieBook); 
            }


            // Sort by ascending / descending date 
            if (!string.IsNullOrEmpty(SortByDate))
            {
                if (SortByDate == "ascending")
                {
                    movies = movies.OrderBy(movie => movie.CreationDate);
                }
                else if (SortByDate == "descending")
                {
                    movies = movies.OrderByDescending(movie => movie.CreationDate);
                }
            }


            // Sort alphabetically
            if (!string.IsNullOrEmpty(SortByBook))
            {
                if (SortByBook == "ascending")
                {
                    movies =  movies.OrderBy(movie => movie.Book);
                }
                else if (SortByBook == "descending")
                {
                    movies = movies.OrderByDescending(movie => movie.Book);
                }
            }




            Books = new SelectList(await BookQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();


        }
    }
}
