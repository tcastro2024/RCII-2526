using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_4___ficha_de_exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FICHA DE EXERCICIOS
            //1.Faça um programa que calcule a área do triangulo.
            //Formula: área = (base x altura) / 2.

            //base é uma palavra reservada da linguagem C#
            // ou seja não se pode usar
            // quem utiliou na ficha não vai ser prejudicado
            //double area, base1, altura;

            //Console.WriteLine("Valor da base: ");
            //base1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Valor da altura: ");
            //altura = double.Parse(Console.ReadLine());

            //area = (base1 * altura) / 2;

            //Console.WriteLine("Resultado do cálculo da área: " + area);

            //2.Faça um programa para verificar o maior de dois números inteiros(Utilize a
            //estrutura if-else).

            //int numero1, numero2;
            ////int n1, n2, maior; -> outra designação exemplo para as variaveis

            //Console.WriteLine("Digite o 1º número: ");
            //numero1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 2º número: ");
            //numero2 = int.Parse(Console.ReadLine());

            //if (numero1 > numero2)
            //{
            //    Console.WriteLine("O número " + numero1 + " é o maior.");
            //}
            //else if (numero2 > numero1)
            //{
            //    Console.WriteLine("O número " + numero2 + " é o maior.");
            //}
            //else
            //{
            //    Console.WriteLine("O número " + numero1 + " e o número " 
            //        + numero2 + " são iguais.");
            //}


            //3.Leia n valores representativos do pH e mostre, para cada valor, que tipo de
            //solução representa: ácida(pH < 7), neutra(pH = 7) ou alcalina(pH> 7) (Utilize a
            //estrutura for).

            //int qtdPh;
            //double ph;

            //Console.WriteLine("Quantos valores de ph vamos verificar: ");
            //qtdPh = int.Parse(Console.ReadLine()); // qtd = 5

            ////i = 5 | qtdPh = 5 -> 5 < 5 -> Se "int i = 1; i < qtdPh"
            //// -> Só vão ser feitas 4 verificações de ph e está errado
            //// se o qtdPh = 5 

            //for (int i = 0; i < qtdPh; i++)
            //{
            //    Console.WriteLine("Digite o " + (i + 1) + "º valor de ph: ");
            //    ph = double.Parse(Console.ReadLine());

            //    if (ph > 7)
            //    {
            //        Console.WriteLine("O PH com o valor " + ph + " é alcalino.");
            //    }
            //    else if (ph == 7) // 7 == 7 ok entra no else if
            //    {
            //        Console.WriteLine("O PH com o valor " + ph + " é neutro.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("O PH com o valor " + ph + " é ácido.");
            //    }
            //}


            //4.Leia o número de peças que chegam a uma empresa correspondente
            //a um número desconhecido
            //de entregas e no final mostre a média de peças para o total de entregas
            //realizadas(Utilize a estrutura while).

            int qtdEncomendas = 0, numeroPecas = 0, somaPecas = 0;
            double media = 0.0;

            while (numeroPecas != -1)
            {
                Console.WriteLine((qtdEncomendas +1) +"º número de peças recebido ou " +
                    "-1 para parar o programa: ");
                numeroPecas = int.Parse(Console.ReadLine());
                //1º numeroPecas = 9
                //2º numeroPecas = 5
                //3º numeroPecas = 0
                //4º numeroPecas = -1 caso não tenha a verificação

                if (numeroPecas == -1)
                {
                    break;
                }

                // outra poibilidade somaPecas += numeroPecas; // -> somador
                somaPecas = somaPecas + numeroPecas; // 0 = 0 + 9 -> somaPecas = 9
                //somaPecas = somaPecas + numeroPecas; // 9 = 9 + 5 -> somaPecas = 14
                //somaPecas = somaPecas + numeroPecas; // 14 = 14 + 0 -> somaPecas = 14
                //somaPecas = somaPecas + numeroPecas; // 14 = 14 + -1 -> somaPecas = 13

               //qtdEncomendas++;
               qtdEncomendas = qtdEncomendas + 1; //-> contador
               //qtdEncomendas = qtdEncomendas + 1; // 0 = 0 + 1 -> somaPecas = 1
               //qtdEncomendas = qtdEncomendas + 1; // 1 = 1 + 1 -> somaPecas = 2
               //qtdEncomendas = qtdEncomendas + 1; // 2 = 2 + 1 -> somaPecas = 3
            }

            media = (double) somaPecas / qtdEncomendas;

            Console.WriteLine("Media total de pecas entregues: " + media);



            #endregion

        }
    }
}
