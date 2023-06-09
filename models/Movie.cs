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

        [StringLength(60, MinimumLength = 03)] // classe que faz o requirimento do tamanho da string
        [Required] // valor desse atributo nao pode ser invalido 
        public string Title { get; set; } = string.Empty;

        //[Display(Name = "Realese Date")] a exibiçao do campo (propriedade) ao invez de realeseDate fica : Realese Date
        [DataType(DataType.Date)]
                                                            //ApplyFormatInEditMode o formato de exibiçao tambem e aplicado durante a alteracao ou insercao dos dados dessa prop
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)] // anotação que define a forma de exibição na tela do usuario

        public DateTime RealeseDate { get; set; } // atributo do tipo date

        [RegularExpression(@"^[A-Z]+[a-zA-z\s]*$")] // o que pode ser usado na propriedade
        [Required] //requer uma inserção de info
        [StringLength(30)] // quantidade de caracteres
        public string? Genre { get; set; } // ? = propriedade anulavel, pode ser atribuido valor nulo

        [Range(1,100)] // restringe o valor de 1 a 100
        [DataType(DataType.Currency)] // tiopos de dados "dinheiro/moeda
        [Column(TypeName = "decimal(18,2)")] //Adiciona o tipo de coluna na base de dados usando EF, com 18 digitos e duas casa descimais
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; } = string.Empty;
    }
}