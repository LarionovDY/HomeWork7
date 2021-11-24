using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_1
{
    //Два треугольника заданы длинами своих сторон.Определить, площадь какого из них больше (создать метод для вычисления площади треугольника по длинам его сторон).
    //Для решения задачи можно использовать формулу Герона.
    class Program
    {
        static void Main(string[] args)
        {
            double triangleArea1 = 0, triangleArea2 = 0;
            bool triangle1 = false, triangle2 = false;
            while (triangle1 == false)
            {
                Console.WriteLine("Введите пожалуйста длины сторон первого треугольника:");
                Console.WriteLine();
                Console.WriteLine("Сторона 1:");
                double triangleSide1_1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сторона 2:");
                double triangleSide1_2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сторона 3:");
                double triangleSide1_3 = Convert.ToDouble(Console.ReadLine());
                if (triangleSide1_1 + triangleSide1_2 <= triangleSide1_3 || triangleSide1_2 + triangleSide1_3 <= triangleSide1_1 || triangleSide1_1 + triangleSide1_3 <= triangleSide1_2)
                {
                    Console.WriteLine("Введенные стороны не образуют треугольник");
                }
                else
                {
                    triangle1 = true;
                    triangleArea1 = TriangleArea(triangleSide1_1, triangleSide1_2, triangleSide1_3);
                }
            }
            while (triangle2 == false)
            {
                Console.WriteLine("Введите пожалуйста длины сторон второго треугольника:");
                Console.WriteLine();
                Console.WriteLine("Сторона 1:");
                double triangleSide2_1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сторона 2:");
                double triangleSide2_2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сторона 3:");
                double triangleSide2_3 = Convert.ToDouble(Console.ReadLine());
                if (triangleSide2_1 + triangleSide2_2 <= triangleSide2_3 || triangleSide2_2 + triangleSide2_3 <= triangleSide2_1 || triangleSide2_1 + triangleSide2_3 <= triangleSide2_2)
                {
                    Console.WriteLine("Введенные стороны не образуют треугольник");
                }
                else
                {
                    triangle2 = true;
                    triangleArea2 = TriangleArea(triangleSide2_1, triangleSide2_2, triangleSide2_3);
                }
            }            
            CompareArea(triangleArea1, triangleArea2);
            Console.ReadKey();
        }
        static double TriangleArea(double Side1, double Side2, double Side3)    //метод, вычисляющий площадь треугольника
        {
            double halfPerimeter = (Side1 + Side2 + Side3) / 2;
            double Area = Math.Sqrt(halfPerimeter * (halfPerimeter - Side1) * (halfPerimeter - Side2) * (halfPerimeter - Side3));
            return Area;
        }
        static void CompareArea(double Area1, double Area2)     // метод, сравнивающий площади двух треугольников и выводящий ответ на консоль
        {
            if (Area1 == Area2)
            {
                Console.WriteLine("Площади треугольников равны и составляют: {0:f2}", Area1);
            }
            else
            {
                Console.WriteLine("Наибольшая площадь у треугольника № {0}, его площадь составляет: {1:f2}, площадь меньшего треугольника: {2:f2}",
                Area1 > Area2 ? 1 : 2, Area1 > Area2 ? Area1 : Area2, Area1 > Area2 ? Area2 : Area1);
            }            
        }
    }
}
