using System;

public class ComparativaDeNumeros 
{
    public static void Main(string[] args)
    {
       int a, b, r; 
       Console.WriteLine ("Escribe el primer número: ");
       a = int.Parse(Console.ReadLine());
       Console.WriteLine ("Escribe el primer número: ");
       b = int.Parse(Console.ReadLine());
       if (a >= b)
       {
          r = a / b;
          Console.WriteLine ("El resultado de dividir el número más grande es ");
          Console.WriteLine (r);
       }
       else
       {
          r = b / a;
          Console.WriteLine ("El resultado de dividir el número más grande es ");
          Console.WriteLine (r);
       }  
      
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
