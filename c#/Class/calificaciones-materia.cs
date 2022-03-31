using System;

public class PromedioDeUnaMateria 
{
    public static void Main(string[] args)
    {
      double pu, pd, pt, pc, p, pf;
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
      
      Console.WriteLine ("Tu promedio es: ");
      Console.WriteLine (pf);
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
