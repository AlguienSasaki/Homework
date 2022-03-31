using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int n;
      Console.WriteLine ("Ingresa la cantidad de multiplos del numero 5: ");
      n = int.Parse(Console.ReadLine());
      for (int i = 5; i<= n; i ++){
      Console.WriteLine (n + "x" + i + "=" + i * n);
      }
      Console.ReadKey();
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
