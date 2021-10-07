using System;
using System.Text;
namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            int a, b, c;
            float D,x1,x2;
            Console.Write("Введіть a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть c: ");
            c = Convert.ToInt32(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D > 1)
            {
                x1 = (float)((-b + Math.Sqrt(D)) / 2 * a);
                x2 = (float)((-b - Math.Sqrt(D)) / 2 * a);
                Console.Write("x1=");
                Console.WriteLine(x1);
                Console.Write("x2=");
                Console.WriteLine(x2);
            }
            else if (D == 0)
            {
                x1 = (float)((-b + Math.Sqrt(D)) / 2 * a);
                Console.Write("x1=");
                Console.WriteLine(x1);
            }
            else {
                Console.WriteLine("Дискримiнант менше нуля");
            }
        }
    }
}
