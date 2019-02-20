using FizzBuzzerLibrary;
using NUnit.Framework;
using System;

namespace FizzBuzzTestLibrary
{
    [TestFixture]
    public class FizzBuzzTest
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
        public void When_Not_Divisbile_By_3_And_5_Return_Number(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual(input.ToString(), output);
    
        }
        
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        [TestCase(18)]
        public void When_Divisbile_By_3_Return_Fizz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void When_Divisible_By_5_Return_Buzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }

        [TestCase(15)]
        public void When_Divisble_By_5_And_3_Return_FizzBuzz(int input)
        {
            string output = FizzBuzzer.GetValue(input);
            Assert.AreEqual("FizzBuzz", output);
        }

    }
}
