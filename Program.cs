using proyecto_pila;

namespace proyecto_pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pila miPila = null;
            int opcion;

            do
            {
                Console.WriteLine("       PROYECTO PILAS       ");
                Console.WriteLine("                            ");
                Console.WriteLine("1. Definir tamaño de la pila");
                Console.WriteLine("2. Agregar elemento (Push)");
                Console.WriteLine("3. Sacar elemento (Pop)");
                Console.WriteLine("4. Ver la pila");
                Console.WriteLine("5. Salir");
                Console.WriteLine("");
                Console.Write("Selecciona una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.\n");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el tamaño de la lista: ");
                        if (int.TryParse(Console.ReadLine(), out int maxTamaño) && maxTamaño > 0)
                        {
                            miPila = new pila(maxTamaño);
                            Console.WriteLine("");
                            Console.WriteLine($"Pila creada con tamaño {maxTamaño}.\n");
                        }
                        else
                        {
                            Console.WriteLine("Tamaño no válido. Ingresa un número mayor a 0.\n");
                        }
                        break;

                    case 2:
                        if (miPila == null)
                        {
                            Console.WriteLine("Primero define el tamaño de la pila.\n");
                        }
                        else
                        {
                            Console.Write("Ingresa el número a agregar: ");
                            if (int.TryParse(Console.ReadLine(), out int numero))
                            {
                                miPila.Push(numero);
                            }
                            else
                            {
                                Console.WriteLine("Número no válido.\n");
                            }
                        }
                        break;

                    case 3:
                        if (miPila == null)
                        {
                            Console.WriteLine("Primero define el tamaño de la pila.\n");
                        }
                        else
                        {
                            miPila.Pop();
                        }
                        break;

                    case 4:
                        if (miPila == null)
                        {
                            Console.WriteLine("Primero define el tamaño de la pila.\n");
                        }
                        else
                        {
                            miPila.PrintStack();
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...\n");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.\n");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
