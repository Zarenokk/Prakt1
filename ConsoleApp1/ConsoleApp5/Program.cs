using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,lich=0,dot=0,vid=0,par=-1,nePar=0;
            bool nT=true;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            List<int> integerList = new List<int>();
            Console.WriteLine("Введіть числа через ENTER,закінчивши ввід 0(нулем)");
            do {
                N = Convert.ToInt32(Console.ReadLine());
                integerList.Add(N);
                if (N == 0)
                {
                    nT = false;
                }
                lich++;
            } while (nT);
            Console.WriteLine("");
            for (int i = 0; i < lich; i++)
            {
                if (integerList[i] % 2 == 0)
                {
                    par++;
                }
                if (integerList[i] % 2 == 1)
                {
                    nePar++;
                }
                if (integerList[i] > 0)
                {
                    dot++;
                }
                if(integerList[i] < 0) {
                    vid++;
                }
                Console.Write(integerList[i]);
                Console.Write(",");
            }
            Console.WriteLine(" ");
            Console.Write("Парних=");
            Console.WriteLine(par);
            Console.Write("Непарних=");
            Console.WriteLine(nePar);
            Console.Write("Додатніх=");
            Console.WriteLine(dot);
            Console.Write("Від'ємних=");
            Console.WriteLine(vid);
        }
    }
}
