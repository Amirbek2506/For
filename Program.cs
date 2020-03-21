using System;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,S=0;
            Console.Write("N= ");
            N=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=N;i++)
            {
                Console.WriteLine(i);
            S+=i;
        
            }
                     Console.WriteLine("Summ={0}",S);
        }
    }
}
