using System;
using Static.classes;
namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            do
            {
                Console.WriteLine($"Escolha um valor para converter");
                Console.WriteLine($"1 - Dolar para Real");
                Console.WriteLine($"2 - Real para Dolar");
                resposta = int.Parse(Console.ReadLine());
                
                switch (resposta)
                {
                    case 1:
                    Console.WriteLine(Conversor.DolarParaReal(4f));

                        break;
                    case 2:
                    Console.WriteLine(Conversor.RealParaDolar(50f));
                        break;
                }
                
            } while (resposta != 0);
            
            
        }
    }
}
