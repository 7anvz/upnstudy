using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        CASO 01
        Datos & Split()
        */
        Console.Write("Digite sus datos : ");
        string[] datos = Console.ReadLine().Split(' ');
        if (datos.Length == 1)//Anita
        Console.WriteLine($"Su primer nombre es: {datos[0]}");
        else if (datos.Length == 2) // Anita Vasquez
        {
            Console.WriteLine($"Su primer nombre es : {datos[0]}");
            Console.WriteLine($"Su apellido paterno es : {datos[1]}");
        }
        else  { //Anita Vasquez Perez
            Console.WriteLine($"Su primer nombre es : {datos[0]}");
            Console.WriteLine($"Su apellido paterno es : {datos[1]}");
            Console.WriteLine($"Su apellido materno es : {datos[2]}");
        }
        Console.ReadKey();
    }
}