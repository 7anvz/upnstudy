using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        CASO 01
        Los dos primeros caracteres
        */
        Console.Write("Digite su nombre : ");
        string name = Console.ReadLine();
        Console.WriteLine($"Su nombre tiene {name.Length} caracteres");
        Console.WriteLine($"Los dos primeros caracteres de su nombre es : {name.Substring(0,2)}");
        Console.ReadKey(); //los espacios tambien son caracteres
    }
}