using System;

public class PromedioDeUnaMateria 
{
    public static void Main(string[] args)
    {
      double pu, pd, pt, pc, p, xd, pf;
      Console.WriteLine ("Escribe la primera calificación: ");
      pu = Convert.ToDouble(Console.ReadLine()); 
      Console.WriteLine ("Escribe la segunda calificación: ");
      pd = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ("Escribe la tercera calificación: ");
      pt = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine ("Escribe la cuarta calificación: ");
      pc = Convert.ToDouble(Console.ReadLine());
      
      p = pu + pd + pt + pc;
      pf = p / 4;
      
      
      if (pf % 1 >= 0.5)
      {
	xd = p / 4 ;
	Console.WriteLine ("Felicidades, tu calificación se redondea. Ahora tienes: ");
	Console.WriteLine ("{0:N0}", xd);
      }
      else 
	{
	  xd = p / 4;
	  Console.WriteLine ("Suerte para la proxima, tu calificación no se redondea. Te quedas con:");
	  Console.WriteLine ("{0:N0}", xd);
	}

    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
