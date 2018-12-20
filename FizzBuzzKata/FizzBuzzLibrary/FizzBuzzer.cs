using System;

namespace FizzBuzzLibrary
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input % 3 == 0)
            {
                return "Fizz";
            }

            if (input == 5)
            {
                return "Buzz";
            }


            else
            {
                return input.ToString();
            }
            
        }
    }
}
