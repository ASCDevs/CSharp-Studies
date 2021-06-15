using System;
using System.Globalization; //Necessário para usar CultureInfo

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataMarcada, dataHoje;
            dataMarcada = new DateTime(2021,06,01); //ano - mês - dia
            dataHoje = DateTime.Today;

            Loja loja1 = new Loja();
            Vendedor vendedor1 = new Vendedor("77788899944","Alexandre","Santos Cavalcante",new DateTime(1998,10,27),"Masculino",123456,loja1);
            Console.WriteLine("Nome do vendedor: "+vendedor1.getNomeCompleto());
            //Console.WriteLine("Data nascimento vendedor: "+ vendedor1.dataNascimento.ToString("d"));

            Console.WriteLine("==============================");
            Console.WriteLine("Data marcada 1: "+dataMarcada.ToString("d",CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine("Data marcada 2: "+dataMarcada.ToString("d"));
            Console.WriteLine("Data de hoje: " + dataHoje.ToString("d")); //Ja pega o local time (Fuso horário) da máquina atual
        }
    }
}
