using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        delegate double TestDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус:");
            double r = Convert.ToInt32(Console.ReadLine());
            TestDelegate testDelegate = new TestDelegate(Circumference);
            Console.WriteLine($"Длина окружности = { testDelegate?.Invoke(r)}");
            testDelegate = CircArea;
            //testDelegate -=CircArea;
            Console.WriteLine($"Площадь круга = { testDelegate?.Invoke(r)}");
            testDelegate = SphereVolume;
            Console.WriteLine($"Объем шара = { testDelegate?.Invoke(r)}");
            //Console.WriteLine(testDelegate?.Invoke(r)); 

            Console.ReadKey();


        }

        static double Circumference(double r)
        {
            return 2 * Math.PI * r;
        }
        static double CircArea(double r) => Math.PI * r * r;
        static double SphereVolume(double r) => (4.0 / 3 * Math.PI * r * r * r);


    }


}
