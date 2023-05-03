using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PAGESNET.models;
using RazorPagesMovie.Data;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace PAGESNET.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }
        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)] // uma anotação que permite que a propriedadade seja vinculada a uma solicitação HtppGet
        public string? SearchString { get; set; }
        public SelectList Genres { get; set; } // anotação que atribui a propiedade uma lista de entrada para o usuario

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
    
        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
    
}
