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
            int qtd, pot;
            string nome;
            double quilm;
            Console.WriteLine("informe a quantidade de carros");
            qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.writeline("informe o modelo do carro");
                nome = Console.ReadLine();
                Console.WriteLine("informe a quiometragem do veiculo");
                quilm = double.Parse(Console.ReadLine());
                Console.WriteLine("informe a potencia do veiculo");
                pot = int.Parse(Console.ReadLine());

                Console.WriteLine(Classificar(nome, quilometragem, potencia));
            }
        }

        public static string Classificar(string mod, double km, int pot)
        {                              
            string classifRodagem, classifPot;

            if (km <= 5000)
                classifRodagem = "Novo";
            else if (km <= 30000)
                classifRodagem = "Seminovo";
            else
                classifRodagem = "Velho";

            if (pot < 120)
                classifPot = "Popular";
            else if (pot <= 200)
                classifPot = "Forte";
            else
                classifPot = "Potente";

            return String.Format("{0} - {1} - {2}", mod, classifRodagem, classifPot);
        }
    }
}
