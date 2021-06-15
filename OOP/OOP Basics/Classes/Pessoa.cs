using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Pessoa
    {
        private String cpf { get; set; }
        private String nome { get; set; }
        private String sobrenome { get; set; }
        private DateTime dataNascimento { get; set; }
        private String sexo { get; set; }
        private Endereco endereco { get; set; }

        public Pessoa(String cpf,String nome, String sobrenome, DateTime dataNascimento, String sexo)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
        }

        public Pessoa()
        {

        }

        public String getNomeCompleto()
        {
            return nome + " " + sobrenome;
        }



    }
}
