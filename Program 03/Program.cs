using System;

namespace CalculadoraDecimalSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
            Console.WriteLine(" Calculadora para decimales \n");

            Console.Write("Ingresa el primer número decimal: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo número decimal: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal suma = num1 + num2;
            decimal resta = num1 - num2;

            Console.WriteLine($"\n Resultados:");
            Console.WriteLine($"{num1} + {num2} = {suma}");
            Console.WriteLine($"{num1} - {num2} = {resta}");

            //ejercicio2
             Console.WriteLine("--- BLOQUE 3: NÚMEROS DECIMALES ---");

        // Peso (double)
        double peso = 72.5;
        Console.WriteLine("1. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + peso + " kg");

        // Salario (decimal)
        decimal salario = 85000.75m;
        Console.WriteLine("\n2. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   Valor guardado: $" + salario);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio3
        Console.WriteLine("--- BLOQUE 4: NÚMEROS DECIMALES ---");

        // Distancia (double)
        double distancia = 15.8;
        Console.WriteLine("1. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + distancia + " km");

        // Precio (decimal)
        decimal precio = 1200.50m;
        Console.WriteLine("\n2. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   Valor guardado: $" + precio);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio4

        Console.WriteLine("--- BLOQUE 5: NÚMEROS DECIMALES ---");

        // Temperatura (double)
        double temperatura = 28.6;
        Console.WriteLine("1. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + temperatura + " °C");

        // Costo (decimal)
        decimal costo = 350.99m;
        Console.WriteLine("\n2. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   Valor guardado: $" + costo);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //ejercicio5
        Console.WriteLine("--- BLOQUE 6: NÚMEROS DECIMALES ---");

        // Velocidad (double)
        double velocidad = 90.5;
        Console.WriteLine("1. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + velocidad + " km/h");

        // Pago (decimal)
        decimal pago = 4500.80m;
        Console.WriteLine("\n2. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   Valor guardado: $" + pago);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
        }
    }
}