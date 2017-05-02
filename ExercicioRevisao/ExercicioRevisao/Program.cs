using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string mod;
            double quil, pot;


            Console.WriteLine("informe o modelo do carro");
            mod = Console.ReadLine();
            Console.WriteLine("informe a quilometragem rodada");
            quil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe a potencia do carro");
            pot = Convert.ToDouble(Console.ReadLine());

            if (quil <= 5000)
            {
                Console.WriteLine("o carro é novo");
            }
            else if (quil > 5000 && quil <= 30000)
            {
                Console.WriteLine("o carro é seminovo");
            }
            else if (quil > 30000)
            {
                Console.WriteLine("o carro é velho");
            }
                if (pot > 200)
                {
                    Console.WriteLine("o carro é potente");
                }
                else if (pot >= 120 && pot <=200)
                {
                    Console.WriteLine("o carro é forte");
                }
                else if (pot <120)
                {
                    Console.WriteLine("o carro é popular");
                }

            Console.WriteLine("o modelo do carro é {0}", mod);
        }
    }
}
