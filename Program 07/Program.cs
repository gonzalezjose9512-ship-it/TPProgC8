using System;

namespace Program07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM 07 - EJERCICIOS CON CONSTANTES COMERCIALES ===\n");

            const char SIMBOLO_PESO = '$';

            // Ejercicio 1
            const decimal TASA_IVA = 0.21m;
            const bool MODO_PRUEBA = false;
            decimal precioBase1 = 1500.50m;
            decimal impuesto = precioBase1 * TASA_IVA;
            decimal total1 = precioBase1 + impuesto;
            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba: " + MODO_PRUEBA);
            Console.WriteLine("Total: " + SIMBOLO_PESO + total1);

            // Ejercicio 2
            const decimal DESCUENTO = 0.10m;
            const bool PROMOCION_ACTIVA = true;
            decimal precioProducto2 = 2500.75m;
            decimal descuento = precioProducto2 * DESCUENTO;
            decimal total2 = precioProducto2 - descuento;
            Console.WriteLine("\n--- SISTEMA DE DESCUENTO ---");
            Console.WriteLine("Promoción activa: " + PROMOCION_ACTIVA);
            Console.WriteLine("Total: " + SIMBOLO_PESO + total2);

            // Ejercicio 3
            const decimal RECARGO_ENVIO = 0.15m;
            const bool ENVIO_DOMICILIO = true;
            decimal precioProducto3 = 3200.50m;
            decimal recargo = precioProducto3 * RECARGO_ENVIO;
            decimal total3 = precioProducto3 + recargo;
            Console.WriteLine("\n--- SISTEMA DE ENVÍO ---");
            Console.WriteLine("Envío a domicilio: " + ENVIO_DOMICILIO);
            Console.WriteLine("Total: " + SIMBOLO_PESO + total3);

            // Ejercicio 4
            const decimal COMISION = 0.08m;
            const bool VENTA_ACTIVA = true;
            decimal montoVenta = 5000m;
            decimal comision = montoVenta * COMISION;
            decimal total4 = montoVenta + comision;
            Console.WriteLine("\n--- SISTEMA DE COMISIONES ---");
            Console.WriteLine("Venta activa: " + VENTA_ACTIVA);
            Console.WriteLine("Total: " + SIMBOLO_PESO + total4);

            // Ejercicio 5
            const decimal PROPINA = 0.12m;
            const bool SERVICIO_COMPLETO = true;
            decimal consumo = 4200.80m;
            decimal propina = consumo * PROPINA;
            decimal total5 = consumo + propina;
            Console.WriteLine("\n--- RESTAURANTE ---");
            Console.WriteLine("Servicio completo: " + SERVICIO_COMPLETO);
            Console.WriteLine("Total: " + SIMBOLO_PESO + total5);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}