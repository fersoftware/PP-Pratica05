using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método CalculaMedia, que recebe os valores de 2 notas e o peso da 1ª nota
 * (valor entre 0 e 1). O método deverá calcular e exibir a média ponderada das notas. Para
 * ]calcular a média ponderada, realize o cálculo: nota1 * peso + nota2 * (1-peso). Ou seja,
 * se a 1ª nota tem peso 0.5, a 2ª nota também tem peso 0.5. Se a 1ª nota tem peso 0.4, a
 * 2ª nota tem peso 0.6. Escreva o método Main para solicitar que o usuário digite valores
 * diferentes de notas e pesos e chame o método CalculaMedia para exibir a média
 * ponderada correspondente.
*/
namespace PP_Pratica05
{
    class CalculaMediaPeso
    {
        public void exibir()
        {
            Console.Write("Digite a Nota1: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o peso da Nota1: ");
            float pesoNota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a Nota2: ");
            float nota2 = float.Parse(Console.ReadLine());
            CalculaMedia(nota1, pesoNota1, nota2);
        }
        public void CalculaMedia(float n1, float p1, float n2)
        {
            float peso2 = 1 - p1, calc = n1 * p1 + n2 * peso2;
            Console.WriteLine("Média ponderada correspondente é: {0}", calc);
        }
    }
}
