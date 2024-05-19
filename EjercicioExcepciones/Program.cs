using EjercicioExcepciones;

namespace EjercicioExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una operación:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                int opcion;
                bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

                if (!esNumero)
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    Console.ReadKey();
                    continue;
                }

                if (opcion == 5)
                {
                    continuar = false;
                    continue;
                }

                Console.Write("Ingrese el primer número: ");
                double num1;
                bool esNumero1 = double.TryParse(Console.ReadLine(), out num1);

                if (!esNumero1)
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Ingrese el segundo número: ");
                double num2;
                bool esNumero2 = double.TryParse(Console.ReadLine(), out num2);

                if (!esNumero2)
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    double resultado = 0;
                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            Console.WriteLine($"El resultado de la suma es: {resultado}");
                            break;
                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            Console.WriteLine($"El resultado de la resta es: {resultado}");
                            break;
                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                            break;
                        case 4:
                            resultado = operaciones.Dividir(num1, num2);
                            Console.WriteLine($"El resultado de la división es: {resultado}");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
