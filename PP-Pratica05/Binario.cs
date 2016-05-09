using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escrava o método ConverteBinario que recebe um número inteiro e exibe a conversão
 * desse número em binário. Por exemplo, 12 corresponde a 1100 em binário, 3
 * corresponde a 11. Escreva o método Main que solicita que o usuário digite vários valores
 * positivos e chame o método ConverteBinario para exibir o correspondente em binário dos
 * valores lidos. O programa deve encerrar quando o usuário digitar um valor negativo.
*/

namespace PP_Pratica05
{
    class Binario
    {
        public void exibir()
        {
            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            ConverteBinario(n);
        }

        public void ConverteBinario(int n)
        {
            string y = "";
            int x = n / 2;
            int x1 = x * 2;
            int x2 = n - x1;
            string y0 = x2.ToString();
        
            do
            {
                n = x;
                x = n / 2;
                x1 = x * 2;
                x2 = n - x1;
                y += x2;                
            } while (x > 0);
            Console.WriteLine(y0+y);
        }
    }
}
