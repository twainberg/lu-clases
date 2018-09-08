using NUnit.Framework;
using calculadoracomponent;
using System;

namespace Tests
{
    public class calculadoratest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(15, 15, 30)]
        [TestCase(1, 1, 2)]
        [TestCase(2, 3, 5)]
        public void Add_CorrectValues_ResultOk(int var1, int var2, int exp)
        {
            //Arrange
            int valor1 = var1;

            int valor2 = var2;

            int expected = exp;

            calculadora _calculator = new calculadora();

            //Act
            int result = _calculator.Add(valor1, valor2);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(1, null, 1)]
        [TestCase(null, 1, 1)]
        [TestCase(null, 1, 0)]
        public void Add_NullOrEmpty_Throw(int? var1, int? var2, int exp)
        {
            //Arrange
            int? valor1 = var1;

            int? valor2 = var2;

            int expected = exp;

            calculadora _calculator = new calculadora();

            //Act
            //int result = _calculator.Add(valor1, valor2);

            //Assert
            Assert.Throws<NullReferenceException>(()=>{_calculator.Add(valor1, valor2);});
        }
    }
}