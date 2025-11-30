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
            //    //Console.WriteLine("O número " + numero1 + " é o maior.");
            //    return "O número " + numero1 + " é o maior.";
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

            //int qtdEncomendas = 0, numeroPecas = 0, somaPecas = 0;
            //double media = 0.0;

            //while (numeroPecas != -1)
            //{
            //    Console.WriteLine((qtdEncomendas +1) +"º número de peças recebido ou " +
            //        "-1 para parar o programa: ");
            //    numeroPecas = int.Parse(Console.ReadLine());
            //    //1º numeroPecas = 9
            //    //2º numeroPecas = 5
            //    //3º numeroPecas = 0
            //    //4º numeroPecas = -1 caso não tenha a verificação

            //    if (numeroPecas == -1)
            //    {
            //        break;
            //    }

            //    // outra poibilidade somaPecas += numeroPecas; // -> somador
            //    somaPecas = somaPecas + numeroPecas; // 0 = 0 + 9 -> somaPecas = 9
            //    //somaPecas = somaPecas + numeroPecas; // 9 = 9 + 5 -> somaPecas = 14
            //    //somaPecas = somaPecas + numeroPecas; // 14 = 14 + 0 -> somaPecas = 14
            //    //somaPecas = somaPecas + numeroPecas; // 14 = 14 + -1 -> somaPecas = 13

            //   //qtdEncomendas++;
            //   qtdEncomendas = qtdEncomendas + 1; //-> contador
            //   //qtdEncomendas = qtdEncomendas + 1; // 0 = 0 + 1 -> somaPecas = 1
            //   //qtdEncomendas = qtdEncomendas + 1; // 1 = 1 + 1 -> somaPecas = 2
            //   //qtdEncomendas = qtdEncomendas + 1; // 2 = 2 + 1 -> somaPecas = 3
            //}

            //media = (double) somaPecas / qtdEncomendas;

            //Console.WriteLine("Media total de pecas entregues: " + media);

            //WHILE DO TESTE
            //Leia um número desconhecido de valores reais e mostre
            //a média dos números positivos(ignorando todos os
            //valores zero e números negativos lidos) (utilizar o while). (3 valores)

            //int contaTotal = 0, contaPos = 0, numero = -1;
            //double media = 0.0;

            //while (numero != 0)
            //{
            //    Console.WriteLine("Digite um número ou 0 para terminar: ");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero > 0)
            //    {
            //        //As duas formas dão contaPos++ ou contaPos = contaPos + 1
            //        contaPos = contaPos + 1;
            //        //contaPos++; 
            //        Console.WriteLine("Nº de positivos: " + contaPos);
            //    }
            //    else if (numero == 0)
            //    {
            //        break;
            //    }

            //    contaTotal++;
            //}

            //// Positas = 1
            //// Valores introduzidos 3
            //// media = 1/3 = 33.3333 %
            ////media = (double)contaPos / contaTotal;

            //Media(contaPos, contaTotal);
            ////Media(25.5, 35.6);
            //// media = MediaEntreInteiros(contaPos, contaTotal);

            //  Console.WriteLine("Resultado da média: " + (media * 100) + " % ");

            #endregion


            #region METODO MAIOR DE IDADE

            //int idade;
            //bool maiorDeIdade = false;

            //Console.WriteLine("Idade: ");
            //idade = int.Parse(Console.ReadLine());

            //maiorDeIdade = MaiorDeIdade(idade);

            ////if (MaiorDeIdade(idade) == true)
            //if (maiorDeIdade == true)
            //{
            //    Console.WriteLine("Já pode tirar a carta sem ser especial aos 16.");
            //}
            //else
            //{
            //    Console.WriteLine("Faltam " + (18 - idade) + " ano para poder tirar a carta");
            //}

            #endregion

            #region MEDIA DA UC PROGRAMACAO COM RECURSO A UM METODO
            //2.Método que calcule a média da UC.
            // MEDIA = (50% * TESTE) + (40% * PROJ) + (10% * ASSIDUIDADE)

            double teste, proj, assiduidade, media;

            Console.WriteLine("Nota de teste: ");
            teste = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota de projeto: ");
            proj = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota de assiduidade: ");
            assiduidade = double.Parse(Console.ReadLine());

            media = MediaProgramacao(teste, proj, assiduidade);

            Console.WriteLine("Media Programação: " + media);

            #endregion

            int[] scores = { 1, 2, 3, 4, 5 };
            //scores[0]; == 1
            //0 É O MESMO QUE A 1º POSIÇÃO DO ARRAY OU SEJA 
            // scores[0] = 1
            scores[0] = 29;


        }

        //Metodo MEDIA DA UC PROGRAMACAO
        public static double MediaProgramacao(double teste, double proj, double assiduidade)
        {
            double media;

            media = (teste * 0.50) + (proj * 0.40) + (assiduidade * 0.10);

            return media;
        }

        //Metodo maior de idade
        public static bool MaiorDeIdade(int idade)
        {
            bool MaiorDeIdade = false;

            if (idade >= 18)
            {
                MaiorDeIdade = true;
            }

            return MaiorDeIdade;
        }

        //static <tipodedados> <NomeDoMétodo>(<parâmetros>)
        //{
        //// Código do método
        //}
        //}

        //Dados de retorno
        //public static double
        //public static int
        //public static string
        //public static bool
        //public static void
        public static void Media(int numerador, int denominador)
        {
            double media = 0.0;

            media = (double)numerador / denominador;

            //return media; PORQUE DEVOLVEMOS VOID (VAZIO)
            Console.WriteLine("Media: " + (media * 100) + " %");
        }

        public static void Media(double numerador, double denominador)
        {
            double media = 0.0;

            media = (double)numerador / denominador;

            //return media;
            Console.WriteLine("Media: " + (media * 100) + " %");
        }
    }
}
