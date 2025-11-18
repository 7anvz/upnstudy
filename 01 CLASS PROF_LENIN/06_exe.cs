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
        string name = Console.ReadLine();
        int vocalCant = 0;
        string vocales = "AEIOUaeiou";
        for (int i = 0; i < name.Length; i++)
        {
        if (vocales.Contains(name[i].ToString())) {
            vocalCant++;
        }
        }
        Console.WriteLine($"Su nombre tiene {vocalCant} vocales");
        Console.ReadKey();
    }
}