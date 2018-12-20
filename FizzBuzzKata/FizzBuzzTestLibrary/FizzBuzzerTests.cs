using System;
using FizzBuzzLibrary;
using NUnit.Framework;

namespace FizzBuzzTestLibrary
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [TestCase]
       public void Buzzer_When1_Returns1()
        {
            int input = 1;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("1", output);
        }


        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(6)]
        public void Buzzer_When2_Returns2(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [TestCase]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }
       
    }
}
