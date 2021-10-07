using System;
using System.Text;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,y,S=0;
            bool nT=true;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            do
            {
                Console.Write("Введіть N(n>0): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0) {
                    nT = false;
                }
            } while (nT);
            y = n;
            for (int i = 1; i <= n; i++) {
                S =S+Convert.ToInt32(Math.Pow(i, y));
                y--;
            }
            Console.WriteLine(S);
        }
    }
}
