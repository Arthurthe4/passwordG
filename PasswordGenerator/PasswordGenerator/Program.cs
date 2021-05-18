using System;

namespace PasswordGenerator
{
    class Program
    {
        static readonly Random Random = new Random();

        static void Main(string[] args)
        {
            if (!IsValid(args))
            {
                ShowHelpText();
                return;
            }
            var length = Convert.ToInt32(args[0]);
            var options = args[1];

            var pattern = options.PadRight(length, 'l');
            var password = string.Empty;
            while (pattern.Length > 0)
            {
                var randomIndex = Random.Next(0, pattern.Length - 1);
                var category = pattern[randomIndex];

                pattern = pattern.Remove(randomIndex, 1);
                if (category == 'l') password += GetRandomLowerCaseLetter();
                else if (category == 'L') password += GetRandomUpperCaseLetter();
                else if (category == 'd') password += GetRandomDigit();
                else password += GetRandomSpecialCharacter();
            }
            Console.WriteLine(password);
        }

        private static bool IsValid(string[] args)
        {
            if (args.Length != 2) return false;


            var lengthStr = args[0];
            var options = args[1];

            foreach (var character in options)
            {
                if (character != 'l' 
                    && character != 'L' 
                    && character != 'd' 
                    && character != 's')
                {
                    return false;
                }
            }

            foreach (var character in lengthStr)
            {
                if (!char.IsDigit(character)) return false;

            }
            return true;
        }

        private static void ShowHelpText()
        {
            Console.WriteLine("PasswordGenerator <length> <options>");
            Console.WriteLine("  Options:");
            Console.WriteLine("  - l = lower case letter");
            Console.WriteLine("  - L = upper case letter");
            Console.WriteLine("  - d = digit");
            Console.WriteLine("  - s = special character (!\"#¤%&/(){}[])");
            Console.WriteLine("Example: PasswordGenerator 14 lLssdd");
            Console.WriteLine("     Min. 1 lower case");
            Console.WriteLine("     Min. 1 upper case");
            Console.WriteLine("     Min. 2 special characters");
            Console.WriteLine("     Min. 2 digits");
        }
    }
}
