using System;

namespace Program05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM 05 - EJERCICIOS CON BOOLEANOS ===\n");

            // Ejercicio 1
            Console.WriteLine("--- VALORES LÓGICOS (SÍ / NO) ---");
            bool cursoCompletado = true;
            Console.WriteLine("¿El curso está completado?: " + cursoCompletado);

            // Ejercicio 2
            Console.WriteLine("\n--- MAYOR DE EDAD ---");
            bool esMayorDeEdad = true;
            Console.WriteLine("¿La persona es mayor de edad?: " + esMayorDeEdad);

            // Ejercicio 3
            Console.WriteLine("\n--- USUARIO ACTIVO ---");
            bool usuarioActivo = false;
            Console.WriteLine("¿El usuario está activo?: " + usuarioActivo);

            // Ejercicio 4
            Console.WriteLine("\n--- PRODUCTO DISPONIBLE ---");
            bool productoDisponible = true;
            Console.WriteLine("¿El producto está disponible?: " + productoDisponible);

            // Ejercicio 5
            Console.WriteLine("\n--- CONEXIÓN A INTERNET ---");
            bool hayInternet = false;
            Console.WriteLine("¿Hay conexión a internet?: " + hayInternet);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}