using System;
using System.Collections.Generic;
    namespace New_folder__2_
       //FIBONACCI PROGRAM RECURSIVE
 {                                         
    
    public class Program
    {     
        public static void Main()
        {
            Program ob1 = new Program();
            int res=ob1.fibo(4);
            Console.WriteLine(res);

        }
        int fibo(int n)
        {
            if(n<=1)
                return n;

            else 
            return fibo(n-1)+fibo(n-2);
        }
    }
}



