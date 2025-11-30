using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_4___Metodos_e_correcao_ficha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo for the requested methods
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Exercícios: Métodos (Calculadora, Média, Mais velha, Menor preço) ===\n");

            // Calculator demo
            double a = 12.5, b = 3;
            Console.WriteLine($"Somar({a}, {b}) = {Somar(a, b)}");
            Console.WriteLine($"Subtrair({a}, {b}) = {Subtrair(a, b)}");
            Console.WriteLine($"Multiplicar({a}, {b}) = {Multiplicar(a, b)}");
            Console.WriteLine($"Dividir({a}, {b}) = {Dividir(a, b)}\n");

            // Média UC demo
            double[] notas = { 14.0, 16.5, 12.0 };
            Console.WriteLine($"Notas: {string.Join(", ", notas)} -> Média UC = {MediaUC(notas):F2}\n");

            // Mais velha demo
            int id1 = 18, id2 = 22, id3 = 20;
            Console.WriteLine($"Idades: {id1}, {id2}, {id3} -> Mais velha = {MaisVelha(id1, id2, id3)}\n");

            // Menor preço demo
            double p1 = 3.49, p2 = 2.99, p3 = 4.20;
            Console.WriteLine($"Preços: {p1:C}, {p2:C}, {p3:C} -> Menor preço = {MenorPreco(p1, p2, p3):C}\n");

            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }

        // Calculadora: métodos básicos
        static double Somar(double x, double y)
        {
            double resultado = x + y;
            return resultado;
        }

        static double Subtrair(double x, double y)
        {
            double resultado = x - y;
            return resultado;
        }

        static double Multiplicar(double x, double y)
        {
            double resultado = x * y;
            return resultado;
        }

        static double Dividir(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Aviso: divisão por 0. Retornando Double.NaN");
                return double.NaN;
            }
            double resultado = x / y;
            return resultado;
        }

        // Método que calcula a média (UC) a partir de um array de notas
        static double MediaUC(params double[] notas)
        {
            if (notas == null || notas.Length == 0) return 0.0;
            return notas.Average();
        }

        // Método que recebe 3 idades e retorna a idade mais velha
        static int MaisVelha(int i1, int i2, int i3)
        {
            return Math.Max(i1, Math.Max(i2, i3));
        }

        // Método que recebe 3 preços e retorna o mais baixo
        static double MenorPreco(double p1, double p2, double p3)
        {
            return Math.Min(p1, Math.Min(p2, p3));
        }
    }
}
