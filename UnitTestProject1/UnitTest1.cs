using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.ConstrainedExecution;
using WindowsFormsApp;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PassTechInspection_YearGreaterOrEqual_ReturnsZero()
        {
            // Arrange
            var car = new Car("Toyota", "Camry", 2020, 2022, "John");
            int year = 2022;

            // Act
            int result = car.PassTechInspection(year);

            // Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(year, car.NextTechInspectionYear);
        }

        [TestMethod]
        public void PassTechInspection_YearLess_ReturnsMinusOne()
        {
            // Arrange
            var car = new Car("Toyota", "Camry", 2020, 2022, "John");
            int year = 2021;

            // Act
            int result = car.PassTechInspection(year);

            // Assert
            Assert.AreEqual(-1, result);
            Assert.AreEqual(2022, car.NextTechInspectionYear);
        }

        [TestMethod]
        public void TestIssueFine_AddsFineAmount()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            decimal fineAmount = 1000;
            decimal expectedFine = car.Fine + fineAmount;

            // Act
            car.IssueFine(fineAmount);

            // Assert
            Assert.AreEqual(expectedFine, car.Fine);
        }

        [TestMethod]
        public void IssueFine_AmountLessThanZero_ThrowsException()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            decimal amount = -100;

            // Assert
            Assert.ThrowsException<Exception>(() => car.IssueFine(amount));
        }

        [TestMethod]
        public void IssueFine_AmountGreaterThanZero_IncreasesFineAmount()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            decimal amount = 100;

            // Act
            car.IssueFine(amount);

            // Assert
            Assert.AreEqual(amount, car.Fine);
        }

        [TestMethod]
        public void SellCar_NewOwnerNotEqualToMinusOne_ChangesOwner()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            string newOwner = "David";

            // Act
            car.SellCar(newOwner);

            // Assert
            Assert.AreEqual(newOwner, car.Owner);
        }

        [TestMethod]
        public void SellCar_NewOwnerEqualToMinusOne_ChangesOwnerToUtilized()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            string newOwner = "-1";

            // Act
            car.SellCar(newOwner);

            // Assert
            Assert.AreNotEqual("-1", car.Owner);
            Assert.AreEqual("Утилизирован", car.Owner);
        }

        [TestMethod]
        public void GetCarInfo_ReturnsCarInformation()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            string expected = "2015 Toyota Camry, Владелец: John, сумма штрафа: 0, след. год тех. осмотра: 2022";

            // Act
            string result = car.GetCarInfo();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetOwner_ReturnsOwnerName()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            string expected = "John";

            // Act
            string result = car.GetOwner();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void PayFine_AmountLessThanZero_ThrowsException()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            decimal amount = -100;

            // Assert
            Assert.ThrowsException<Exception>(() => car.PayFine(amount));
        }

        [TestMethod]
        public void PayFine_AmountGreaterThanZero_DecreasesFineAmount()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            car.IssueFine(100);
            decimal amount = 50;
            decimal expectedFine = car.Fine - amount;

            // Act
            decimal result = car.PayFine(amount);

            // Assert
            Assert.AreEqual(expectedFine, result);
            Assert.AreEqual(expectedFine, car.Fine);
        }

        [TestMethod]
        public void PayFine_FineAmountLessThanZero_FineIsZero()
        {
            // Arrange
            Car car = new Car("Toyota", "Camry", 2015, 2022, "John");
            car.IssueFine(100);
            decimal amount = 200;

            // Act
            decimal result = car.PayFine(amount);

            // Assert
            Assert.AreEqual(0, result);
            Assert.AreEqual(0, car.Fine);
        }
    }
}
