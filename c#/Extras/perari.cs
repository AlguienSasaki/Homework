using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int cantidad;
      Console.WriteLine ("Ingresa tus unidades generadas en la semana:");
      cantidad = int.Parse(Console.ReadLine());
      if ( cantidad >= 100  )
      {
	Console.WriteLine ("Recibirás un incentivo:");
      }
      else
      {
	Console.WriteLine ("No Recibirás un incentivo:");
      }

    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
