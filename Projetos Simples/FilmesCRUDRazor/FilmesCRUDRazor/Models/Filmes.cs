using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Obrigatório o nome do filme")]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true )]
        [Required(ErrorMessage = "Digite uma data válida")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "Escreva o gênero do filme")]
        public string Genero { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency, ErrorMessage = "Deve ser valor monetário")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
    }
}