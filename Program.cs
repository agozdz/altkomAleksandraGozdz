using System;

namespace altkomAleksandraGozdz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Hello World!");
            for(int i = 0; i < 10; i++) {
                Console.WriteLine(random.Next(100, 999));
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
