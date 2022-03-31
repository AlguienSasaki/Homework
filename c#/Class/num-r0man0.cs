using System;

public class SwitchCase 
{
    public static void Main(string[] args)
    {
      int num;
      Console.WriteLine ("Escribe un numero entero del 1 - 10 para ser convertido a romano: ");
      num = int.Parse(Console.ReadLine());


      switch (num) 
      {
	case 1 :
	  Console.WriteLine("I");
	  break;
	case 2:
	  Console.WriteLine("II");
	  break;
	case 3:
	  Console.WriteLine("III");
	  break;
	case 4:
	  Console.WriteLine("IV");
	  break;
	case 5:
	  Console.WriteLine("V");
	  break;
	case 6:
	  Console.WriteLine("VI");
	  break;
	case 7:
	  Console.WriteLine("VII");
	  break;
	case 8:
	  Console.WriteLine("VIII");
	  break;
	case 9:
	  Console.WriteLine("IX");
	  break;
	case 10:
	  Console.WriteLine("X");
	  break;  
      }
// Outputs "Thursday" (day 4)
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
