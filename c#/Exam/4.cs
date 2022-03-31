using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n1, n2, n3, n4, n5, n6, n7, n8, nueve, n10;
	int p=0, imp=0;
	Console.WriteLine ("Ingresa los números a saber si son pares");
	Console.WriteLine("Ingresa el 1ro");
	n1 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 2do");
	n2 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 3ro");
	n3 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 4to");
	n4 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 5to");
	n5 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 6to");
	n6 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 7mo");
	n7 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 8vo");
	n8 = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 9no");
	nueve = int.Parse(Console.ReadLine());
	Console.WriteLine("Ingresa el 10mo");
	n10 = int.Parse(Console.ReadLine());

	if((n1 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 1ro Es par");
	      p=p+1;
            }
	else{
	      Console.WriteLine("El 1ro no Es par");
	      imp=imp+1;

	}
	if((n2 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 2do Es par");
	      p=p+1;
            }
	else{
	      Console.WriteLine("El 2do no Es par");
	      imp=imp+1;
	}
	if((n3 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 3ro Es par");
	      p=p+1;
            }	
	else{
	      imp=imp+1;
	      Console.WriteLine("El 3ro no Es par");
	}
	if((n4 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 4to Es par");
	      p=p+1;
            }	
	else{
	      imp=imp+1;
	      Console.WriteLine("El 4to no Es par");
	}
	if((n5 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 5to Es par");
	      p=p+1;
            }
	else{
	      Console.WriteLine("El 5to no Es par");
	      imp=imp+1;
	}
	if((n6 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 6to Es par");
	      p=p+1;
            }
	else{
	      Console.WriteLine("El 6to no Es par");
	      imp=imp+1;
	}
	if((n7 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 7mo Es par");
	      p=p+1;
            }
	else{
	      Console.WriteLine("El 7mo no Es par");
	      imp=imp+1;
	}
	if((n8 % 2) == 0)
            {
                //Es un número par
	      Console.WriteLine("El 8vo Es par");
	      p=p+1;
            }
	else{
	      Console.WriteLine("El 8vo no Es par");
	      imp=imp+1;
	}

	if((nueve% 2) == 0)
            {
                //Es un número par
	      p=p+1;
	      Console.WriteLine("El 9no Es par");
            }
	else{
	      Console.WriteLine("El 9no no Es par");
	      imp=imp+1;
	}
	if((n10 % 2) == 0)
            {
                //Es un número par
	      p=p+1;
	      Console.WriteLine("El 10mo Es par");
            }	
	else{
	      Console.WriteLine("El 10mo no Es par");
	      imp=imp+1;
	}

	Console.WriteLine("Existe la siguiente cantidad de pares");
	Console.WriteLine(p);
	Console.WriteLine("Existe la siguiente cantidad de impares");
	Console.WriteLine(imp);
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
