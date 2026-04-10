using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");

            // ejercicio1
            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Ingresa tu edad: ");
            string edadTexto = Console.ReadLine();
            int edad = int.Parse(edadTexto); 

            
            Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            double estatura = double.Parse(Console.ReadLine()); 

            
            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad el próximo año: " + (edad + 1)); 
            Console.WriteLine("Estatura: " + estatura + " metros");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

            //ejercicio2
             Console.WriteLine("--- REGISTRO DE PRODUCTO ---");

        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        double total = precio * cantidad;

        Console.WriteLine("\n--- DETALLE DEL PRODUCTO ---");
        Console.WriteLine("Producto: " + producto);
        Console.WriteLine("Precio: $" + precio);
        Console.WriteLine("Cantidad: " + cantidad);
        Console.WriteLine("Total a pagar: $" + total);

        Console.ReadLine();

        //ejercicio3
         Console.WriteLine("--- REGISTRO DE ALUMNO ---");

        Console.Write("Ingrese nombre del alumno: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        double promedio = (nota1 + nota2) / 2;

        Console.WriteLine("\n--- RESULTADO ---");
        Console.WriteLine("Alumno: " + nombre);
        Console.WriteLine("Promedio: " + promedio);

        Console.ReadLine();

        //ejercicio4
        Console.WriteLine("--- CALCULO DE SUELDO ---");

        Console.Write("Ingrese nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese horas trabajadas: ");
        int horas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese pago por hora: ");
        double pago = double.Parse(Console.ReadLine());

        double sueldo = horas * pago;

        Console.WriteLine("\n--- SUELDO ---");
        Console.WriteLine("Empleado: " + nombre);
        Console.WriteLine("Sueldo total: $" + sueldo);

        Console.ReadLine();

        //ejercicio5
        Console.WriteLine("--- REGISTRO DE VEHICULO ---");

        Console.Write("Ingrese marca del vehículo: ");
        string marca = Console.ReadLine();

        Console.Write("Ingrese año del vehículo: ");
        int año = int.Parse(Console.ReadLine());

        Console.Write("Ingrese kilometraje: ");
        double km = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- DATOS DEL VEHICULO ---");
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Año: " + año);
        Console.WriteLine("Kilometraje: " + km + " km");

        Console.ReadLine();
    }
}