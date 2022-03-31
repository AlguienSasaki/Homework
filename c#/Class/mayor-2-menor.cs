using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarNumerosConCondicionalesAnidadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            Console.Write("Escribe el primer número: ");
            n1=int.Parse(Console.ReadLine());
            Console.Write("Escribe el segundo número: ");
            n2=int.Parse(Console.ReadLine());
            Console.Write("Escribe el tercer número: ");
            n3=int.Parse(Console.ReadLine());
            
	    if ( n1 > n2 & n1 > n3 ) 
            {
                Console.Write("El primer número es el más grande");    
            } 
            else 
            {
              if ( n2 > n1 & n2 > n3 ) 
                {
                    Console.Write("El segundo número es el más grande");
                }
              else 
	      {
		if ( n3 > n2 & n3 > n1 )
		{
		  Console.Write("El tercer número es el más grande");
		}
		else
		{
		  Console.Write("Escribiste el mismo número XDXDXD");
		}
            Console.ReadKey();
              }

            }

        }

    }

}
