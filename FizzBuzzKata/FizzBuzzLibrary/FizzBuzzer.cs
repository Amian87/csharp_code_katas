﻿using System;


namespace FizzBuzzLibrary
{

    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {

            string output = String.Empty;
            if (input % 3 == 0)
            {
                output += "Fizz";
            }
            if (input % 5 == 0)
            {
                output += "Buzz";
            }
            if(string.IsNullOrEmpty(output))
            {
                output = input.ToString();
            }
            return output;
        }
        
    }
}
