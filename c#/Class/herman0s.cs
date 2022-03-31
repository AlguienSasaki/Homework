using System;

public class ComparativaDeNumeros 
{
    public static void Main(string[] args)
    {
       int a, b, r; 
       Console.WriteLine ("Ingresa edad del hermano 1: ");
       a = int.Parse(Console.ReadLine());
       Console.WriteLine ("Ingresa edad del hermano 2: ");
       b = int.Parse(Console.ReadLine());
       if (a >= b)
       {
          r = a - b;
          Console.WriteLine ("El hermano 1 es el mayor y el gana al otro con los siguientes años ");
          Console.WriteLine (r);
       }
       else
       {
          r = b - a;
          Console.WriteLine ("El hermano 2 es el mayor y el gana al otro con los siguientes años ");
          Console.WriteLine (r);
       }  
      
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
