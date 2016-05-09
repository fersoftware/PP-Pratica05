using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método ClassificaIdade (que não retorna nada) que recebe uma idade e imprime
 * uma mensagem conforme a faixa etária à qual pertence a idade. De 0 a 2 anos - “Bebê”,
 * de 3 a 11 anos - “Criança”, de 12 a 19 anos - “Adolescente”, de 20 a 30 anos - “Jovem”,
 * de 31 a 60 anos - “Adulto”, acima de 60 anos - “Idoso”. Escreva o método Main que
 * solicita que o usuário digite a sua idade, e que chama esse método, para testá-lo. 
 */

namespace PP_Pratica05
{
    class FaixaEtaria
    {
        public void exibir()
        {
            Console.Write("Digite a sua idade:");
            int idade = int.Parse(Console.ReadLine());
            ClassificaIdade(idade);
        }

        public void ClassificaIdade(int idade)
        {
            if (idade >= 0 && idade < 2)
            {
                Console.WriteLine("Bebê");
            }
            else if (idade >= 3 && idade < 11)
            {
                Console.WriteLine("Criança");
            }
            else if (idade >= 12 && idade < 19)
            {
                Console.WriteLine("Adolecente");
            }
            else if (idade >= 20 && idade < 30)
            {
                Console.WriteLine("Jovem");
            }
            else if (idade >= 31 && idade < 60)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade >= 60)
            {
                Console.WriteLine("Idoso");
            }
            else
            {
                Console.WriteLine("Erro no Sistema {0}", idade);
            }
        }
    }
}
