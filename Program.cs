using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S para segundo => 10s = 10 segundos");
            Console.WriteLine("M para minuto = 1m = 1 minuto");
            Console.WriteLine("Pressione 0 para sair");
            Console.WriteLine("Selecione o tempo para contagem: ");
            
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplier = 1;

            if (time == 'm')
            
                multiplier =60;

             if (time == 0)
                    System.Environment.Exit(0);

              preStart(time * multiplier);   
            

        }

        static void preStart(int time)
        {
            Console.Clear();
            Console.WriteLine ("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2500);
            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Contagem finalizada!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}