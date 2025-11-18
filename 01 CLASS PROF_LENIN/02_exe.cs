using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        CASO 01
        Los dos ultimos caracteres
        */
        Console.Write("Digite su nombre : ");
        string name = Console.ReadLine();
        Console.WriteLine($"Su nombre tiene {name.Length} caracteres");
        //------------- cambios ->
        Console.WriteLine($"Los dos ultimos caracteres de su nombre es : {name.Substring(name.Length-2,2)}");
        Console.ReadKey(); //los espacios tambien son caracteres
    }
}