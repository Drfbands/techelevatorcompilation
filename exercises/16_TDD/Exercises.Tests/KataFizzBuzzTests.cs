using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
         KataFizzBuzz testObject = new KataFizzBuzz();

        [TestMethod]
        public void OneCase()
        {
          

            Assert.AreEqual("1", testObject.FizzBuzz(1));

        }

        [TestMethod]
        public void ThreeEqualsFizz()
        {
            

            Assert.AreEqual("Fizz", testObject.FizzBuzz(3));
            Assert.AreEqual("Fizz", testObject.FizzBuzz(51));



        }

        [TestMethod]
        public void FiveEqualsBuzz()
        {


            Assert.AreEqual("Buzz", testObject.FizzBuzz(5));
           
        }
        [TestMethod]
        public void FifteenEqualsFizzBuzz()
        {


            Assert.AreEqual("FizzBuzz", testObject.FizzBuzz(15));
            Assert.AreEqual("FizzBuzz", testObject.FizzBuzz(53));
            Assert.AreEqual("FizzBuzz", testObject.FizzBuzz(35));

        }

        [TestMethod]
        public void CheckingInclsusive()
        {


            Assert.AreEqual("22", testObject.FizzBuzz(22));
          

        }


        [TestMethod]
        public void CheckingEmptyZero()
        {


            Assert.AreEqual("", testObject.FizzBuzz(0));

        }

        [TestMethod]
        public void ExclusiveHigh()
        {


            Assert.AreEqual("", testObject.FizzBuzz(105));

        }


        [TestMethod]
        public void ContainsA3()
        {

            Assert.AreEqual("Fizz", testObject.FizzBuzz(13));
           
          
          

        }




    }

}

