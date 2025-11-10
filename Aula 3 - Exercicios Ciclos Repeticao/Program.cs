using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3___Exercicios_Ciclos_Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Mostre a tabuada de um número.
            //int numero, resultadoCalculo;

            //Console.WriteLine("Digite o número da tabuada a verificar: ");
            //numero = int.Parse(Console.ReadLine());

            ////Assume-se que a quantidade é até 10
            //Console.WriteLine("**** Tabuada do " + numero + " **** ");
            //for (int i = 1; i <= 10; i++)
            //{     
            //    resultadoCalculo = numero * i;
            //    Console.WriteLine(numero + " x " + i + " = " + resultadoCalculo);
            //}

            //Console.WriteLine("**** FIM DO PROGRAMA **** ");

            //2.Conte quantas vogais(a, e, i, o, u) existem em uma palavra.

            //string palavra; // sala -> 4 caracteres
            //int contadorVogais = 0;

            //Console.WriteLine("Digite a palavra a verificar: ");
            //palavra = Console.ReadLine();


            ////palavra.Length = 4 se a palavra for sala ou outra c/4 caracteres
            ////.Length tambem conta espaços vazios "sa la" -> palavra.Length = 5
            //for (int i = 0; i < palavra.Length; i++)
            //{
            //    //contar vogais
            //    // 5 vogais
            //    //Estratégia
            //    // 5 vogais e temos a palavra "sala"
            //    // resultado = 2

            //    //se letraDaPalavra == "a"
            //    // contadorVogais += 1
            //    // contadorVogais++
            //    // contadorVogais = 0
            //    // contadorVogais = contadorVogais + 1 <- utilizada
            //    // 0 = 0 + 1;
            //    // 1 | contadorVogais = 1
            //    // contadorVogais = contadorVogais + 1 <- utilizada
            //    // 1 = 1 + 1;
            //    // contadorVogais = 2
            //    //
            //    //se letraDaPalavra == "e"
            //    //se letraDaPalavra == "i"
            //    //se letraDaPalavra == "o"
            //    //se letraDaPalavra == "u"
            //    //
            //    //

            //    // palavra[i] = Corresponde a uma posição de um texto inserido
            //    // palavra[0] = Corresponde a 1º posição de um texto inserido
            //    // palavra[1] = Corresponde a 2º posição de um texto inserido
            //    // palavra[2] = Corresponde a 3º posição de um texto inserido
            //    // ...
            //    if (palavra[i].ToString() == "a")
            //    {
            //        contadorVogais = contadorVogais + 1;
            //    }
            //    else if (palavra[i].ToString() == "e")
            //    {
            //        contadorVogais = contadorVogais + 1;
            //    }
            //    else if (palavra[i].ToString() == "i")
            //    {
            //        contadorVogais = contadorVogais + 1;
            //    }
            //    else if (palavra[i].ToString() == "o")
            //    {
            //        contadorVogais = contadorVogais + 1;
            //    }
            //    else if (palavra[i].ToString() == "u")
            //    {
            //        contadorVogais = contadorVogais + 1;
            //    }
            //}

            ////if (palavra[i] == "u")

            //Console.WriteLine("Quantidade de vogais " +
            //    "da palavra '" + palavra + "' são: " + contadorVogais );




            //EXERCICIO 3: Classificar varias notas utilizando o for
            //Exemplo: nota > 15 ("Bom"), nota >= 9.5 ("suficiente"),
            // nota < 9.5 ("insuficiente")

            //int qtdDeNotas;
            //double nota;
            ////bool AlunoAprovado = false; //true 
            ////string nome = "Artur Leal"; //texto

            ////C.WL( -> ALTERNATIVA no teste
            ////obter a quantidade a verificar
            //Console.WriteLine("Quantidade de notas a verificar: ");
            //qtdDeNotas = int.Parse(Console.ReadLine());

            //for (int i = 0; i < qtdDeNotas; i++)
            //{
            //    Console.WriteLine("Digita a " + (i + 1) + "º nota: ");
            //    nota = double.Parse(Console.ReadLine());

            //    if (nota >= 15)
            //    {
            //        Console.WriteLine("A nota: " + nota + " têm classificação de bom.");
            //    }
            //    else if (nota >= 9.5)
            //    {
            //        Console.WriteLine("A nota: " + nota + " têm classificação de suficiente.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A nota: " + nota + " têm classificação de insuficiente.");
            //    }
            //}

            //EXERCICIO 3.1 
            // Para quem já fez
            // areas ( area > 100 m2 = muito grande), 
            // areas ( area > 50 m2 = grande), 
            // areas ( area > 20 m2 = media), 
            // areas ( area > 5 m2 = pequena), 
            //int qtdDeAreas;
            //double area;
            ////bool AlunoAprovado = false; //true 
            ////string nome = "Artur Leal"; //texto

            ////C.WL( -> ALTERNATIVA no teste
            ////obter a quantidade a verificar
            //Console.WriteLine("Quantidade de areas a verificar: ");
            //qtdDeAreas = int.Parse(Console.ReadLine());

            //for (int i = 0; i < qtdDeAreas; i++)
            //{
            //    Console.WriteLine("Digita a " + (i + 1) + "º area: ");
            //    area = double.Parse(Console.ReadLine());

            //    if (area > 100)
            //    {
            //        Console.WriteLine("A area: " + area + " têm classificação de muito grande.");
            //    }
            //    else if (area > 50)
            //    {
            //        Console.WriteLine("A area: " + area + " têm classificação de grande.");
            //    }
            //    else if (area > 20)
            //    {
            //        Console.WriteLine("A area: " + area + " têm classificação de média.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("A area: " + area + " têm classificação de pequena.");
            //    }
            //}

            //4. Leia o número de golos marcados por uma equipa de futebol em um numero
            // desconhecido de jogos e no final mostre a média de golos por jogo(while).

            int numGolos = 0, somaGolos = 0, contadorDeJogos = 0;
            double media = 0.0;

            //numGolos = 0
            // 0 != 1  -> verdade
            while (numGolos != -1)
            {
                Console.WriteLine("Numero de golos do jogo " + (contadorDeJogos + 1) + "" +
                    " ou digite -1 para terminar o programa: ");
                numGolos = int.Parse(Console.ReadLine());

                if (numGolos == -1)
                {
                    break;
                }

                somaGolos = somaGolos + numGolos;
                contadorDeJogos = contadorDeJogos + 1;
            }

            media = somaGolos / contadorDeJogos;

            Console.WriteLine("Media de golos por jogo: " +  media);


            // Contar carros que entraram num parque de estacionamento
            // Contar alunos que entraram no ipca
        }
    }
}
