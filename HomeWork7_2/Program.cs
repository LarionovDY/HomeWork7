using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7_2
{
    //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста длину стороны куба");
            double side, volume, area;
            side = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Cube(side, out volume, out area);
            Console.WriteLine("Объем куба со стороной {0:f2}:\t{1:f2}\nплощадь поверхности:\t{2:f2}",  side, volume, area);
            Console.ReadKey();
        }
        static void Cube(double cubeSide, out double cubeVolume, out double cubeSurfaceArea) 
        {
            cubeVolume = Math.Pow(cubeSide, 3);
            cubeSurfaceArea = 6 * Math.Pow(cubeSide, 2);
        }
    }
}
