using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Box box = new Box();

            box.setHeight(5);
            box.setLength(4);
            box.setWidth(2);

            Console.WriteLine("Volume is {0}", box.getVolume());

        }
    }
}
