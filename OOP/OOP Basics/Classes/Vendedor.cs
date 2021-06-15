
using System;

namespace Classes
{
    class Vendedor : Pessoa
    {

        private int idVendedor { get; }
        private Loja lojaEmpregada { get; set; }

        public Vendedor(String cpf, String nome, String sobrenome, DateTime dataNascimento, String sexo, int idVendedor, Loja lojaEmpregada) : base(cpf,nome,sobrenome,dataNascimento,sexo)
        {
            this.idVendedor = idVendedor;
            this.lojaEmpregada = lojaEmpregada;
        }

    }
}
