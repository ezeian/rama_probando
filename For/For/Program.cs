using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            sumando();

        }
        static void sumando()
        {
            Console.WriteLine("Ingrese un numero");
            string n = Console.ReadLine();
            int nn = int.Parse(n);
            Console.WriteLine("\n");
            int suma = 0;
            for (int x = nn; x >= 0; x--)
            {
                suma = x + suma;
            }
            Console.WriteLine(suma);
        }
        static void numeros()
        {
            for (int x = 0; x <= 100; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            for (int x = 0; x <= 100; x++)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.WriteLine("\n");
        }
    }
}

