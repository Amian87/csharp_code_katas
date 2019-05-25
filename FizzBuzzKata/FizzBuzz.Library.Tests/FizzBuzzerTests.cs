using NUnit.Framework;
using System;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(16)]
        [TestCase(17)]
        [TestCase(19)]
        public void Buzzer_WhenDefault_ReturnsInput(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        public void Buzzer_When_Divisble_By_3_Returns_Fizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Buzzer_When5_ReturnsBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }


        [TestCase(15)]
        public void Buzzer_When_Divisble_By_5_And_3_Returns_FizzBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }


    }
}
