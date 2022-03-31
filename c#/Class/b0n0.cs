using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int mnt;
      Console.WriteLine ("Ingresa tus unidades generadas en la semana:");
      mnt = int.Parse(Console.ReadLine());

      switch (mnt)
      {
	case int n when (n <= 1000):
	  Console.WriteLine("No obtienes nada");
	  break;
      	case int n when( n <= 1000 | n <= 5000):
	  Console.WriteLine("obtienes 3000");
	  break;
	case int n when (n <= 5000 | n <= 20000):
	  Console.WriteLine("obtienes 5000");
	  break;
	case int n when (n > 20000):
	  Console.WriteLine("obtienes 8000");
	  break;
      }
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
