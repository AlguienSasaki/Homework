using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int ado, area;
      Console.WriteLine ("Ingresa el lado: ");
      ado = int.Parse(Console.ReadLine());
      area = ado * ado;
      Console.WriteLine ("El area es: ");
      Console.WriteLine (area);
      Console.ReadLine();
    }

}
