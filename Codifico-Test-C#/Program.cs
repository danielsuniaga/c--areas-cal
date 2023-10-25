using Codifico_Test_C_;
using System;


class Program
{


    static void Main()
    {

        //the class instance is generated
        area_calculus management = new area_calculus();

        while (true)
        {

            Console.WriteLine("Calculadora de Área de Figuras Geométricas");

            Console.WriteLine("1. Calcular el área de un círculo");

            Console.WriteLine("2. Calcular el área de un rectángulo");

            Console.WriteLine("3. Salir");

            string _option = Console.ReadLine();

            if (_option == "1")
            {

                // The data is requested to calculate the area of the circle
                Console.Write("Ingrese el radio del círculo: ");

                if (double.TryParse(Console.ReadLine(), out double _radio) && _radio > 0)
                {
                    
                    Console.WriteLine(management.circle(_radio));
                   
                }
                else
                {
                    Console.WriteLine("El radio debe ser un número positivo.");
                }
            }
            else if (_option == "2")
            {
                // The data is requested to calculate the area of the rectangle
                Console.Write("Ingrese la base del rectángulo: ");

                if (double.TryParse(Console.ReadLine(), out double rectangle_base) && rectangle_base > 0)
                {

                    Console.Write("Ingrese la altura del rectángulo: ");

                    if (double.TryParse(Console.ReadLine(), out double rectangle_height) && rectangle_height > 0)
                    {

                        Console.WriteLine(management.rectangle(rectangle_base,rectangle_height));

                    }
                    else
                    {

                        Console.WriteLine("La altura debe ser un número positivo.");

                    }

                }
                else
                {

                    Console.WriteLine("La base debe ser un número positivo.");

                }
            }
            else if (_option == "3")
            {

                // exit the program
                Console.WriteLine("¡Hasta luego!");

                break;

            }
            else
            {

                Console.WriteLine("Opción no válida. Por favor, elija 1, 2 o 3.");

            }
        }
    }
}
