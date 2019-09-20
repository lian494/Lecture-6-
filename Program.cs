using System;

namespace StarRectangular
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base;

            Console.WriteLine("========================= Star Rectangular =========================\n");


             Console.Write("Enter Base: ");
            Base = Int32.Parse(Console.ReadLine());
        
            for(int i=1;i<=Base;i+=2)
            {
                  for(int k=0;k<(Base-i)/2;k++)
                  {
                     Console.Write(" "); 
                  }
                for(int j=0;j<i;j++)
                {         
                    Console.Write("*");
                }
                Console.WriteLine();
                
                   
            
            }
        }




            
    }
}
