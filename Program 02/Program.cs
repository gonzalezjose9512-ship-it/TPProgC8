using System;

namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
            Console.WriteLine("=== CALCULADORA SIMPLE ===\n");

            Console.Write("Ingresa el primer número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            double suma = num1 + num2;
            double resta = num1 - num2;

            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"{num1} + {num2} = {suma}");
            Console.WriteLine($"{num1} - {num2} = {resta}");

            //ejercicio2
            Console.WriteLine("--- BLOQUE 2: NÚMEROS DECIMALES ---");

        // Declaración decimal
        double precio = 1250.50;

        Console.WriteLine("1. TIPO DOUBLE (double):");
        Console.WriteLine("   Para números con decimales como precios o medidas.");
        Console.WriteLine("   Valor guardado: " + precio);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
        
        //ejercicio3
        Console.WriteLine("--- BLOQUE 3: TEXTO ---");

        // Declaración texto
        string nombre = "Juan Perez";

        Console.WriteLine("1. TIPO TEXTO (string):");
        Console.WriteLine("   Para guardar palabras o frases.");
        Console.WriteLine("   Valor guardado: " + nombre);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio4
        Console.WriteLine("--- BLOQUE 4: BOOLEANO ---");

        // Declaración booleano
        bool activo = true;

        Console.WriteLine("1. TIPO BOOLEANO (bool):");
        Console.WriteLine("   Solo permite verdadero o falso.");
        Console.WriteLine("   Valor guardado: " + activo);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio5
        Console.WriteLine("--- BLOQUE 5: CARACTER ---");

        // Declaración carácter
        char letra = 'A';

        Console.WriteLine("1. TIPO CARACTER (char):");
        Console.WriteLine("   Para guardar un solo carácter.");
        Console.WriteLine("   Valor guardado: " + letra);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
        }
    }
}