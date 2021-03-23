using System;
using System.Globalization;

namespace EtecDSAlcoolOuGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * O etanol rende 70% em relação a gasolina, ou seja, seum carro faz 100 km com
            * gasolina fará 70 km com etanol. Portanto o preço do etanol não pode ultrapassar
            * 70% do preço da gasolina para ser viável financeiramente.
            * 
            * porcentagem_rendimento_etanol = (preco_etanol * 100) / preco_gasolina;
            * 
            */
            double preco_etanol, preco_gasolina;

            Console.WriteLine("Digite o preço do Etanol: ");
            preco_etanol = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o preço do Gasolina ");
            preco_gasolina = Convert.ToDouble(Console.ReadLine());


            Console.Clear();
            Console.Beep();


            double porcentagem_rendimento_etanol = (preco_etanol * 100) / preco_gasolina;

            
            Console.WriteLine(
                "A porcentagem do preço do etanol é {0}%",
                porcentagem_rendimento_etanol.ToString("0.00")
            );

            Console.ForegroundColor = ConsoleColor.Yellow;

            //              89
            if (porcentagem_rendimento_etanol <= 70)
            {
                Console.BackgroundColor = ConsoleColor.Green;                
                Console.WriteLine("Compensa o Etanol");

            } else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Compensa a Gasolina");
            }


            Console.ReadKey();
        }
    }
}
