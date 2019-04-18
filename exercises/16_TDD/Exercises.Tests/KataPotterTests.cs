using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        private KataPotter testObject = new KataPotter();

        [TestMethod]
        public void GetCostOf0BooksEntered()
        {
            //Arrange 
            List<int> input = new List<int>() {0,0,0,0,0 };
            decimal output = 0.0m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }

        [TestMethod]
        public void GetCostListnotnull()
        {
            //Arrange 
            List<int> input = null;
            decimal output = 0.0m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }
        [TestMethod]
        public void GetCostOneBook()
        {
            //Arrange 
            List<int> input = new List<int>{ 1, 0, 0, 0, 0 } ;
            decimal output = 8.0m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }

        [TestMethod]
        public void GetTwoOfTheSameBooks()
        {
            //Arrange 
            List<int> input = new List<int> { 2, 0, 0, 0, 0 };
            decimal output = 16.0m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }

        [TestMethod]
        public void GetTwoDifferentBooksInTheSameClass()
        {
            //Arrange 
            List<int> input = new List<int> { 1, 1, 0, 0, 0 };
            decimal output = 16.0m * 0.05m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }
        [TestMethod]
        public void GetThreeDifferentBooksInTheSameClass()
        {
            //Arrange 
            List<int> input = new List<int> { 1, 1, 1, 0, 0 };
            decimal output = 24.0m * 0.10m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }

        [TestMethod]
        public void GetfourDifferentBooksInTheSameClass()
        {
            //Arrange 
            List<int> input = new List<int> { 1, 1, 1, 1, 0 };
            decimal output = 32.0m * 0.20m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }
        [TestMethod]
        public void GetfiveDifferentBooksInTheSameClass()
        {
            //Arrange 
            List<int> input = new List<int> { 1, 1, 1, 1, 1 };
            decimal output = 40.0m * 0.25m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }
        [TestMethod]
        public void MultipleBooksInTheSameSet()
        {
            //Arrange 
            List<int> input = new List<int> { 2, 2, 1, 1, 1 };
            decimal output = (40 * 0.25m) + 16.0m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }
        [TestMethod]
        public void MultipleBooksInTheSameSetTwo()
        {
            //Arrange 
            List<int> input = new List<int> { 2, 2, 3, 1, 1 };
            decimal output = (40 * 0.25m) + 32.0m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }

        [TestMethod]
        public void MultipleBookstwosets()
        {
            //Arrange 
            List<int> input = new List<int> { 4, 3, 0, 0, 0 };
            decimal output = (16 * 0.05m) + 40.0m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }

        [TestMethod]
        public void FiveByThreeToFourByFour()
        {
            //Arrange 
            List<int> input = new List<int> { 2, 2, 2, 1, 1 };
            decimal output = 51.20m;

            //act Assert
            Assert.AreEqual(output, testObject.GetCost(input));


        }



    }
}
