using System;
using System.Collections.Generic;
    namespace New_folder__2_
     
     //Check if a given number is armstrong or not
 {                                         
    
    public class Program
    {     
        public static void Main()
        {
            int n=371;
            Program ob1= new Program();
            
            bool res=ob1.Armstrong(n);
          
            if(res==true)
            Console.WriteLine("Armstrong");

            else
            Console.WriteLine("not Armstrong");
        }
    
        bool Armstrong(int No1)
        {   
            int no1=No1;
            int mod=0;
            int sum=0;
            int temp;
            
            while(no1>0)
            {
                mod = no1 % 10;
                temp =(int)Math.Pow(mod,3);         //can also use mod*mod*mod;
                sum = sum + temp;
                no1 = no1/10;
            }
            Console.WriteLine(sum);
            Console.WriteLine(No1);
            return sum==No1 ? true : false;

        }
    } 
}
 

