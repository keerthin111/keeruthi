using System;
using System.Diagnostics;
namespace ConsoleApp12
{
    class BenchmarkAllocation
    {
        const int _max= 100000;
        static void Main(string[]args)
        {
            var Arr2D = new int[100, 100];
            var ArrJagged = new int[100][];
            for(int i=0;i<100;i++)
            {
                ArrJagged[i] = new int[100];
            }

            var stopwatch2D = Stopwatch.StartNew();          
            for(int i=0;i<_max;i++)
            {
              for(int j=0;j<100;j++)
                {
                    for(int k=0;k<100;k++)
                    {
                        Arr2D[j, k] = k;
                    }
                }
            }
            stopwatch2D.Stop();
            var stopwatchJagged = Stopwatch.StartNew();
            for(int i=0;i<_max;i++)
            {
                for(int j=0;j<100;j++)
                {
                    for(int k=0;k<100;k++)
                    {
                        ArrJagged[j][k] = k;
                    }
                }
            }
            stopwatchJagged.Stop();
            Console.Write("\n time taken for allocation in case of 2D array:");
            Console.WriteLine(stopwatch2D.Elapsed.TotalMilliseconds + "milliseconds");
            Console.Write("\n time taken for allocatoin in case of jagged array:");
            Console.WriteLine(stopwatchJagged.Elapsed.TotalMilliseconds + "milliseconds");
        }
       




















    }
}
