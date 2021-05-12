using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Options");
            Console.WriteLine("- l  = lower case letter");
            Console.WriteLine("- L  = upper case letter");
            Console.WriteLine("- d  = digit");
            Console.WriteLine("- s  = special character ( !#¤%&/(){}[] )");

            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("Min. 1 lower case");
            Console.WriteLine("Min. 1 upper case");
            Console.WriteLine("Min. 2 special characters");
            Console.WriteLine("Min. 2 digits");
            Console.ReadLine();
        }
    }
}
