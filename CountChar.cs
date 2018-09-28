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

            char[] arr = new char[] { 'a', 'a', 'a', 'a', 'a', 'a', 'b', 'b', 'b', 'b', 'b', 'c', 'c', 'c', 'c', 'c','d' };
            int count=1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("ok" + i);
                
                if (i+1<arr.Length && arr[i] == arr[i + 1] )
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(arr[i] + "   count"+count);
                    count = 0;
                    count++;
                }
            }
            

        }

    }
}
