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

            string[] frutas = { "Manzanas", "Banana", "Kiwi", "Mandarina","Arandanos" };
            Console.WriteLine(" Lista de Frutas usando foreach:");

            foreach (string fruta in frutas)
            {
                Console.WriteLine("  " + fruta);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();


            //ejercicio 2

            Console.WriteLine("-----Ejercicio 4: Inicialización Directa y Foreach___");

            string[] suplementos = { "Proteina", "Creatina", "vitamina", "Omega-3", "BCAA" };
            Console.WriteLine(" Lista de Suplementos usando foreach:");

            foreach (string suplemento in suplementos)
            {
                Console.WriteLine("  " + suplemento);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 3

            Console.WriteLine("-----Ejercicio 5: Inicialización Directa y Foreach___");

            string[] plantas = { "Rosa", "Tulipan", "Succulenta" };
            Console.WriteLine(" Lista de Plantas usando foreach:");

            foreach (string planta in plantas)
            {
                Console.WriteLine("  " + planta);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 4

            Console.WriteLine("-----Ejercicio 6: Inicialización Directa y Foreach___");

            string[] celulares = { "iPhone", "Samsung", "Google", "Huawei", "Poco" };
            Console.WriteLine(" Lista de Celulares usando foreach:");

            foreach (string celular in celulares)
            {
                Console.WriteLine("  " + celular);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();

            //ejercicio 5

            Console.WriteLine("-----Ejercicio 7: Inicialización Directa y Foreach___");

            string[] comidas = { "Arroz", "Pollo", "Pescado", "Carne", "Verduras" };
            Console.WriteLine(" Lista de Comidas usando foreach:");

            foreach (string comida in comidas)
            {
                Console.WriteLine("  " + comida);
            }
            Console.WriteLine("\n Presione enter para continuar...");
            Console.ReadLine();
        }
    }
}