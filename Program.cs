using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHello("Ralph", 32);
            SayHello("Rick", 28);
            SayHello("Rob", 24);

        }

        static void SayHello(string name, int age) //parameters/arguments
        {
            Console.WriteLine($"Hello {name} you are {age}.");// methods and functions interchangable.
        }







    }
}
