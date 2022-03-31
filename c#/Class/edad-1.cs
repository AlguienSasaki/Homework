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
	case int n when (n <= 3):
	  Console.WriteLine("bebe");
	  break;
      	case int n when( n >= 4 & n <= 9):
	  Console.WriteLine("niño");
	  break;
	case int n when (n >= 10 & n <= 12):
	  Console.WriteLine("puberto");
	  break;
	case int n when (n >= 13 & n <= 19 ):
	  Console.WriteLine("adolescente");
	  break;
	case int n when (n >= 20 & n <= 29 ):
	  Console.WriteLine("Joven");
	  break;
	case int n when (n >= 30 & n <= 39 ):
	  Console.WriteLine("Adulto");
	  break;
	case int n when (n >= 40 & n <= 59 ):
	  Console.WriteLine("Adulto Mayor");
	  break;
	case int n when (n > 60):
	  Console.WriteLine("Viejo");
	  break;

      }
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
