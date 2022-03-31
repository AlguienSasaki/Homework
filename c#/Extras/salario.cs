using System;

public class SueldoDeUnaPersona 
{
    public static void Main(string[] args)
    {
    double h, he, ch, che, d, des, sueldo;
    Console.WriteLine("Ingresa tus horas trabajadas: ");
    h = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingresa tus horas extras: ");
    he = Convert.ToDouble(Console.ReadLine());
    ch = h * 50.0;
    che = he * 80.0;
    d = ch + che;
    des = d * 0.05;
    sueldo = d - des; 
    Console.WriteLine("Tu sueldo final será de: ");
    Console.WriteLine(sueldo);
    Console.ReadKey();
    }
}

// se usa el comando "csc" para compilar y mono para ejecutar
