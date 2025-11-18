using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string name1, name2;
        while(true)
        {
        Console.Write("Ingrese nombre 1 : ");
        name1 = Console.ReadLine().Trim();
        if (!string.IsNullOrWhiteSpace(name1)) break;
        else { Console.WriteLine("No se permiten vacios. \n");}
        }
        while(true)
        {
        Console.Write("Ingrese nombre 2 : ");
        name2 = Console.ReadLine().Trim();
        if (!string.IsNullOrWhiteSpace(name2)) break; //no permitir espacios en blanco
        else { Console.WriteLine("No se permiten vacios. \n");}
        }
        Console.WriteLine(new string('=',25));
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Cantidad de caracteres nombre 1 : {name1.Length}");
        Console.WriteLine($"Cantidad de caracteres nombre 2 : {name2.Length}");
        Console.WriteLine(new string('=',25));
        Console.WriteLine($"Nombre 01 : {name1.ToUpper()} | {name1.ToLower()}");
        Console.WriteLine($"Nombre 02 : {name2.ToUpper()} | {name2.ToLower()}");

        Console.WriteLine(new string('=',25));
        if (name1.CompareTo(name2) == 0) Console.WriteLine("Nombre 1 & 2 son iguales!");
        else { Console.WriteLine("Nombre 1 & 2 son diferentes!"); }

        Console.WriteLine(new string('=',25));
        if(name1.Contains("an")) Console.WriteLine("Si existe 'an' :D");
        else { Console.WriteLine("No existe 'an' en Nombre 01");}

        Console.WriteLine(new string('=',25));
        if(name2.Contains("an")) Console.WriteLine("Si existe 'an' :D");
        else { Console.WriteLine("No existe 'an' en Nombre 02");}

        Console.WriteLine(new string('=',25));
        if (name1.IndexOf("a") != -1) Console.WriteLine($"La primera 'a' posición es : {name1.IndexOf("a")}");
        else { Console.WriteLine("No existe 'a' en Nombre 01");}

        Console.WriteLine(new string('=',25));
        if (name2.IndexOf("a") != -1) Console.WriteLine($"La ultima 'a' posición es : {name2.IndexOf("a")}");
        else { Console.WriteLine("No existe 'a' en Nombre 02");}

        Console.WriteLine(new string('=',25));
        Console.WriteLine($"INSERTANDO 'UPN' EN NOMBRE 1 : {name1.Insert(0, "UPN")}");
        Console.WriteLine($"INSERTANDO 'SISTEMAS' EN NOMBRE 2 : {name2.Insert(name2.Length, "SISTEMAS")}");

        Console.WriteLine(new string('=',25));
        if (name1.Length > 5) Console.Write($"Eliminando carateres desde la 5ta posición : {name1.Remove(5)}");
        else { Console.WriteLine("No tiene mas de 5 caracteres Nombre 01!");}

        Console.WriteLine(new string('=',25));
        if (name1.Contains("a")) Console.WriteLine($"Reemplazo 'a' por '@' : {name1.Replace("a","@")}");
        else { Console.WriteLine("No existe la 'a' en Nombre 01"); }

        Console.WriteLine(new string('=',25));
        if (name2.Contains("a")) Console.WriteLine($"Reemplazo 'a' por '@' : {name2.Replace("a","@")}");
        else { Console.WriteLine("No existe la 'a' en Nombre 02"); }

        Console.WriteLine(new string('=',25));
        if (name1.Contains("a")) {
            string[] partes = name1.Split('a');
            Console.Write("División de partes Nombre 01: ");
            for (int i = 0; i < partes.Length; i++) {
                Console.Write(partes[i] + " -> ");
            }
        }
        else { Console.WriteLine(" No exite a en Nombre 01"); }

        Console.WriteLine(new string('=',25));
        if(name2.Length > 4) Console.WriteLine($"Sub cadena Nombre 02 : {name2.Substring(4)}");
        else { Console.WriteLine("Nombre 02 no tiene mas de 4 caracteres!"); }

        Console.WriteLine(new string('=',25));
        char[] arreglo = name1.ToCharArray(); //divide un string, lo convierte en un arreglo, letras con posiciones
        for (int i = 0; i < arreglo.Length; i++) {
            Console.WriteLine(arreglo[i]);
        }

        Console.WriteLine("Nombre 01 en reversa : ");
        for (int i = arreglo.Length - 1; i >= 0; i--) {
            Console.WriteLine(arreglo[i]);
        }
        
        Array.Sort(arreglo);
        Console.Write("Nombre 01 ordenado : ");
        for (int i = 0; i < arreglo.Length; i++) {
            Console.Write(arreglo[i]);
        }

        Console.ReadKey();
    }
}

// IMPORTANTE REPASAR:
//aprender a saber como ingresar solo un numero con el formato 1.20  
// 0.00
//primero buscar el punto decimal con contains "."
// luego dividir con el split("")
// despues .Length = 1 para la primera parte del numero & Length = 2 para la otra parte
// primero almacenar como string y luego convertir a double
// apoyarse con TryParse
// si es que el usuario usa coma (,) usar Replace por un punto (.)

/*
Crear un programa que solicite tus apellidos y luego tus nombres completos (Si el
usuario ingresa espacios antes o después eliminarlo), luego que permita realizar lo
siguiente (imprimiendo en consola de color amarillo 5 líneas, después todo de
color azul y resaltar cualquier línea de color verde):
• Calcular la cantidad de caracteres que contiene los apellidos.
• Mostrar los nombres en mayúsculas.
• Mostrar los apellidos en minúsculas.
• Comparar apellidos y nombres, si son iguales o diferentes.
• Evaluar si el nombre contiene el texto “an”. Si no contiene mostrar mensaje
no contiene la palabra “an”.
• Mostrar su primera posición del texto “a” en apellidos. Si no contiene
mostrar mensaje no contiene la palabra “a”.
• Mostrar su última posición del texto “a” en apellidos. Si no contiene mostrar
mensaje no contiene la palabra “a”.
• Inserte la palabra “upn” al inicio de los nombres.
• Inserte la palabra “sistemas” al final de los apellidos.
• Eliminar los caracteres de los apellidos a partir de la 5ta posición, si no hay 5
o más caracteres mostrar mensaje “no contiene 5 caracteres o más”
• Reemplazar la letra “a” -> “@” en nombres. Si no existe mostrar mensaje “no
se puede reemplazar porque no existe la letra “a”.
• Dividir el texto desde la letra “a” en apellidos. Si o hay la letra “a” mostrar
mensaje “no contiene la letra “a”.
• Mostrar una sub-cadena a partir de la 4ta posición de los nombres. Si no
contiene 4 o más caracteres mostrar "el apellido no contiene 4 caracteres o
más".
• Convertir nombres en arreglo e imprimirlo verticalmente.
• Imprimir el nombre en reversa.
• Imprimir los caracteres del nombre ordenado alfabéticamente.
*/