using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_e_Estrturas
{
    class DataTypesPrimitives
    {
        static void Main(String[] args)
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c; //Resulta no quociente
            int e = (a + b) % c; //Resulta no resto

            Console.WriteLine($"Quociente: {d}");
            Console.WriteLine($"Resto: {e}");

            //Decimais
            double d_res1 = 21 / 2;
            double d_res2 = (double)21 / 2; //cast para retornar resultado decimal
            Console.WriteLine($"Divisão com resultado sem cast: {d_res1}");
            Console.WriteLine($"Divisão com resultado com cast: {d_res2}");


            double a_preciso1 = 1.0;
            double b_preciso2 = 3.0;
            Console.WriteLine("Precisão double: "+(a_preciso1 / b_preciso2));

            decimal c_preciso1 = 1.0M;
            decimal d_preciso2 = 3.0M;
            Console.WriteLine("Precisão decimal: "+(c_preciso1 / d_preciso2));

            byte n_bytes = 0b_0110_1010; //106 em binário
            short num_curto;
            long num_longo;
            char caracter;
            float num_float;
            bool v_ou_f;
            


        }
    }
}
