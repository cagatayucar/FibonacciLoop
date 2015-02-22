using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLoop
{
    class Program
    {
        public static double fiboLoop(int fib)
        {
            double x = 0;
            double y = 1;

            for (double i = 0; i < fib; i++)
            {
                double z = x;
                x = y;
                y = z + y;
                // z geçici bir değer
            }
            return x;
        }
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();

            Console.WriteLine("Bulunmasini istediginiz fibonacci degerini giriniz:  ");
            int fib = Int32.Parse(Console.ReadLine());
            st.Start();
            Console.WriteLine(fib + ". fibonacci sayisinin degeri : " + fiboLoop(fib));
            st.Stop();
            TimeSpan ts = st.Elapsed;
            string time = String.Format("{0}:{1}:{2}.{3}", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 1000000);
            Console.WriteLine("Bulma suresi : " + time);
            Console.ReadLine();

        }
    }
}
