using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld 
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Ingresa el numero para obtner la suma de su factorial: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 0);
            factorial(num);
            Console.ReadKey();
        }
        static void factorial(int n)
        {
            int fact=1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
        }
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
