using System;
using System.Collections.Generic;
using System.Text;

namespace FormTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Программа определяет тип треугольника по введенным длинам сторон :");
            Console.WriteLine();
            Console.WriteLine("Пожалуйста, введите длину первой стороны треугольника :");

            double one;
            while (!double.TryParse(Console.ReadLine(), out one))
            {
                Console.Write("Введенные данные неккоректны, попробуйте снова: ");
            }
            Console.WriteLine("Пожалуйста, введите основание:");
            double two;
            while (!double.TryParse(Console.ReadLine(), out two))
            {
                Console.Write(" Введенные данные неккоректны, попробуйте снова: ");
            }
            Console.WriteLine("Пожалуйста, введите длину третьей стороны треугольника :");

            double three;
            while (!double.TryParse(Console.ReadLine(), out three))
            {
                Console.Write(" Введенные данные неккоректны, попробуйте снова: ");
            }
            string getFormTrianling = triangle.FormTriangling(one, two, three);
            Console.WriteLine(getFormTrianling);
            Console.ReadKey();
        }
        public class Triangle
        {
            public string FormTriangling(double one, double two, double three)
            {
                if (one <= 0 || two <= 0 || three <= 0 || one + two <= three || one + three <= two || two + three <= one)
                {
                    return "Треугольника с такими сторонами не существует!!!";
                }
                if (one == two && one == three && two == three)
                {
                    double S = Math.Sqrt(3) / 4 * Math.Pow(one, 2);
                    Console.WriteLine("Площадь треугольника " + S);
                    return "Треугольник равносторонний!";
                }
                if (((one * one) == (two * two) + (three * three)) || ((two * two) == ((one * one) + (three * three)) || ((three * three) == (two * two) + (one * one))))
                {
                    double S = one * two / 2;
                    Console.WriteLine("Площадь треугольника " + S);
                    return "Треугольник прямоугольный!";
                   
                }
                if ((one == two && one != three) || (two == three && two != one) || (one == three && one != two))
                {
                    double S = two / 4 * Math.Sqrt(4 * Math.Pow(one, 2) - Math.Pow(two, 2));
                    Console.WriteLine("Площадь треугольника " + S);
                    return "Треугольник равнобедренный!";
                }
                double V = 1/2 * one * two * Math.Sin(one);
                Console.WriteLine("Площадь треугольника " + V);
                return "Треугольник разносторонний!";
            }
        }
    }
}