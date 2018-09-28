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
            // int[] arr = new int[] {4,-1,2,-2,3,-2,5 };
            int[] arr = new int[] { 5, -2, 3, -2, 2, -1, 4 };
            int sum_sub1=0, sum_sub2=0;
            int mid = arr.Length / 2;
            int i=0, j=arr.Length-1;
            while(i+1<j)
            {
                sum_sub1 = arr[i] + sum_sub1;
                sum_sub2 = arr[j] + sum_sub2;
                i++;j--;
            }
            Console.WriteLine(sum_sub1 + "   " + sum_sub2);
            
            while(sum_sub1!=sum_sub2)
            {
                Console.WriteLine("here");
                if(sum_sub1<sum_sub2)
                {
                    Console.WriteLine("here1");
                    sum_sub1 = sum_sub1 + arr[mid];
                    mid++;
                    sum_sub2 = sum_sub2 - arr[mid];
                    Console.WriteLine(sum_sub1 + "   " + sum_sub2);
                }
               
                else if(mid==1 || mid==arr.Length)
                {
                    Console.WriteLine("not found");
                    break;
                }
                else
                {
                    sum_sub2 = sum_sub2 + arr[mid];
                    mid--;
                    sum_sub1 = sum_sub1 - arr[mid];
                }


            }
            Console.WriteLine("here2");
            Console.WriteLine("index of equilibrium" + mid);


        }

    }
}
