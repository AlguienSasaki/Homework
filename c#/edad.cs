using System;

public class EdadNecesaria 
{
    public static void Main(string[] args)
    {
       int e; 
       Console.WriteLine ("Escribe tu edad: ");
       e = int.Parse(Console.ReadLine());
       if (e >= 18 & e <= 110)
       {
          Console.WriteLine ("Puedes votar ");
       }
       else
       {
	  if (e > 110)
	  {
	    Console.WriteLine ("Deberías estar muerto XD ");
	  }
	  else
	  {
	    Console.WriteLine ("No puedes votar ");

	  }
       }  
      
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
