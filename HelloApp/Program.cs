using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            Greeting();
            GreetBlack();
        }

        static void Greeting()
        {
            Console.WriteLine("hello white");
        }

        static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}