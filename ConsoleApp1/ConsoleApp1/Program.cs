using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.Write("Введіть х: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            float s;
            s = (float)((float)Math.Abs(Math.Pow(x, y / x)-Math.Pow(y/x,1/3))+(y-x)*(Math.Cos(y)-z/(y-x))/1+Math.Pow(y-x,2));
            s= (float)Math.Round(s, 3);
            Console.WriteLine($"Результат = {s}");
        }
    }
}
