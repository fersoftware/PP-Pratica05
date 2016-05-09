using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método Potencia que recebe dois números e exibe o resultado da potência do
 * primeiro número elevado ao segundo número. Por exemplo, se o primeiro número for 2 e
 * o segundo for 3, o método deverá devolver 8 (= 2 elevado a 3). Utilize uma instrução for * ou while para calcular a potência. Escreva o método Main para testar esse método.
 */

namespace PP_Pratica05
{
    class Potencia
    {
        public void exibir()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Digite um número que será elevado: ");
            int x = int.Parse(Console.ReadLine());
            potencia(n, x);
        }
        public void potencia(int n, int x)
        {
            int y = 1;
            for (int i = 0; i < x; i++)
            {
                y *= n;
            }
            Console.WriteLine("O Valor de {0} elevado ao {1} é {2}", n, x, y);
        }
    }
}
