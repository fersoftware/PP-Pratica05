using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método VerificaPrimo que recebe um número inteiro e exibe se esse número é
 * ou não primo. (Dica: para saber se o número é primo, veja quantos divisores o número
 * tem, ou seja, verifique se ele é divisível por 1, por 2, por 3, etc. até ele próprio, e conte
 * quantos divisores são. Se o número de divisores for 2, então ele é primo.) Escreva o
 * método Main que solicita que o usuário digite vários valores positivo e chame o método
 * VerificaPrimo para exibir se o número lido é primo ou não. O programa deve encerrar
 * quando o usuário digitar um valor negativo. 
*/

namespace PP_Pratica05
{
    class NumeroPrimo
    {
        public void exibir()
        {
            int n;

            do
            {
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                VerificaPrimo(n);
            } while (n >= 0);
        }

        public void VerificaPrimo(int n)
        {
            int c = 0;
            for (int i = 1; i < (n + 1); i++)
            {
                if (n % i == 0) c++;
            }
            if (c != 2)
            {
                Console.WriteLine("Não é número primo");
            }
            else
            {
                Console.WriteLine("É número primo");
            }
        }
    }
}
