using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.printName();
        }

        public void printName()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
