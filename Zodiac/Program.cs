using System;

namespace Zodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthdate in the format 'MMDD'");
            string birthdate = Console.ReadLine();
            int birthdateInt = int.Parse(birthdate);

            if (birthdateInt <= 0119 || birthdateInt >= 1222)
            {
                Console.WriteLine("Capricorn");
            }
            if (birthdateInt <= 0218 && birthdateInt >= 0120)
            {
                Console.WriteLine("Aquarius");
            }
            if (birthdateInt <= 0320 && birthdateInt >= 0219)
            {
                Console.WriteLine("Pisces");
            }
            if (birthdateInt <= 0419 && birthdateInt >= 0321)
            {
                Console.WriteLine("Aries");
            }
            if (birthdateInt <= 0520 && birthdateInt >= 0420)
            {
                Console.WriteLine("Taurus");
            }
            if (birthdateInt <= 0620 && birthdateInt >= 0521)
            {
                Console.WriteLine("Gemini");
            }
            if (birthdateInt <= 0722 && birthdateInt >= 0621)
            {
                Console.WriteLine("Cancer");
            }
            if (birthdateInt <= 0822 && birthdateInt >= 0723)
            {
                Console.WriteLine("Leo");
            }
            if (birthdateInt <= 0922 && birthdateInt >= 0823)
            {
                Console.WriteLine("Virgo");
            }
            if (birthdateInt <= 1022 && birthdateInt >= 0923)
            {
                Console.WriteLine("Libra");
            }
            if (birthdateInt <= 1121 && birthdateInt >= 1023)
            {
                Console.WriteLine("Scorpio");
            }
            if (birthdateInt <= 1221 && birthdateInt >= 1122)
            {
                Console.WriteLine("Saggitarius");
            }

            Console.ReadLine();

        }
    }
}
