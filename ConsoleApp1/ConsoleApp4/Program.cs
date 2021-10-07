using System;
using System.Text;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,K, S = 0;
            bool nT = true;
            bool kT = true;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            do
            {
                Console.Write("Введіть N(N>0): ");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                {
                    nT = false;
                }
            } while (nT);
            Console.Write("N=");
            Console.WriteLine(N);
            do
            {
                Console.Write("Введіть K(K>0): ");
                K = Convert.ToInt32(Console.ReadLine());
                if (K > 0)
                {
                    kT = false;
                }
            } while (kT);
            Console.Write("K=");
            Console.WriteLine(K);
            for (int i = 1; i <= N; i++) { 
                S=S+(int)Math.Pow(i,K);
            }
            Console.WriteLine(S);
        }
    }
}
