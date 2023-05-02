using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PAGESNET.models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; } 

        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; } // atributo do tipo date
        public string? Genre { get; set; } // ? = propriedade anulavel, pode ser atribuido valor nulo
        public decimal Price { get; set; }
    }
}