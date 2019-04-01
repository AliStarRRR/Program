using System;

namespace Homework
{
    class IsCollinear
    {
        static void Main()
        {
            double x1, y1, x2, y2;

            Console.WriteLine("Введите координаты первого вектора (x1 и y1):");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второго вектора (x2 и y2):");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

        
            if ((x1/x2) == (y1/y2))
            {
                Console.WriteLine("Векторы коллинеарны");
            }
            else
            {
                Console.WriteLine("Векторы не коллинеарны");
            }
            Console.ReadKey();
        }
    }
}
