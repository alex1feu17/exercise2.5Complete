using System;

namespace exercise2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 9, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            int total=0;
            
            for (int i = 0; i< 14; i++)
            {
                    total=total+tableau[i+1];

                 if(i==14)
                 {
                   total=total+tableau[i];
                 }

             }
            Console.WriteLine(total.ToString());
         }
    }

}
        
    

