using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Escreva o método ValidaData (que não retorna nada) que recebe uma data (um valor
 * inteiro para o dia, um valor inteiro para o mês e um valor inteiro para o ano), e verifique
 * se a data é valida, ou seja, se o valor do mês está entre 1 e 12, e dependendo do mês, se
 * o dia está entre 1 e 30 ou entre 1 e 31. Verifique também se o ano é bissexto. Um ano é
 * bissexto quando ele for divisível por 4, mas não divisível por 100. Mas, há uma exceção,
 * se for divisível por 100 e por 400, o ano é bissexto. (ex: 1500 é divisível por 4 e por 100,
 * mas não por 400, e portanto não é bissexto. 1600 é divisível por 4 e por 100 e por 400,
 * então é bissexto). No caso do ano ser bissexto, o mês de fevereiro pode ter até 29 dias.]
 * Esse método deverá exibir uma mensagem, informando se o dia é inválido, ou se o mês é
 * inválido ou se a data é válida. Escreva o método Main que chama esse método, para
 * testá-lo. 
*/

namespace PP_Pratica05
{
    class ValidaData
    {
        public void exibir()
        {
            Console.Write("Digite o dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());
            validaData(dia, mes, ano);
        }

        public void validaData(int dia, int mes, int ano)
        {
            if (ano <= 0 || mes > 12 || mes < 01 || dia > 31 || dia < 1)
            {
                Console.WriteLine("Data Inválida");
            }
            else
            {
                if (mes == 2)
                {
                    ano = ano % 4;
                    if (ano == 0)
                    {
                        if (dia > 29)
                        {
                            Console.WriteLine("Data Inválida");
                        }
                        else
                        {
                            Console.WriteLine("Data Válida");
                        }
                    }
                    else
                    {
                        if (dia > 28)
                        {
                            Console.WriteLine("Data Inválida");
                        }
                        else
                        {
                            Console.WriteLine("Data Válida");
                        }
                    }
                }
                else
                {
                    if(mes == 4 || mes == 6 || mes == 9 || mes == 11)
                    {
                        if (dia > 30)
                        {
                            Console.WriteLine("Data Inválida");
                        }
                        else
                        {
                            Console.WriteLine("Data Válida");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data Válida");
                    }
                }
            }
        }
    }
}
