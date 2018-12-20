using System;

namespace FizzBuzzLibrary
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }
            else
            {
                return input.ToString();
            }
            
        }
    }
}
