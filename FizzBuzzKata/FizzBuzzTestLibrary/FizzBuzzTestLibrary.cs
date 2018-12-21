using FizzBuzzLibrary;
using NUnit.Framework;
using System;

namespace FizzBuzzTestLibrary
{
    [TestFixture]
    public class FizzBuzzTestLibrary
    {

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(11)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(16)]
        [TestCase(17)]
        [TestCase(19)]
        
        public void WhenDefault_ReturnInput(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]

        public void WhenDivisibleBy3_ReturnsFizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Buzzer_WhenDiv5_ReturnsBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output); 
        }

        [TestCase(15)]
        
        public void Buzzer_DivisbleBy5_AND_DivsibleBy3_ReturnsFizzBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);


        }

    }
}
