using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<double> resultados = new List<double>();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Mostrar resultados y salir");
            Console.Write("Elija una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                    resultados.Add(num1 + num2);
                    Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                    break;
                case "2":
                    Console.Write("Ingrese el primer número: ");
                    double num3 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num4 = double.Parse(Console.ReadLine());
                    resultados.Add(num3 - num4);
                    Console.WriteLine($"El resultado de la resta es: {num3 - num4}");
                    break;
                case "3":
                    Console.Write("Ingrese el primer número: ");
                    double num5 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num6 = double.Parse(Console.ReadLine());
                    resultados.Add(num5 * num6);
                    Console.WriteLine($"El resultado de la multiplicación es: {num5 * num6}");
                    break;
                case "4":
                    Console.Write("Ingrese el dividendo: ");
                    double dividendo = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el divisor: ");
                    double divisor = double.Parse(Console.ReadLine());
                    if (divisor != 0)
                    {
                        resultados.Add(dividendo / divisor);
                        Console.WriteLine($"El resultado de la división es: {dividendo / divisor}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                    break;
            }
        }

        Console.WriteLine("Resultados:");
        for (int i = 0; i < resultados.Count; i++)
        {
            Console.WriteLine($"Resultado {i + 1}: {resultados[i]}");
        }
    }
}