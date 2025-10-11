using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2___Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercícios de Algoritmos


            // 1 - Identifique as variáveis da equação do 2º grau na forma ax² +bx - c = 0:

            // Solução: a, b, c, x

            // 2 - Quais os argumentos de entrada e de saída para se calcular as raízes reais da equação?

            // Solução: ENTRADA - a, b, c | SAIDA - x

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

            // 4 - Faça um algoritmo que converta uma temperatura fornecida em graus.
            // Fahrenheit para Centígrados. Sugestão: utilize a fórmula C = 5 / 9(F - 32).

            // Solução:
            // 1º Identificar variaveis C e F
            // 2º Atribuir valor a variável F. F = 55
            // 3º Aplicar formula para obter o valor da variavel C. C = 5 / 9 * ( 55 - 32 )
            // 4º A variável C = 23º 

            #endregion
        }
    }
}
