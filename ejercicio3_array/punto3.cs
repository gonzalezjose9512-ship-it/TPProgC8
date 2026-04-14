namespace ejercicio_2_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Ejercicio 2: Inicialización Directa y Foreach___");
            string[]frutas = { "Manzanas", "Banana", "Uva", "Naranja" };
            Console.WriteLine(" Lista de Frutas usando foreach:");

            foreach (string fruta in frutas) 
            {
                Console.WriteLine("  "+ fruta);
        }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();


            //ejercicio 1

            Console.WriteLine("-----Ejercicio 3: Inicialización Directa y Foreach___");

            string[] perros = { "Caniche", "Labrador", "Ovejero", "Pastor Alemán","Chihuahua" };
            Console.WriteLine(" Lista de Perros usando foreach:");

            foreach (string perro in perros)
            {
                Console.WriteLine("  " + perro);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();


            //ejercicio 2

            Console.WriteLine("-----Ejercicio 4: Inicialización Directa y Foreach___");

            string[] bebidas = { "coca", "Pepsi", "sevenup", "Fanta", "Mirinda" };
            Console.WriteLine(" Lista de Bebidas usando foreach:");

            foreach (string bebida in bebidas)
            {
                Console.WriteLine("  " + bebida);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 3

            Console.WriteLine("-----Ejercicio 5: Inicialización Directa y Foreach___");

            string[] camaras = { "Hikvision", "Dahua", "Imou" };
            Console.WriteLine(" Lista de Cámara usando foreach:");

            foreach (string camara in camaras)
            {
                Console.WriteLine("  " + camara);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 4

            Console.WriteLine("-----Ejercicio 6: Inicialización Directa y Foreach___");

            string[] arboles = { "Roble", "Naranjo", "Cedro", "Manzano", "Aguacero" };
            Console.WriteLine(" Lista de Árboles usando foreach:");

            foreach (string arbol in arboles)
            {
                Console.WriteLine("  " + arbol);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 5

            Console.WriteLine("-----Ejercicio 7: Inicialización Directa y Foreach___");

            string[] televisores = { "Samsung", "LG", "Sony", "TCL", "Hisense" };
            Console.WriteLine(" Lista de Televisores usando foreach:");

            foreach (string televisor in televisores)
            {
                Console.WriteLine("  " + televisor);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();
        }
    }
}