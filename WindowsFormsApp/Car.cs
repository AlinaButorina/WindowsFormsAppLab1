using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class Car
    {
        public string CarBrand { get; private set; }
        public string CarModel { get; private set; }
        public int Year { get; private set; }
        public int NextTechInspectionYear { get; private set; }
        public string Owner { get; private set; }
        public decimal Fine { get; private set; }

        public Car(string carBrand, string carModel, int year, int nextTechInspectionYear, string owner)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            Year = year;
            NextTechInspectionYear = nextTechInspectionYear;
            Owner = owner;
            Fine = 0;
        }

        public int PassTechInspection(int year)
        {
            if (year >= NextTechInspectionYear)
            {
                NextTechInspectionYear = year;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public void IssueFine(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Отрицательная сумма для штрафа");
            }
            Fine += amount;
        }

        public void SellCar(string newOwner)
        {
            if (newOwner != "-1")
            {
                Owner = newOwner;
            }
            else
            {
                Owner = "Утилизирован";
            }
        }

        public string GetCarInfo()
        {
            return $"{Year} {CarBrand} {CarModel}, Владелец: {Owner}, сумма штрафа: {Fine}, след. год тех. осмотра: {NextTechInspectionYear}";
        }

        public string GetOwner()
        {
            return Owner;
        }

        public decimal PayFine(decimal amount)
        {
            if (amount < 0)
            {
                throw new Exception("Отрицательная сумма для погашения штрафа.");
            }
            Fine -= amount;
            if (Fine < 0)
            {
                Fine = 0;
            }
            return Fine;
        }
    }
}
