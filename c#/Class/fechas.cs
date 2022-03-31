using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int a;

      Console.WriteLine ("Ingresa un número para obtener la duración de cada estación: ");
      Console.WriteLine ("1 para primavera ");
      Console.WriteLine ("2 para verano ");
      Console.WriteLine ("3 para otoño ");
      Console.WriteLine ("4 para invierno");
      a = int.Parse(Console.ReadLine());
      
      switch (a)
      {
	case 1:
	  Console.WriteLine("La primavera inicia el 21 de Marzo y dura 92, 9 días");
	  break;
      	case 2:
	  Console.WriteLine("La verano inicia el 21 Junio y dura 93, 7 días");
	  break;
	case 3:
	  Console.WriteLine("La otoño inicia el 23 Septiembre y dura 89, 6 días");
	  break;
	case 4:
	  Console.WriteLine("La invierno inicia el 21 Diciembre y dura 89,0 día");
	  break;
      }
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
