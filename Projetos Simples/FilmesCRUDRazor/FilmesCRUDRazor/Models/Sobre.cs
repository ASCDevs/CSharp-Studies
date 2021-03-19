using System;
using Microsoft.EntityFrameworkCore;

namespace FilmesCRUDRazor.Models
{    
    [Keyless]
    public class Sobre
    {
        public string NomeAutorPage { get; set; }
        public string TextoPagina { get; set; }
        public string linkPaginaPessoal { get; set; }
    }
}