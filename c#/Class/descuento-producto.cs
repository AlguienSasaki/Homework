using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      double pp, des, tt;
      Console.WriteLine ("Escribe el precio: ");
      pp = Convert.ToDouble(Console.ReadLine());
      des = pp * 0.5;
      tt = pp - des;
      Console.WriteLine ("El precio inicial era: ");
      Console.WriteLine (pp);
      Console.WriteLine ("Pero tiene un descuento del 50% equivalente a: ");
      Console.WriteLine (des);
      Console.WriteLine ("Así que l monto a pagar finalmente será de: ");
      Console.WriteLine (tt);
       
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
