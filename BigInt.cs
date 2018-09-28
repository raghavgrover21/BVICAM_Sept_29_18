using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Numerics;
namespace ConsoleApp1
{

    class Program
    {


        static void Main(string[] args)
        {

            BigInteger ob1 =  BigInteger.Pow(2,5000); //BigInteger is a structure 

            string num = ob1.ToString();
            int sum = 0;
            Console.WriteLine(num);
            for(int i=0; i<num.Length;i++)
            {
                sum = sum + num[i];
            }

            Console.WriteLine("Result is"+sum);

        }

    }
}
