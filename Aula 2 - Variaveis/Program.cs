using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2___Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configurar a consola para suportar caracteres UTF8 permitindo o uso do símbolo € e outros caracteres especiais
            Console.OutputEncoding = Encoding.UTF8;

            #region Exercícios de Algoritmos

            ////////////////////////////////////////////////// 
            // 1 - Identifique as variáveis da equação do 2º grau na forma ax² +bx - c = 0:

            // Solução: a, b, c, x

            ////////////////////////////////////////////////// 
            // 2 - Quais os argumentos de entrada e de saída para se calcular as raízes reais da equação?

            // Solução: ENTRADA - a, b, c | SAIDA - x

            ////////////////////////////////////////////////// 
            // 3 - Faça um algoritmo (forma narrativa) para calcular as raízes reais da equação.
            // Utilize objetos auxiliares se julgar necessário.

            // 1º Passo verificar variaveis a, b, c e x

            // 2º Passo verificar se a == 0 (validação)

            // 3º Verificar uma nova variavel designada de delta.
            // Esta nova variavel surge daquilo que se designa por norma de "REGRAS DE NEGOCIO".

            // 3.1º Declarar nova variavél: delta 
            // 3.2º Aplicar regra de acordo com o resultado do calculo delta = b² - 4 * a * c :
            // 3.3º Se delta < 0 : não há raízes reais 
            // 3.4º Se delta == 0: uma raiz real(-b / 2 * a)
            // 3.5º Se delta > 0 : duas raízes reais utilizando: ( -b ± √(b² - 4 * a * c) ) / 2 * a
            //
            // 4º Verificação do resultado para: 
            //
            // a = 5, b = 6, c = 5, x = ?
            //
            // 5x² +6x - 5 = 0

            ////////////////////////////////////////////////// 
            // 4 - Faça um algoritmo que converta uma temperatura fornecida em graus.
            // Fahrenheit para Centígrados. Sugestão: utilize a fórmula C = 5 / 9(F - 32).

            // Solução:
            // 1º Identificar variaveis C e F
            // 2º Atribuir valor a variável F. F = 55
            // 3º Aplicar formula para obter o valor da variavel C. C = 5 / 9 * ( 55 - 32 )
            // 4º A variável C = 23º 

            #endregion

            #region Exercícios com Variáveis

            ////////////////////////////////////////////////// 
            // 1 - Declare variáveis para armazenar: nome(string), idade(int) e altura(double) e se é
            // estudante(bool).Atribua valores e mostre-os na consola.

            // 1º Declarar variáveis
            //string nome;
            //int idade;
            //double altura;
            //bool SouEstudante;

            //// 2º Atribuir valores
            //nome = "Tiago Castro";
            //idade = 45;
            //altura = 1.70; 
            //SouEstudante = false;

            //// 3º Mostrar na consola na linguagem C# utilizamos o " Console.WriteLine( " para escrever algo na consola
            //Console.WriteLine("NOME: " + nome);
            //Console.WriteLine("IDADE: " + idade);
            //Console.WriteLine("Altura: " + altura);
            //Console.WriteLine("Verificar se é estudante: " + SouEstudante);

            ////////////////////////////////////////////////// 
            // 2 - Troque os valores de duas variáveis inteiras a e b (sem usar uma terceira variável auxiliar).

            // 1º Declarar variaveis
            //int a, b;

            //// 2º Atribuir valores
            //a = 23;
            //b = 50;
            //Console.WriteLine("Mostrar valore atribuidos: ");
            //Console.WriteLine("A: " + a);
            //Console.WriteLine("B: " + b);

            //// 3º Trocar valores entre as variaveis
            //a = a + b;    // a agora contém a soma dos dois valores
            //b = a - b;    // b agora contém o valor original de a
            //a = a - b;    // a agora contém o valor original de b

            //// 4º Mostrar na consola
            //Console.WriteLine("Após a troca: ");
            //Console.WriteLine("A: " + a);
            //Console.WriteLine("B: " + b);

            ////////////////////////////////////////////////// 
            // 3 - Leia nome, dia, mês e ano de nascimento e escreva na consola.
            // 1º Declarar variáveis
            //string nome1;
            //int dia, mes, ano;

            //// 2º Atribuir valores
            //nome1 = "Tiago Castro";
            //dia = 28;
            //mes = 3;
            //ano = 2002; 

            //// 3º Mostrar na consola na linguagem C# utilizamos o " Console.WriteLine( " para escrever algo na consola
            //Console.WriteLine("NOME: " + nome1);
            //Console.WriteLine("DIA: " + dia + "\nMÊS: " + mes + "\nANO: " + ano);

            ////////////////////////////////////////////////// 
            // 4 - Fazer um programa para ler o nome e a idade de duas pessoas
            // 1º Declarar variáveis
            //string nome2, nome3;
            //int idade1, idade2;

            //// 2º Ler valores de texto com o Console.ReadLine();
            //Console.WriteLine("Digite o 1º nome: ");
            //nome2 = Console.ReadLine();

            //// Utilizar o int.Parse para converter o valor lido que é string para int
            //Console.WriteLine("Digite a 1ª idade: ");
            //idade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 2º nome: ");
            //nome3 = Console.ReadLine();

            //Console.WriteLine("Digite a 2ª idade: ");
            //idade2 = int.Parse(Console.ReadLine());

            //// 3º Mostrar na consola na linguagem C# utilizamos o " Console.WriteLine( " para escrever algo na consola
            //Console.WriteLine("NOME 1º PESSOA : " + nome2 + "\nIDADE 1º PESSOA: " + idade1);
            //Console.WriteLine("NOME 2º PESSOA : " + nome3 + "\nIDADE 2º PESSOA: " + idade2);

            ////////////////////////////////////////////////// 
            // 5 - Fazer um programa para ler nome e salário de dois funcionários;
            //1º Declarar variáveis
            //string nome4, nome5;
            //double salario, salario1;

            //// 2º Ler valores com o Console.ReadLine();
            //Console.WriteLine("Digite o 1º nome: ");
            //nome4 = Console.ReadLine();

            //// Utilizar o double.Parse para converter o valor lido que é string para double
            //Console.WriteLine("Digite o 1º salario: ");
            //salario = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 2º nome: ");
            //nome5 = Console.ReadLine();

            //Console.WriteLine("Digite a 2º salário: ");
            //salario1 = double.Parse(Console.ReadLine());

            ////// 3º Mostrar na consola na linguagem C# utilizamos o " Console.WriteLine( " para escrever algo na consola
            //Console.WriteLine("NOME 1º PESSOA : " + nome4 + "\nSALÁRIO 1º PESSOA: " + salario);
            //Console.WriteLine("NOME 2º PESSOA : " + nome5 + "\nSALÁRIO 2º PESSOA: " + salario1);

            ////////////////////////////////////////////////// 
            // 6 - Fazer um programa para ler o código de uma peça, a sua quantidade e o preço da peça;
            // 1º Declarar variáveis
            //int codigo, qtd;
            //double preco;

            //// 2º Ler valores com o Console.ReadLine();
            //// Utilizar o int.Parse para converter o valor lido que é string para int
            //Console.WriteLine("Digite o código: ");
            //codigo = int.Parse(Console.ReadLine());

            //// Utilizar o int.Parse para converter o valor lido que é string para int
            //Console.WriteLine("Digite a quantidade: ");
            //qtd = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o preço: ");
            //preco = double.Parse(Console.ReadLine());

            //// 3º Mostrar na consola na linguagem C# utilizamos o " Console.WriteLine( " para escrever algo na consola
            //Console.WriteLine("CÓDIGO: " + codigo + "\nQUANTIDADE: " + qtd + "\nPREÇO: " + preco);

            ////////////////////////////////////////////////// 
            // 7 - Crie um exemplo de comentários com uma linha e outro com várias linhas.

            // Comentário com uma linha

            /* Comentário com
             * várias linhas
             * ...
             * ...
             * ...
             */

            ////////////////////////////////////////////////// 
            // 8 - Escreva um programa que peça e escreva o nome, email e idade do utilizador no ecrã.

            // 1º Declarar variáveis
            //string nome6, email;
            //int idade3;

            //// 2º Ler valores com o Console.ReadLine();
            //Console.WriteLine("Digite o nome: ");
            //nome6 = Console.ReadLine();

            //Console.WriteLine("Digite o email: ");
            //email = Console.ReadLine();

            //// Utilizar o int.Parse para converter o valor lido que é string para int
            //Console.WriteLine("Digite a idade: ");
            //idade3 = int.Parse(Console.ReadLine());

            //// 3º Mostrar na consola na linguagem C# utilizamos o " Console.WriteLine( " para escrever algo na consola
            //Console.WriteLine("NOME: " + nome6 + "\nEMAIL: " + email + "\nIDADE: " + idade3);

            ////////////////////////////////////////////////// 
            // 9 - Crie o exemplo de uma fatura de um supermercado na consola

            // 1º Declarar variáveis
            //string produto1, produto2, produto3;
            //double preco1, preco2, preco3, total;

            //// 2º Atribuir valores
            //produto1 = "Ceriais";
            //preco1 = 1.50;
            //produto2 = "Pão";
            //preco2 = 0.80;
            //produto3 = "Queijo";
            //preco3 = 2.30;

            //total = preco1 + preco2 + preco3;

            //// 3º Mostrar na consola na linguagem C# utilizamos o " Console.WriteLine( " para escrever algo na consola
            //Console.WriteLine("********** Fatura Supermercado **********");
            //Console.WriteLine("Produto: " + produto1 + " - Preço: " + preco1 + "€");
            //Console.WriteLine("Produto: " + produto2 + " - Preço: " + preco2 + "€");
            //Console.WriteLine("Produto: " + produto3 + " - Preço: " + preco3 + "€");
            //Console.WriteLine("------------------------------------------");
            //Console.WriteLine("Total a Pagar: " + total + "€");
            //Console.WriteLine("******************************************");

            #endregion

            #region Exercícios com Conversões
            ////////////////////////////////////////////////// 
            // 1 - Converta a variável “string valor = “123” para número do tipo de dados inteiro.
            //1º Declarar variável
            //string valor;
            //int valorConvertido;

            //// 2º Atribuir valor
            //valor = "123";

            //// 3º Provar que o valor é texto
            //Console.WriteLine("Valor original tipo de dados texto: " + (valor + 2));

            //// 4º Converter o valor de string para int
            //valorConvertido = int.Parse(valor);

            //// 5º Provar que o valor é número
            //Console.WriteLine("Valor convertido tipo de dados inteiro: " + (valorConvertido + 2));

            ////////////////////////////////////////////////// 
            // 2 - Converta a variável “int idade = 20” para o tipo de dados string(texto).
            // 1º Declarar variável
            //int idade4;
            //string idadeConvertida;

            //// 2º Atribuir valor
            //idade4 = 20;

            //// 3º Provar que o valor é número
            //Console.WriteLine("Valor original tipo de dados inteiro: " + (idade4 + 2));

            //// 4º Converter o valor de int para string
            //idadeConvertida = idade4.ToString();

            //// 5º Provar que o valor é texto
            //Console.WriteLine("Valor convertido tipo de dados texto: " + (idadeConvertida + 2));

            //////////////////////////////////////////////////
            // 3 - Converta a variável “double comprimento = 1,70” para o tipo de dados inteiro.
            // 1º Declarar variável
            //double comprimento;
            //int comprimentoConvertido;

            //// 2º Atribuir valor
            //comprimento = 1.70;

            //// 3º Provar que o valor é número
            //Console.WriteLine("Valor original tipo de dados fracionarios: " + (comprimento + 2.5));

            //// 4º Converter o valor de double para int
            //comprimentoConvertido = (int) comprimento;

            //// 5º Provar que o valor é inteiro
            //Console.WriteLine("Valor convertido tipo de dados texto: " + comprimentoConvertido);

            //////////////////////////////////////////////////
            // 4 - Converta a variável “double preco = 55,5” para o tipo de dados string (texto).
            //double preco;
            //string precoConvertido;

            //// 2º Atribuir valor
            //preco = 55.5;

            //// 3º Provar que o valor é número
            //Console.WriteLine("Valor original tipo de dados fracionarios: " + (preco + 2.5));

            //// 4º Converter o valor de double para int
            //precoConvertido = preco.ToString();

            //// 5º Provar que o valor é inteiro
            //Console.WriteLine("Valor convertido tipo de dados texto: " + precoConvertido);

            #endregion

            #region Exercícios com Operadores
            //////////////////////////////////////////////////
            // 1 - Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar a média do salário dos funcionários.
            // 1º Declarar variaveis
            //string nome7, nome8;
            //double salario2, salario3, media;

            //// 2º Ler e atribuir valor as variaveis
            //Console.WriteLine("Digite o 1º nome: ");
            //nome7 = Console.ReadLine();

            //Console.WriteLine("Digite o 1º salário: "); 
            //salario2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 2º nome: ");
            //nome8 = Console.ReadLine();

            //Console.WriteLine("Digite o 2º salário: ");
            //salario3 = double.Parse(Console.ReadLine());

            //// 3º Aplicar formula de calculo de uma media
            //media = (salario2 + salario3) / 2;

            //// 4º Mostrar o valor da média
            //Console.WriteLine("Média do dois salários: " + media + "€");

            //////////////////////////////////////////////////
            // 2 - Faça um programa que calcule a área do triangulo? Formula: área = (base x altura) / 2
            // 1º Declarar variaveis
            //double baseTriangulo, alturaTriangulo, area;

            //// 2º Ler e atribuir valor as variaveis
            //Console.WriteLine("Digite o valor da base do triangulo: ");
            //baseTriangulo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor da altura do triangulo: ");
            //alturaTriangulo = double.Parse(Console.ReadLine());

            //// 3º Aplicar formula de calculo da área do triangulo
            //area = (baseTriangulo * alturaTriangulo) / 2;

            //// 4º Mostrar o valor da área do triangulo
            //Console.WriteLine("Área do triangulo: " + area);

            //////////////////////////////////////////////////
            // 3 - Declare uma constante para PI(3.14159) e calcule a área de um círculo de raio 5.0.Mostre o resultado.
            // 1º Declarar variaveis
            //const double PI = 3.14159;
            //double raio, areaCirculo;

            //// 2º Ler e atribuir valor as variaveis
            //Console.WriteLine("Digite o valor do raio do circulo: ");
            //raio = double.Parse(Console.ReadLine());

            //// 3º Aplicar formula de calculo da área do circulo
            //areaCirculo = PI * raio * raio; // ou areaCirculo = PI * Math.Pow(raio, 2); Math.Pow é uma função da biblioteca Math que eleva um número a uma potência

            //// 4º Mostrar o valor da área do circulo
            //Console.WriteLine("Área do circulo: " + areaCirculo);

            //////////////////////////////////////////////////
            // 4 - Crie uma calculadora que receba dois números e realize as 4 operações básicas.
            // 1º Declarar variaveis
            //double num1, num2, soma, subtracao, multiplicacao, divisao;

            //// 2º Ler e atribuir valor as variaveis
            //Console.WriteLine("Digite o 1º número: ");
            //num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 2º número: ");
            //num2 = double.Parse(Console.ReadLine());

            //// 3º Aplicar as 4 operações básicas
            //soma = num1 + num2;

            //subtracao = num1 - num2;

            //multiplicacao = num1 * num2;

            //divisao = num1 / num2;

            //// 4º Mostrar o valor das operações
            //Console.WriteLine("Soma: " + soma);
            //Console.WriteLine("Subtração: " + subtracao);
            //Console.WriteLine("Multiplicação: " + multiplicacao);
            //Console.WriteLine("Divisão: " + divisao);

            //////////////////////////////////////////////////
            // 5 - Crie um programa que leia 3 notas de um aluno e calcule a média aritmética.
            // 1º Declarar variaveis
            //double nota1, nota2, nota3, mediaAluno;

            //// 2º Ler e atribuir valor as variaveis
            //Console.WriteLine("Digite a 1ª nota: ");
            //nota1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a 2ª nota: ");
            //nota2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a 3ª nota: ");
            //nota3 = double.Parse(Console.ReadLine());

            //// 3º Aplicar formula de calculo da média aritmética
            //mediaAluno = (nota1 + nota2 + nota3) / 3;

            //// 4º Mostrar o valor da média aritmética
            //Console.WriteLine("Média Aritmética do Aluno: " + mediaAluno);

            //////////////////////////////////////////////////
            // 6 - Faça um programa que converta temperatura de Celsius para Fahrenheit.
            // 1º Declarar variaveis
            //double celsius, fahrenheit;

            //// 2º Ler e atribuir valor as variaveis
            //Console.WriteLine("Digite a temperatura em Celsius: ");
            //celsius = double.Parse(Console.ReadLine());

            //// 3º Aplicar formula de conversão de Celsius para Fahrenheit
            //fahrenheit = (celsius * 9 / 5) + 32;

            //// 4º Mostrar o valor da temperatura em Fahrenheit
            //Console.WriteLine("Temperatura em Fahrenheit: " + fahrenheit);


            #endregion






            Console.ReadLine();
        
        }
    }
}
