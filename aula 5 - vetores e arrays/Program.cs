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
            // Ler o número de pessoas
            Console.Write("Digite o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            // Criar um vetor para armazenar as alturas
            double[] alturas = new double[n];

            // Ler as alturas das N pessoas
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a altura da pessoa {i + 1} (em metros): ");
                alturas[i] = double.Parse(Console.ReadLine());
            }

            // Calcular a altura média
            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += alturas[i];
            }
            double media = soma / n;

            // Exibir o resultado
            Console.WriteLine($"\nAltura média das {n} pessoas: {media:F2} metros");
            Console.WriteLine("\n=====================================================\n");

            // ==================== EXERCÍCIO 2 ====================
            // Ler M (linhas) e N (colunas)
            Console.Write("Digite o número de linhas (M): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas (N): ");
            int ncol = int.Parse(Console.ReadLine());

            // Criar a matriz
            int[,] matriz = new int[m, ncol];

            // Ler os elementos da matriz
            Console.WriteLine("\nDigite os elementos da matriz:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Exibir a matriz
            Console.WriteLine("\nMatriz lida:");
            ExibirMatriz(matriz, m, ncol);

            // Ler o número X a procurar
            Console.Write("\nDigite o número X para procurar: ");
            int x = int.Parse(Console.ReadLine());

            // Procurar X na matriz e exibir vizinhos
            bool encontrou = false;
            Console.WriteLine($"\nOcorrências de {x}:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        encontrou = true;
                        Console.WriteLine($"\nPosição [{i},{j}]:");

                        // Esquerda
                        if (j > 0)
                            Console.WriteLine($"  Esquerda: {matriz[i, j - 1]}");

                        // Cima
                        if (i > 0)
                            Console.WriteLine($"  Cima: {matriz[i - 1, j]}");

                        // Direita
                        if (j < ncol - 1)
                            Console.WriteLine($"  Direita: {matriz[i, j + 1]}");

                        // Baixo
                        if (i < m - 1)
                            Console.WriteLine($"  Baixo: {matriz[i + 1, j]}");
                    }
                }
            }

            if (!encontrou)
                Console.WriteLine($"O número {x} não foi encontrado na matriz.");

            Console.WriteLine("\n=====================================================\n");

            // ==================== EXERCÍCIO 3 ====================
            // Demonstração de diferentes tipos de coleções dinâmicas

            // 1. List<T> - Lista genérica (mais comum e recomendada)
            Console.WriteLine("1. LIST<T> - Lista Genérica");
            List<string> list = new List<string> { "Ana", "Bruno", "Carlos", "Diana", "Elisa" };
            Console.WriteLine("   Elementos: " + string.Join(", ", list));
            Console.WriteLine("   Primeiro: " + list[0] + ", Último: " + list[list.Count - 1]);
            list.Add("Fernando");
            Console.WriteLine("   Após adicionar Fernando: " + string.Join(", ", list));
            Console.WriteLine();

            // 2. ArrayList - Lista não genérica (versão antiga)
            Console.WriteLine("2. ARRAYLIST - Lista Não Genérica");
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList { "Ana", "Bruno", "Carlos", "Diana", "Elisa" };
            Console.WriteLine("   Elementos: " + string.Join(", ", arrayList.Cast<string>().ToList()));
            arrayList.Add("Fernando");
            arrayList.Remove("Bruno");
            Console.WriteLine("   Após adicionar Fernando e remover Bruno: " + string.Join(", ", arrayList.Cast<string>().ToList()));
            Console.WriteLine();

            // 3. SortedList - Lista ordenada por chave
            Console.WriteLine("3. SORTEDLIST - Lista Ordenada por Chave");
            SortedList<int, string> sortedList = new SortedList<int, string>
            {
                { 3, "Carlos" },
                { 1, "Ana" },
                { 5, "Elisa" },
                { 2, "Bruno" },
                { 4, "Diana" }
            };
            Console.WriteLine("   Elementos (ordenados por chave): " + string.Join(", ", sortedList.Values));
            sortedList.Add(6, "Fernando");
            Console.WriteLine("   Após adicionar Fernando: " + string.Join(", ", sortedList.Values));
            Console.WriteLine();

            // 4. Stack - Pilha (LIFO - Last In First Out)
            Console.WriteLine("4. STACK - Pilha (LIFO)");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ana");
            stack.Push("Bruno");
            stack.Push("Carlos");
            stack.Push("Diana");
            stack.Push("Elisa");
            Console.WriteLine("   Elementos adicionados: Ana, Bruno, Carlos, Diana, Elisa");
            Console.WriteLine("   Remover (Pop): " + stack.Pop() + " (Elisa saiu primeiro)");
            Console.WriteLine("   Próximo a remover: " + stack.Peek());
            Console.WriteLine();

            // 5. Queue - Fila (FIFO - First In First Out)
            Console.WriteLine("5. QUEUE - Fila (FIFO)");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ana");
            queue.Enqueue("Bruno");
            queue.Enqueue("Carlos");
            queue.Enqueue("Diana");
            queue.Enqueue("Elisa");
            Console.WriteLine("   Elementos adicionados: Ana, Bruno, Carlos, Diana, Elisa");
            Console.WriteLine("   Remover (Dequeue): " + queue.Dequeue() + " (Ana saiu primeiro)");
            Console.WriteLine("   Próximo a remover: " + queue.Peek());
            Console.WriteLine();

            // 6. HashTable - Tabela de hash (não genérica)
            Console.WriteLine("6. HASHTABLE - Tabela de Hash (Chave-Valor)");
            System.Collections.Hashtable hashTable = new System.Collections.Hashtable
            {
                { "P1", "Ana" },
                { "P2", "Bruno" },
                { "P3", "Carlos" },
                { "P4", "Diana" },
                { "P5", "Elisa" }
            };
            Console.WriteLine("   Elementos (pares Chave-Valor):");
            foreach (string key in hashTable.Keys)
            {
                Console.WriteLine($"     {key}: {hashTable[key]}");
            }
            Console.WriteLine();

            // 7. Dictionary - Dicionário genérico (versão moderna do HashTable)
            Console.WriteLine("7. DICTIONARY - Dicionário Genérico (Chave-Valor)");
            Dictionary<string, string> dictionary = new Dictionary<string, string>
            {
                { "ID001", "Ana" },
                { "ID002", "Bruno" },
                { "ID003", "Carlos" },
                { "ID004", "Diana" },
                { "ID005", "Elisa" }
            };
            Console.WriteLine("   Elementos (pares Chave-Valor):");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"     {kvp.Key}: {kvp.Value}");
            }
            dictionary.Add("ID006", "Fernando");
            Console.WriteLine("   Após adicionar ID006: Fernando");
            Console.WriteLine($"   Buscar ID003: {dictionary["ID003"]}");
            Console.WriteLine();

            // Resumo comparativo
            Console.WriteLine("=====================================================");
            Console.WriteLine("RESUMO COMPARATIVO:");
            Console.WriteLine("- LIST: Genérica, rápida, acesso por índice");
            Console.WriteLine("- ARRAYLIST: Não genérica, versão antiga da List");
            Console.WriteLine("- SORTEDLIST: Mantém elementos ordenados por chave");
            Console.WriteLine("- STACK: LIFO (último entra, primeiro sai)");
            Console.WriteLine("- QUEUE: FIFO (primeiro entra, primeiro sai)");
            Console.WriteLine("- HASHTABLE: Chave-Valor, não genérica");
            Console.WriteLine("- DICTIONARY: Chave-Valor, genérica (recomendada)");

            Console.ReadLine();
        }

        static void ExibirMatriz(int[,] matriz, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
