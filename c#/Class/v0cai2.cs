using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      string num;
      Console.WriteLine ("Ingresa una voca");
      num = (Console.ReadLine());

      switch (num)
      {
	case a :
	  Console.WriteLine("a = 1");
	  break;
	case e:
	  Console.WriteLine("e = 2");
	  break;
	case i:
	  Console.WriteLine("i = 3");
	  break;
	case o:
	  Console.WriteLine("o = 4");
	  break;
	case u:
	  Console.WriteLine("u = 5");
	  break;
      }

    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
