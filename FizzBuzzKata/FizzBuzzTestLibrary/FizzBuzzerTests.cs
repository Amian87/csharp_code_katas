using System;
using FizzBuzzLibrary;
using NUnit.Framework;

namespace FizzBuzzTestLibrary
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void Buzzer_WhenDefault_ReturnsInput(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [TestCase(3)]
        [TestCase(6)]
        public void Buzzer_When3_ReturnsFizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestCase]
        public void Buzzer_When5_ReturnsBuzz()
        {
            int input = 5;
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }
       
    }
}
