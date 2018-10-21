using System;
using System.Collections.Generic;
    namespace New_folder__2_
     
     //Check if a given number is armstrong or not
 {                                         
    
    public class Program
    {     
        public static void Main()
        {
            int num=5;
            Program ob1 = new Program();
            int res= ob1.Factorial(num);
            Console.WriteLine(res);
            

        }
    
        int Factorial(int num)
        {  
            if(num==1)
                return 1;

            else
                return Factorial(num-1)*num;
        }
    } 
}
 

