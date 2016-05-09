using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método CalculaMedia que recebe um número inteiro n e solicita que o usuário
 * digite n números. O método deve ler n números e exibir a sua média. Escreva o método
 * Main que solicita que o usuário digite a quantidade de números que deverão ser lidos
 * pelo método. Esse número não pode ser menor ou igual a zero. Chame o método
 * CalculaMedia
 */

namespace PP_Pratica05
{
    class CalculaMedia
    {
        public void exibir()
        {
            Console.WriteLine("Digite a quantidade de número:");
            int qtd = int.Parse(Console.ReadLine());
            if (qtd > 0) calculaMedia(qtd);
        }

        public void calculaMedia(int qtd)
        {
            int n, soma = 0;

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                soma += n;
            }

            Console.WriteLine("A média é {0}", soma / qtd);
        }
    }
}
