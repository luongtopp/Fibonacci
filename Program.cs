using System;
namespace Fibonacci {
    class Program
    {
        public static int RabbitPair(int n)
        {
            if(n == 1 || n == 2) {
                
                return 1;
            }
           return RabbitPair(n-1) + RabbitPair(n-2);


        }

        
        public static void Main(string[] args)
        {

            Console.WriteLine($"Rabbit {RabbitPair(10)} cap");



        }
    }
}