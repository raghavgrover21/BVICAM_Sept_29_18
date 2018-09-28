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
            int i = 0;
            ArrayList ob1 = new ArrayList();
            int buy_in = 0, profit = 0, temp_profit = 0;
            int[] arr = new int[] { 10, 20, 40, 80, 50, 100, 110, 115 };
            //Console.Write("jerre");
            while (i < arr.Length)
            {
                if (buy_in == 0)
                {
                    // Console.WriteLine("go go go");
                    buy_in = arr[i];
                    i++;
                }
                else if (buy_in > 0)
                {
                    temp_profit = arr[i] - buy_in;
                    if (temp_profit > profit)
                    {
                        Console.WriteLine(temp_profit + "compared with" + profit);                       
                        profit = temp_profit;
                        ob1.Add(profit);
                        if (i < arr.Length)
                            i++;
                    }
                    else
                    {

                        buy_in = 0;
                        temp_profit = 0;
                        profit = 0;
                        // i++;
                    }
                }

            }
            Console.WriteLine(profit);
            int max = int.MinValue;

            foreach (int no in ob1)
            {
                Console.WriteLine("haha"+no);
                  if(max<no)
                {
                  max = no;
                }
                 }
                Console.Write(max);
            }


        }

    }

