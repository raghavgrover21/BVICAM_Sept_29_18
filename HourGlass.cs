using System;
using System.Collections.Generic;
    namespace New_folder__2_
        // FIND THE MAXIMUM SUM OF EVERY HOURGLASS IN A GIVEN MATRIX
 {                                         
    
    public class Program
    {   
       
        public static void Main()
        {
            int [,] arr = new int[6,6]{{1, 1, 1, 0, 0, 0},{0, 1, 0, 0, 0, 0},{1, 1, 1, 0, 0, 0},{0, 0, 2, 4, 4, 0},{0, 0, 0, 2, 0, 0},{0, 0, 1, 2, 4, 0}};
         
        int sum=0,finalsum=-9999;
       int start = arr.GetLength(0);
       int end = arr.GetLength(1);
       start=start-1;
       end=end-1;
       // Console.WriteLine(start+"yup"+end);
       for(int i=0;i<=start;i++)
       {
        //    Console.WriteLine("here1");
         //  if(i+2>start)
           //break;
           
                for(int j=0;j<=end;j++)
                {
                    //Console.Write(arr[i,j]);

                     if(j+2>end || i+2>start)
                     {
                       //Console.WriteLine("here3");
                    break;
                   }
                    
                   else
                   { 
                   sum=arr[i,j] +arr[i,j+1]+ arr[i,j+2]+ arr[i+1,j+1]+ arr[i+2,j]+ arr[i+2,j+1]+ arr[i+2,j+2]; 
                  //  sum=arr[i][j] +arr[i][j+1]+ arr[i][j+2]+ arr[i+1][j+1]+ arr[i+2][j]+ arr[i+2][j+1]+ arr[i+2][j+2]; 
                       if(finalsum<sum)
                       {
                           Console.WriteLine(sum);
                           finalsum=sum;}     
                    }
                    Console.WriteLine(finalsum);
               
                }
            
       
        }
       Console.WriteLine(finalsum);
                       
        }
          
        }
}



