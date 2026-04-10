using System;

namespace RegistroDNISimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
            Console.WriteLine(" Registro de Usuario\n");

            string dniRegistrado = "";
            string contraseñaRegistrada = "";

            // REGISTRO
            Console.WriteLine(" Registro ");
            Console.Write("Ingresa tu DNI (solo números): ");
            dniRegistrado = Console.ReadLine();

            Console.Write("Ingresa una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("\n ¡Registro exitoso!\n");

            // INICIO DE SESIÓN
            Console.WriteLine(" Inicio de Sesión");
            
            bool accesoCorrecto = false;
            int intentos = 3;

            while (intentos > 0 && !accesoCorrecto)
            {
                Console.Write("DNI: ");
                string dniIngresado = Console.ReadLine();

                Console.Write("Contraseña: ");
                string contraseñaIngresada = Console.ReadLine();

                if (dniIngresado == dniRegistrado && contraseñaIngresada == contraseñaRegistrada)
                {
                    accesoCorrecto = true;
                    Console.WriteLine($"\n ¡Bienvenido! Acceso concedido.");
                }
                else
                {
                    intentos--;
                    if (intentos > 0)
                        Console.WriteLine($"\n DNI o contraseña incorrectos. Te quedan {intentos} intentos.\n");
                    else
                        Console.WriteLine("\n Acceso bloqueado. Demasiados intentos fallidos.");
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir");
            Console.ReadKey();

            //ejercicio2
             
             Console.WriteLine("--- BLOQUE 4: TEXTO Y CARACTERES ---");

        // Texto
        string ciudad = "Buenos Aires";
        Console.WriteLine("1. TIPO TEXTO (string):");
        Console.WriteLine("   Valor guardado: " + ciudad);

        // Caracter
        char letra = 'B';
        Console.WriteLine("\n2. TIPO CARÁCTER (char):");
        Console.WriteLine("   Valor guardado: '" + letra + "'");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio3
        Console.WriteLine("--- BLOQUE 5: TEXTO Y CARACTERES ---");

        // Texto
        string producto = "Teclado Gamer";
        Console.WriteLine("1. TIPO TEXTO (string):");
        Console.WriteLine("   Valor guardado: " + producto);

        // Caracter
        char codigo = 'T';
        Console.WriteLine("\n2. TIPO CARÁCTER (char):");
        Console.WriteLine("   Valor guardado: '" + codigo + "'");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio4
        Console.WriteLine("--- BLOQUE 6: TEXTO Y CARACTERES ---");

        // Texto
        string pais = "Argentina";
        Console.WriteLine("1. TIPO TEXTO (string):");
        Console.WriteLine("   Valor guardado: " + pais);

        // Caracter
        char inicial = 'A';
        Console.WriteLine("\n2. TIPO CARÁCTER (char):");
        Console.WriteLine("   Valor guardado: '" + inicial + "'");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio5
        Console.WriteLine("--- BLOQUE 7: TEXTO Y CARACTERES ---");

        // Texto
        string marca = "Samsung";
        Console.WriteLine("1. TIPO TEXTO (string):");
        Console.WriteLine("   Valor guardado: " + marca);

        // Caracter
        char letraMarca = 'S';
        Console.WriteLine("\n2. TIPO CARÁCTER (char):");
        Console.WriteLine("   Valor guardado: '" + letraMarca + "'");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
        }
    }
}