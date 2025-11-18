using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        CASO 02
        Cantidad de vocales
        */
        Console.Write("Digite su nombre : ");
        string name = Console.ReadLine().ToLower();
        int vocalCant = 0;
        foreach (var c in name)
        {
        if ( c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
            vocalCant++;
        }
        }
        Console.WriteLine($"Su nombre tiene {vocalCant} vocales");
        Console.ReadKey();
    }
}