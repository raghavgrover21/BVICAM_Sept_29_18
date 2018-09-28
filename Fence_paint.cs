using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    { 


        static void Main(string[] args)
        {
            int k=2, N=10;
            int same = 0, diff = k;
            int total = 0;
            
            for(int i=1;i<=N;i++)
            {
                if(i==1)
                {
                    diff = k;
                    total = k;
                }
                else
                {
                    same = diff;
                    diff = total * (k - 1);
                    total = same + diff;

                }
                Console.WriteLine("total:" + total+"\n different "+diff);


            }

            

        }

    }
}
