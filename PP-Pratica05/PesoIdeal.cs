using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método CalculaPesoIdeal, que recebe o sexo (caractere ‘M’ ou ‘F’) e a altura de
 * uma pessoa (em metros). Este método deverá calcular e exibir o peso ideal dessa pessoa. 
 * Escreva também o método Main, que solicita que o usuário digite os valores
 * correspondentes a pessoas diferentes e chame o método CalculaPesoIdeal para exibir o
 * peso ideal de cada uma delas. A fórmula para calcular o peso ideal é:
 * Para mulheres: (62.1 * altura) – 44.7
 * Para homens: (72.7 * altura) - 58
*/

namespace PP_Pratica05
{
    class PesoIdeal
    {
        public void exibir()
        {
            Console.Write("Digite o Sexo, M  ou F: ");
            string sexo = Console.ReadLine();
            Console.Write("Digite sua altura: ");
            float alt = float.Parse(Console.ReadLine());
            CalculaPesoIdeal(sexo, alt);
        }

        public void CalculaPesoIdeal(string sexo, float altura)
        {
            float pesoIdeal;
            if (sexo == "F")
            {
                pesoIdeal = (62.1f * altura) - 44.7f;

            }
            else
            {
                pesoIdeal = (72.1f * altura) - 58;
            }
            Console.WriteLine("O peso ideal é: {0}", pesoIdeal);
        }
    }
}
