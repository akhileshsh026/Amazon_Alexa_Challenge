using System;
using System.Collections.Generic;

namespace Amazon_Alexa_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, n, k, Devloped  = 0, UnDevloped  = 0, min = 1001, a, b;
            t=Convert.ToInt32(Console.ReadLine());
            for ( int i1 = 0; i1 < t; i1++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                k = Convert.ToInt32(Console.ReadLine());
                for (int j2 = 0; j2 < n; j2++)
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    if (a == 0)
                        UnDevloped += b;
                    else
                    {
                        if (min > b)
                            min = b;
                        Devloped  += b;
                    }
                }
                if (min == 1001)
                    min = 0;
                else
                    Devloped  -= min;
                //printf("%d %d\n", Devloped  + UnDevloped , min);
                Console.WriteLine("{0} {1}",Devloped + UnDevloped ,min);
            }



        }
    }
}