using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int n;
      Console.WriteLine ("Ingresa el numero: ");
      n = int.Parse(Console.ReadLine());
      for (int i = 1; i<= 10; i ++){
      Console.WriteLine (n + "x" + i + "=" + i * n);
      }
      Console.ReadKey();
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
