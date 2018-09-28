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
            char[] arr = new char[] { 'a', 'b', 'c', '1', '2', 'x', 'y', 'z', '4' };
            Stack ob1 = new Stack();
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
                if (arr[i] >= '0' && arr[i] <= '9')
                {
                    continue;
                }
                else
                    ob1.Push(arr[i]);
                   
                
            }
            for(int i=0;i<arr.Length;i++)
            {
                if ((arr[i] >= 'A' && arr[i] <= 'Z') || (arr[i] >= 'a' && arr[i] <= 'z'))
                {
                    char ele = (char)ob1.Peek();
                    arr[i] = ele;
                    ob1.Pop();

                    
                }
                //else if (arr[i] >= 'a' && arr[i] <= 'z')
                //{
                //    char ele = (char)ob1.Peek();
                //    arr[i] = ele;
                //    ob1.Pop();

                //}
            }
            Console.WriteLine("comapred");
            for(int i=0; i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }


        }

    }
}
