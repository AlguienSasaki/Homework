using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      double pi = 3.1416;
      double area;
      double radio;
      Console.WriteLine ("Ingresa el radio: ");
      radio = Convert.ToDouble(Console.ReadLine());
      area = pi * radio * radio;
      Console.WriteLine ("El area es: ");
      Console.WriteLine (area);
      Console.ReadLine();
    }

}
