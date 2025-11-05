using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_3___ciclos_repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Estrutura For

            //Leia n valores representativos do pH e mostre, para cada valor, que tipo de
            //solução representa: ácida(pH < 7), neutra(pH = 7) ou alcalina(pH> 7) (for).

            Console.WriteLine("********** VERIFICADOR DE PHs **********");

            //Variaveis
            double ph;
            int qtdPHsALer;

            //Por norma quando é para utilizar uma estrutura FOR
            //temos de questinar a quantidade
            //de ciclos a verificar
            Console.WriteLine("Quantidade de phs a verificar: ");
            qtdPHsALer = int.Parse(Console.ReadLine());

            // i < qtdPHsALer | 0 < 3
            // i++ | i = i + 1 | i = 0
            // 0 = 0 + 1
            // i = 1
            // i++ | i = i + 1 | i = 1
            // 1 = 1 + 1
            // i = 2
            // ...
            // i++ -> INCREMENTADOR
            // i < qtdPHsALer | 0 < 3
            for (int i = 0; i < qtdPHsALer; i++)
            {
                //Pedir o valor de ph ao utilizador
                Console.WriteLine("Digite o " + (i +1) + " valor de PH: ");
                ph = double.Parse(Console.ReadLine());

                if( ph > 7)
                {
                    Console.WriteLine("O valor de ph " + ph + " é uma solução alcalina.");
                }
                else if( ph == 7)
                {
                    Console.WriteLine("O valor de ph " + ph + " é uma solução neutra.");
                }
                else
                {
                    Console.WriteLine("O valor de ph " + ph + " é uma solução ácida.");
                }
            }

            Console.WriteLine("********** FIM DO PROGRAMA **********");

            Console.ReadKey();
            #endregion



        }
    }
}
