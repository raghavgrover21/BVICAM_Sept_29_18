using System;
using System.Collections.Generic;
    namespace New_folder__2_
       //FIBONACCI PROGRAM ITERATIVE
 {                                         
    
    public class Program
    {     
        public static void Main()
        {
            int check=200;
            int n1=0,n2=1;
            int n3=0;
            for(int i=0;i<check;i++)
            {    
                if(check==0 || check==1)
                    {
                        Console.WriteLine("fibonacci number");
                    }
                else if(n3==check)
                {
                    Console.WriteLine("fibonacci number");
                    break;
                }
                else if(n3<check)
                {
                    n3=n2+n1;
                    n1=n2;
                    n2=n3;
                }
                else
                {Console.WriteLine("Not a part of fibonacci series");
                break;
                }
            }

        }
        
    }
}



