using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Cliente : Pessoa
    {
        private int idCliente { get; set; }
        private DateTime dataCadastro { get; }
        private DateTime dataSaida { get; set; }

        public Cliente(String cpf, String nome, String sobrenome, DateTime dataNascimento, String sexo, DateTime dataCadastro) : base(cpf, nome, sobrenome, dataNascimento, sexo)
        {
            this.dataCadastro = dataCadastro;
        }
    }
}
