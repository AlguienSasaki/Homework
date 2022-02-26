using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      double pes, t;
      Console.WriteLine ("Ingresa tu cantidad de pesos: ");
      pes = Convert.ToDouble(Console.ReadLine());
      t = pes / 20.35; 
      Console.WriteLine ("Tienes la siguiente cantidad de dolares: ");
      Console.WriteLine (t);
      Console.ReadLine();
    }

}
