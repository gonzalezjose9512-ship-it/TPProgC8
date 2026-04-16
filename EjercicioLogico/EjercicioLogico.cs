using System;

namespace EjercicioLogico

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desarrollo del problema.");

        
            const int CANTIDAD_CLIENTES = 20;
            string[] nombres = new string[CANTIDAD_CLIENTES];
            int[] edades = new int[CANTIDAD_CLIENTES];

            Console.WriteLine("=== CONTROL DE INGRESO AL BOLICHE ===");

            // Cargar datos de los 20 clientes
            for (int i = 0; i < CANTIDAD_CLIENTES; i++)
            {
                Console.Write("\nCliente #" + (i + 1) + " - Ingrese nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("\nIngrese edad de " + nombres[i] + ": ");
                edades[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n=== RESULTADOS DE INGRESO ===");

            // Verificar quién puede entrar
            for (int i = 0; i < CANTIDAD_CLIENTES; i++)
            {
                if (edades[i] > 30) // Mayores de 30
                {
                    Console.WriteLine(nombres[i]+","+edades[i]+"años: puede ingresar");
                }
                else // 30 o menos
                {
                    Console.WriteLine(nombres[i]+","+edades[i]+"años: a la casa");
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();

            Console.WriteLine("¡Problema de clase resuelto!");
        }
    }
}

           
   
