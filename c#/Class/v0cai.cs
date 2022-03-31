using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int num;
      Console.WriteLine ("Ingresa un número");
      num = int.Parse(Console.ReadLine());

      switch (num)
      {
	case 1 :
	  Console.WriteLine("a = 1");
	  break;
	case 2:
	  Console.WriteLine("e = 2");
	  break;
	case 3:
	  Console.WriteLine("i = 3");
	  break;
	case 4:
	  Console.WriteLine("o = 4");
	  break;
	case 5:
	  Console.WriteLine("u = 5");
	  break;
      }

    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
