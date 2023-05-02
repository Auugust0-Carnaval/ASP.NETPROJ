using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace PAGESNET.models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; } 

        [Display(Name = "Realese Date")] //a exibiçao do campo (propriedade) ao invez de realeseDate fica : Realese Date
        [DataType(DataType.Date)]
        public DateTime RealeseDate { get; set; } // atributo do tipo date
        public string? Genre { get; set; } // ? = propriedade anulavel, pode ser atribuido valor nulo

        [Column(TypeName = "decimal(18,2)")] //Adiciona o tipo de coluna na base de dados usando EF, com 18 digitos e duas casa descimais
        public decimal Price { get; set; }
    }
}