using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Collatz
{
    class Program
    {
        int i;
        Stopwatch sw;
        static void Main(string[] args)
        {
            Program p = new Program();
        }

        Program()
        {
            sw = new Stopwatch();        
            sw.Start();
            for (int k = 0; k < 10; k++)
            {
                for (int j = 1; j < 100000; j++)
                {
                    i = j;
                    while (i != 1)
                    {
                        if ((i & 1) != 0)
                        {
                            i = ((3*i) + 1) >> 1;
                        }
                        else if ((i & 1) == 0)
                        {
                            i = i >> 1;
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                }
            }
            sw.Stop();
            
            double ticks = sw.ElapsedTicks;
            double milliseconds = (ticks / Stopwatch.Frequency) * 1000;
            Console.WriteLine("Time: " + milliseconds/10);
            Console.Read();
        }
    }
}
