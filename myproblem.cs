using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace yuiuyiuyuyo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crear cuenta de Max");

                Console.Write("Digite sus datos : ");
                string[] datos = Console.ReadLine().ToLower().Split(' ');
                if (datos.Length == 1)
                { Console.WriteLine($"Su nombre es : {datos[0]}"); }
                else if (datos.Length == 2)
                {
                    Console.WriteLine($"Su nombre es : {datos[0]}");
                    Console.WriteLine($"Su apellido paterno es : {datos[1]}");
                }
                else
                {
                    Console.WriteLine($"Su nombre es : {datos[0]}");
                    Console.WriteLine($"Su apellido paterno es : {datos[1]}");
                    Console.WriteLine($"Su apellido materno es : {datos[2]}");
                }

            Console.WriteLine("¿Desea hacer algun cambio? (s/n)");
            string respuesta = Console.ReadLine();
            Console.WriteLine(new string('=', 25));
            Console.WriteLine("[1] NOMBRE");
            Console.WriteLine("[2] APELLIDO PATERNO");
            Console.WriteLine("[3] APELLIDO MATERNO");
            Console.Write("Escriba el dato desea cambiar : ");
            int cambio = int.Parse(Console.ReadLine());
            if (cambio == 1)
            {
                Console.WriteLine("Escriba el nombre actual : ");
                string nombre = Console.ReadLine();
                if (nombre.ToLower() == datos[0])
                {
                    Console.WriteLine("Cambiar por : ");
                    string nombre_cambio = Console.ReadLine();
                    datos[0] = nombre_cambio;
                    return;
                }

                Console.WriteLine("Intentelo nuevamente!");
            }
            else if (cambio == 2)
            {
                Console.WriteLine("Escriba el apellido paterno actual : ");
                string apellido_paterno = Console.ReadLine();
                if (apellido_paterno.ToLower() == datos[1])
                {
                    Console.WriteLine("Cambiar por : ");
                    string apellidop_cambio = Console.ReadLine();
                    datos[1] = apellidop_cambio;
                    return;
                }

                Console.WriteLine("Intentelo nuevamente!");
            }
            else
            {
                Console.WriteLine("Escriba el apellido paterno actual : ");
                string apellido_materno = Console.ReadLine();
                if (apellido_materno.ToLower() == datos[1])
                {
                    Console.WriteLine("Cambiar por : ");
                    string apellidom_cambio = Console.ReadLine();
                    datos[1] = apellidom_cambio;
                    return;
                }

                Console.WriteLine("Intentelo nuevamente!");
            }
            Console.ReadKey();
        }
    }
}
