using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary3;
using static ClassLibrary3.ClassLibrary3;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Car car;
        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string> { "light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "light";
        }
  
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
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

    }
}
