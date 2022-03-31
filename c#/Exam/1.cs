using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
	int num, n1, n2, res;  
	Console.WriteLine ("Ingresa el el numero correspondiente a la operación que desees \n 1 para sumar \n 2 para restar \n 3 para multiplicar \n 4 para dividir (recuerda que no puedes dividir entre 0 ;v) \n 5 para elevar a potencia");
	num = int.Parse(Console.ReadLine());

	switch (num){
	  case 1:
	    Console.WriteLine("Ingresa el 1er numero a sumar");
	    n1 = int.Parse(Console.ReadLine());
	    Console.WriteLine("Ingresa el 2er numero a sumar");
	    n2 = int.Parse(Console.ReadLine());
	    res=n1+n2;
	    Console.WriteLine(res);
	    break;
	  case 2:
	    Console.WriteLine("Ingresa el 1er numero a restar");
	    n1 = int.Parse(Console.ReadLine());
	    Console.WriteLine("Ingresa el 2er numero a restar");
	    n2 = int.Parse(Console.ReadLine());
	    res=n1-n2;
	    Console.WriteLine(res);
	    break;
	  case 3:
	    Console.WriteLine("Ingresa el 1er numero a multiplicar");
	    n1 = int.Parse(Console.ReadLine());
	    Console.WriteLine("Ingresa el 2er numero a multiplicar");
	    n2 = int.Parse(Console.ReadLine());
	    res=n1*n2;
	    Console.WriteLine(res);
	    break;
	  case 4:
	    Console.WriteLine("Ingresa el 1er numero a dividir");
	    n1 = int.Parse(Console.ReadLine());
	    Console.WriteLine("Ingresa el 2er numero a dividir");
	    n2 = int.Parse(Console.ReadLine());

	    if (n1 == 0 | n2 == 0 ){
	      Console.WriteLine("Ingresa un numero valido");
	    }
	      else{
	      
	      res=n1/n2;
	      Console.WriteLine(res);
	      }
	    break;
	  case 5:
	    Console.WriteLine("Ingresa el 1er numero a elevar a la segunda potencia");
	    n1 = int.Parse(Console.ReadLine());
	    res=n1*n1;
	    Console.WriteLine(res);
	    break;
	}
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
