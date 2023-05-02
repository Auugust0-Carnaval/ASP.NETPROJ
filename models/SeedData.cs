using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace PAGESNET.models
{

    // classes estaticas (static pode ser acessado em qualquer lugar, e seus devivados dela (methods))
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                if(context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazonPagesMovieContext");
                }

                //Procure qualquer filme

                if(context.Movie.Any())
                {
                    return; // caso tenha qualquer filme na base de dados "return true"
                }

                //caso não tenha nengum filme na base de dados, ira adicionar os seguintes filmes (DI)

                //Addrange adiona nova lista a base de dados
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        RealeseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Vingadores",
                        RealeseDate = DateTime.Parse("2013-03-22"),
                        Genre = "Fantasy",
                        Price = 10.22M
                    },

                    new Movie
                    {
                        Title = "Vingadores Ultimato",
                        RealeseDate = DateTime.Parse("2021-01-24"),
                        Genre = "Fantasy",
                        Price = 20.22M
                    },

                    new Movie
                    {
                        Title = "Maze runner",
                        RealeseDate = DateTime.Now,
                        Genre = "Action",
                        Price = 50.99M

                    },

                    new Movie
                    {
                        Title = "Peter Pan",
                         RealeseDate = DateTime.Today,
                         Genre = "Kids",
                         Price = 5.00M
                    });
                    context.SaveChanges();
            }
        }

        
    }
}