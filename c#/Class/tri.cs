using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

      int iu, id, it;
      Console.WriteLine ("Escribe el primer lado: ");
      iu = int.Parse(Console.ReadLine());
      Console.WriteLine ("Escribe el 2d0 lado: ");
      id = int.Parse(Console.ReadLine());
      Console.WriteLine ("Escribe el tercer lado: ");
      it = int.Parse(Console.ReadLine());
      if ( iu == id & iu == it)
      {
	Console.WriteLine ("Es isosceles ");
      }
      else
      {
	if (iu != id & iu != it)
	  Console.WriteLine ("Es equialtero");
	else
	{
	  Console.WriteLine ("Es escaleno ");
	}
      }
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
