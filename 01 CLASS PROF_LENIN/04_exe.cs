using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        CASO 02
        Nombre en vertical
        */
        Console.Write("Digite su nombre : ");
        string name = Console.ReadLine();
        Console.WriteLine("Su nombre en vertical es :");
        foreach (var c in name)
        {
            Console.WriteLine(c);
        }
        Console.ReadKey();
    }
}