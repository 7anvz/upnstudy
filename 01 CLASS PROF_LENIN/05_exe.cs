using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        CASO 02
        Nombre en invertido
        */
        Console.Write("Digite su nombre : ");
        string name = Console.ReadLine();
        string nombre_invertido = "";
        for (int i = name.Length - 1; i >= 0; i++) {
            nombre_invertido += name[i];
        }
        Console.WriteLine($"Su nombre invertido es : {nombre_invertido}");
        Console.ReadKey();
    }
}