using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
      int phne, chara;
      Console.WriteLine ("Ingresa los numeros de inicio de tu numeros");
      Console.WriteLine ("98 o 99");
      chara = int.Parse(Console.ReadLine());
      if ( chara == 98){
	Console.WriteLine ("Ingresa el 1 para indicar que el numero telefonico es de 7 caracteres y por lo tanto local y 1 para indicar que el numero telefonico es de 10 caracteres y por lo tanto internacional: ");
	phne = int.Parse(Console.ReadLine());
	if ( phne == 1){
	  Console.WriteLine ("Ingresa el numero telefonico");
	  Console.ReadLine();
	  Console.WriteLine ("Tu numero es de claro y es local");
	}
	else{  
	  Console.WriteLine ("Ingresa el numero telefonico");
	  Console.ReadLine();
	  Console.WriteLine ("Tu numero es de claro y es internacional");
	}
      }
	else{
	Console.WriteLine ("Ingresa el 1 para indicar que el numero telefonico es de 7 caracteres y por lo tanto local y 1 para indicar que el numero telefonico es de 10 caracteres y por lo tanto internacional: ");
	phne = int.Parse(Console.ReadLine());
	  if ( phne == 1){
	    Console.WriteLine ("Ingresa el numero telefonico");
	    Console.ReadLine();
	    Console.WriteLine ("Tu numero es de movistar y es local");
        }
        else{
	  Console.WriteLine ("Ingresa el numero telefonico");
	  Console.ReadLine();
	  Console.WriteLine ("Tu numero es de movistar y es internacional");
        }


	}

      }
}

// se usa el comando "csc" para compilar y mono para ejecutar
