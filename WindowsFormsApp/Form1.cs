using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Car car;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCreateCar_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = carBrand.Text;
                string model = carModel.Text;
                int year = int.Parse(carYear.Text);
                int inspectionYear = int.Parse(carInspectionYear.Text);
                string owner = carOwner.Text;

                car = new Car(brand, model, year, inspectionYear, owner);

                MessageBox.Show("Автомобиль создан.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnPassTechInspection_Click(object sender, EventArgs e)
        {
            if (car == null)
            {
                MessageBox.Show("Cначала создайте автомобиль.");
                return;
            }

            try
            {
                int year = int.Parse(newYeartTech.Text);
                int result = car.PassTechInspection(year);

                if (result == 0)
                {
                    MessageBox.Show("Техосмотр пройден.");
                }
                else
                {
                    MessageBox.Show("Техосмотр не пройден.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка: Введены некорректные данные. " + ex.Message);
            }
        }

        private void btnIssueFine_Click(object sender, EventArgs e)
        {
            if (car == null)
            {
                MessageBox.Show("Cначала создайте автомобиль.");
                return;
            }

            try
            {
                decimal amount = decimal.Parse(carIssueFine.Text);
                car.IssueFine(amount);
                MessageBox.Show("Штраф выписан.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnSellCar_Click(object sender, EventArgs e)
        {
            if (car == null)
            {
                MessageBox.Show("Cначала создайте автомобиль.");
                return;
            }

            string newOwner = carNewOwner.Text;
            car.SellCar(newOwner);
            MessageBox.Show("Автомобиль продан или утилизирован.");
        }

        private void btnGetCarInfo_Click(object sender, EventArgs e)
        {
            if (car == null)
            {
                MessageBox.Show("Cначала создайте автомобиль.");
                return;
            }

            string carInfo = car.GetCarInfo();
            MessageBox.Show(carInfo);
        }

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            if (car == null)
            {
                MessageBox.Show("Cначала создайте автомобиль.");
                return;
            }

            try
            {
                decimal amount = decimal.Parse(amountIssuePay.Text);
                decimal remainderOfFine = car.PayFine(amount);
                MessageBox.Show($"Штраф оплачен . Остаток по штрафам: {remainderOfFine}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void btnGetOwnerInfo_Click(object sender, EventArgs e)
        {
            if (car == null)
            {
                MessageBox.Show("Cначала создайте автомобиль.");
                return;
            }
            MessageBox.Show($"Владелец: {car.GetOwner()}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
