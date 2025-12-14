using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_5___vetores_e_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // Ler o número de pessoas
            //    Console.Write("Digite o número de pessoas: ");
            //    int n = int.Parse(Console.ReadLine());

            //    // Criar um vetor para armazenar as alturas
            //    double[] alturas = new double[n];

            //    // Ler as alturas das N pessoas
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Digite a altura da pessoa {i + 1} (em metros): ");
            //        alturas[i] = double.Parse(Console.ReadLine());
            //    }

            //    // Calcular a altura média
            //    double soma = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        soma += alturas[i];
            //    }
            //    double media = soma / n;

            //    // Exibir o resultado
            //    Console.WriteLine($"\nAltura média das {n} pessoas: {media:F2} metros");
            //    Console.WriteLine("\n=====================================================\n");

            //    // ==================== EXERCÍCIO 2 ====================
            //    // Ler M (linhas) e N (colunas)
            //    Console.Write("Digite o número de linhas (M): ");
            //    int m = int.Parse(Console.ReadLine());

            //    Console.Write("Digite o número de colunas (N): ");
            //    int ncol = int.Parse(Console.ReadLine());

            //    // Criar a matriz
            //    int[,] matriz = new int[m, ncol];

            //    // Ler os elementos da matriz
            //    Console.WriteLine("\nDigite os elementos da matriz:");
            //    for (int i = 0; i < m; i++)
            //    {
            //        for (int j = 0; j < ncol; j++)
            //        {
            //            Console.Write($"Elemento [{i},{j}]: ");
            //            matriz[i, j] = int.Parse(Console.ReadLine());
            //        }
            //    }

            //    // Exibir a matriz
            //    Console.WriteLine("\nMatriz lida:");
            //    ExibirMatriz(matriz, m, ncol);

            //    // Ler o número X a procurar
            //    Console.Write("\nDigite o número X para procurar: ");
            //    int x = int.Parse(Console.ReadLine());

            //    // Procurar X na matriz e exibir vizinhos
            //    bool encontrou = false;
            //    Console.WriteLine($"\nOcorrências de {x}:");
            //    for (int i = 0; i < m; i++)
            //    {
            //        for (int j = 0; j < ncol; j++)
            //        {
            //            if (matriz[i, j] == x)
            //            {
            //                encontrou = true;
            //                Console.WriteLine($"\nPosição [{i},{j}]:");

            //                // Esquerda
            //                if (j > 0)
            //                    Console.WriteLine($"  Esquerda: {matriz[i, j - 1]}");

            //                // Cima
            //                if (i > 0)
            //                    Console.WriteLine($"  Cima: {matriz[i - 1, j]}");

            //                // Direita
            //                if (j < ncol - 1)
            //                    Console.WriteLine($"  Direita: {matriz[i, j + 1]}");

            //                // Baixo
            //                if (i < m - 1)
            //                    Console.WriteLine($"  Baixo: {matriz[i + 1, j]}");
            //            }
            //        }
            //    }

            //    if (!encontrou)
            //        Console.WriteLine($"O número {x} não foi encontrado na matriz.");

            //    Console.WriteLine("\n=====================================================\n");

            //    // ==================== EXERCÍCIO 3 ====================
            //    // Demonstração de diferentes tipos de coleções dinâmicas

            //    // 1. List<T> - Lista genérica (mais comum e recomendada)
            //    Console.WriteLine("1. LIST<T> - Lista Genérica");
            //    List<string> list = new List<string> { "Ana", "Bruno", "Carlos", "Diana", "Elisa" };
            //    Console.WriteLine("   Elementos: " + string.Join(", ", list));
            //    Console.WriteLine("   Primeiro: " + list[0] + ", Último: " + list[list.Count - 1]);
            //    list.Add("Fernando");
            //    Console.WriteLine("   Após adicionar Fernando: " + string.Join(", ", list));
            //    Console.WriteLine();

            //    // 2. ArrayList - Lista não genérica (versão antiga)
            //    Console.WriteLine("2. ARRAYLIST - Lista Não Genérica");
            //    System.Collections.ArrayList arrayList = new System.Collections.ArrayList { "Ana", "Bruno", "Carlos", "Diana", "Elisa" };
            //    Console.WriteLine("   Elementos: " + string.Join(", ", arrayList.Cast<string>().ToList()));
            //    arrayList.Add("Fernando");
            //    arrayList.Remove("Bruno");
            //    Console.WriteLine("   Após adicionar Fernando e remover Bruno: " + string.Join(", ", arrayList.Cast<string>().ToList()));
            //    Console.WriteLine();

            //    // 3. SortedList - Lista ordenada por chave
            //    Console.WriteLine("3. SORTEDLIST - Lista Ordenada por Chave");
            //    SortedList<int, string> sortedList = new SortedList<int, string>
            //    {
            //        { 3, "Carlos" },
            //        { 1, "Ana" },
            //        { 5, "Elisa" },
            //        { 2, "Bruno" },
            //        { 4, "Diana" }
            //    };
            //    Console.WriteLine("   Elementos (ordenados por chave): " + string.Join(", ", sortedList.Values));
            //    sortedList.Add(6, "Fernando");
            //    Console.WriteLine("   Após adicionar Fernando: " + string.Join(", ", sortedList.Values));
            //    Console.WriteLine();

            //    // 4. Stack - Pilha (LIFO - Last In First Out)
            //    Console.WriteLine("4. STACK - Pilha (LIFO)");
            //    Stack<string> stack = new Stack<string>();
            //    stack.Push("Ana");
            //    stack.Push("Bruno");
            //    stack.Push("Carlos");
            //    stack.Push("Diana");
            //    stack.Push("Elisa");
            //    Console.WriteLine("   Elementos adicionados: Ana, Bruno, Carlos, Diana, Elisa");
            //    Console.WriteLine("   Remover (Pop): " + stack.Pop() + " (Elisa saiu primeiro)");
            //    Console.WriteLine("   Próximo a remover: " + stack.Peek());
            //    Console.WriteLine();

            //    // 5. Queue - Fila (FIFO - First In First Out)
            //    Console.WriteLine("5. QUEUE - Fila (FIFO)");
            //    Queue<string> queue = new Queue<string>();
            //    queue.Enqueue("Ana");
            //    queue.Enqueue("Bruno");
            //    queue.Enqueue("Carlos");
            //    queue.Enqueue("Diana");
            //    queue.Enqueue("Elisa");
            //    Console.WriteLine("   Elementos adicionados: Ana, Bruno, Carlos, Diana, Elisa");
            //    Console.WriteLine("   Remover (Dequeue): " + queue.Dequeue() + " (Ana saiu primeiro)");
            //    Console.WriteLine("   Próximo a remover: " + queue.Peek());
            //    Console.WriteLine();

            //    // 6. HashTable - Tabela de hash (não genérica)
            //    Console.WriteLine("6. HASHTABLE - Tabela de Hash (Chave-Valor)");
            //    System.Collections.Hashtable hashTable = new System.Collections.Hashtable
            //    {
            //        { "P1", "Ana" },
            //        { "P2", "Bruno" },
            //        { "P3", "Carlos" },
            //        { "P4", "Diana" },
            //        { "P5", "Elisa" }
            //    };
            //    Console.WriteLine("   Elementos (pares Chave-Valor):");
            //    foreach (string key in hashTable.Keys)
            //    {
            //        Console.WriteLine($"     {key}: {hashTable[key]}");
            //    }
            //    Console.WriteLine();

            //    // 7. Dictionary - Dicionário genérico (versão moderna do HashTable)
            //    Console.WriteLine("7. DICTIONARY - Dicionário Genérico (Chave-Valor)");
            //    Dictionary<string, string> dictionary = new Dictionary<string, string>
            //    {
            //        { "ID001", "Ana" },
            //        { "ID002", "Bruno" },
            //        { "ID003", "Carlos" },
            //        { "ID004", "Diana" },
            //        { "ID005", "Elisa" }
            //    };
            //    Console.WriteLine("   Elementos (pares Chave-Valor):");
            //    foreach (var kvp in dictionary)
            //    {
            //        Console.WriteLine($"     {kvp.Key}: {kvp.Value}");
            //    }
            //    dictionary.Add("ID006", "Fernando");
            //    Console.WriteLine("   Após adicionar ID006: Fernando");
            //    Console.WriteLine($"   Buscar ID003: {dictionary["ID003"]}");
            //    Console.WriteLine();

            //    // Resumo comparativo
            //    Console.WriteLine("=====================================================");
            //    Console.WriteLine("RESUMO COMPARATIVO:");
            //    Console.WriteLine("- LIST: Genérica, rápida, acesso por índice");
            //    Console.WriteLine("- ARRAYLIST: Não genérica, versão antiga da List");
            //    Console.WriteLine("- SORTEDLIST: Mantém elementos ordenados por chave");
            //    Console.WriteLine("- STACK: LIFO (último entra, primeiro sai)");
            //    Console.WriteLine("- QUEUE: FIFO (primeiro entra, primeiro sai)");
            //    Console.WriteLine("- HASHTABLE: Chave-Valor, não genérica");
            //    Console.WriteLine("- DICTIONARY: Chave-Valor, genérica (recomendada)");

            //    Console.ReadLine();
            //}

            //static void ExibirMatriz(int[,] matriz, int m, int n)
            //{
            //    for (int i = 0; i < m; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            Console.Write(matriz[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}


            //1 - Criar um programa para ler um número inteiro N e a altura
            //de N pessoas. Armazene as N alturas em um vetor. Em seguida,
            //mostrar a altura média dessas pessoas.

            //double somaAlturas = 0.0, media;
            //double[] vetorDeAlturas;
            //int qtdAlturas;

            //Console.WriteLine("Quatidade de alturas a verificar: ");
            //qtdAlturas = int.Parse(Console.ReadLine());

            ////Colocar um tamanho no vetor
            //vetorDeAlturas = new double[qtdAlturas];

            ////Guardar as alturas digitadas pelo utilizador
            ////no vetor
            //for (int i = 0; i < vetorDeAlturas.Length; i++)
            //{
            //    Console.WriteLine("Digite a " + (i + 1) + " altura: ");
            //    vetorDeAlturas[i] = double.Parse(Console.ReadLine());

            //    //Pode-se utilizar a soma aqui em vez de criar novo for
            //    //somaAlturas = somaAlturas + vetorDeAlturas[i];
            //}

            ////Somar os valores colocados no vetor
            //for (int i = 0; i < vetorDeAlturas.Length; i++)
            //{
            //    somaAlturas = somaAlturas + vetorDeAlturas[i];
            //    // ou
            //    //  somaAlturas += vetorDeAlturas[i];
            //}

            //media = somaAlturas / qtdAlturas;

            //Console.WriteLine("Media de alturas: " + Math.Round(media, 2));


            #region EXERCICIOS COM VETORES

            //1.Considerar o vetor: string[] palavras = {“M”,”-“,”5”};
            //Implementar um procedimento que permita listar os elementos da tabela de carateres.

            //string[] palavras = { "M", "-", "5" };

            //for(int i = 0; i < palavras.Length;i++)
            //{
            //    Console.WriteLine(palavras[i]);
            //}

            /*2.Considerar o vetor: int[10] Inteiros = { 10, 23, 12, -4, 9, -67, 24, 1, 90, 100 };
            Pretende - se que se verifique para cada elemento constituinte da tabela se estes são número par.
            */
            int[] Inteiros = { 10, 23, 12, -4, 9, -67, 24, 1, 90, 100 };

            for (int i = 0; i < Inteiros.Length; i++)
            {
                if (Inteiros[i] % 2 == 0)
                {
                    Console.WriteLine(Inteiros[i] + " é par.");
                }
                //else
                //{
                //    Console.WriteLine(Inteiros[i] + " é ímpar.");
                //}
            }

            /*
            3.Considerar o vetor: double[5] Reais = { 10.4, 23.2, 12.34, -4.67, 9.09 };
            Pretende - se que se verifique para cada elemento constituinte da tabela quais destes são números
            negativos.
            Implementar num procedimento o código que permite responder ao pedido.
            */
            double[] Reais = { 10.4, 23.2, 12.34, -4.67, 9.09 };

            for (int i = 0; i < Reais.Length; i++)
            {
                if (Reais[i] < 0)
                {
                    Console.WriteLine(Reais[i] + " é negativo.");
                }
                //else
                //{
                //    Console.WriteLine(Reais[i] + " é positivo.");
                //}
            }

            /*
             * 4. Pretende-se que se implemente dois procedimentos que permitam ler e listar o
                conteúdo de um vetor de inteiros. Definir o tamanho máximo para 20 numa constante
                com a designação N.
            */

            const int N = 20;
            int[] vetorInteiros = new int[N];

            //Leitura
            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número inteiro: ");
                vetorInteiros[i] = int.Parse(Console.ReadLine());
            }

            //Listagem  
            Console.WriteLine("Números inteiros digitados: ");
            for (int i = 0; i < vetorInteiros.Length; i++)
            {
                Console.WriteLine(vetorInteiros[i]);
            }

            #endregion

        }
    }
}
