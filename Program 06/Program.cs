using System;

namespace Program06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM 06 - EJERCICIOS CON CONSTANTES ===\n");

            // Ejercicio 1
            const string NOMBRE_APP = "GameMaster Pro";
            const string VERSION1 = "v1.0.2";
            const int EDAD_MINIMA1 = 18;
            const int EDAD_CLIENTE1 = 20;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE1 >= EDAD_MINIMA1;
            Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION1 + ") ===");
            Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR);

            // Ejercicio 2
            const string NOMBRE_CINE = "CineMax";
            const string VERSION2 = "v2.1";
            const int EDAD_MINIMA2 = 13;
            const int EDAD_CLIENTE2 = 15;
            const bool PUEDE_ENTRAR = EDAD_CLIENTE2 >= EDAD_MINIMA2;
            Console.WriteLine("\n=== " + NOMBRE_CINE + " (" + VERSION2 + ") ===");
            Console.WriteLine("Acceso permitido: " + PUEDE_ENTRAR);

            // Ejercicio 3
            const string NOMBRE_GYM = "Power Gym";
            const string VERSION3 = "v1.5";
            const int EDAD_MINIMA3 = 16;
            const int EDAD_CLIENTE3 = 18;
            const bool PUEDE_ENTRENAR = EDAD_CLIENTE3 >= EDAD_MINIMA3;
            Console.WriteLine("\n=== " + NOMBRE_GYM + " (" + VERSION3 + ") ===");
            Console.WriteLine("Acceso permitido: " + PUEDE_ENTRENAR);

            // Ejercicio 4
            const string NOMBRE_BIBLIOTECA = "Biblioteca Central";
            const string VERSION4 = "v3.0";
            const int EDAD_MINIMA4 = 12;
            const int EDAD_USUARIO = 10;
            const bool PUEDE_REGISTRARSE = EDAD_USUARIO >= EDAD_MINIMA4;
            Console.WriteLine("\n=== " + NOMBRE_BIBLIOTECA + " (" + VERSION4 + ") ===");
            Console.WriteLine("Registro permitido: " + PUEDE_REGISTRARSE);

            // Ejercicio 5
            const string NOMBRE_PARQUE = "FunPark";
            const string VERSION5 = "v1.8";
            const int ALTURA_MINIMA = 120;
            const int ALTURA_PERSONA = 130;
            const bool PUEDE_SUBIR = ALTURA_PERSONA >= ALTURA_MINIMA;
            Console.WriteLine("\n=== " + NOMBRE_PARQUE + " (" + VERSION5 + ") ===");
            Console.WriteLine("Acceso permitido: " + PUEDE_SUBIR);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}