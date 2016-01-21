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
namespace WpfApp.age.calculator
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Console.WriteLine("Item cost: ");
            //string cost = Console.ReadLine();
            string cost = tbc.Text;

            decimal totalCost = decimal.Parse(cost);



            Console.WriteLine("Money from customer: ");
            //string money = Console.ReadLine();
            string money = tbm.Text;

            decimal receivedMoney = decimal.Parse(money);



            decimal change = receivedMoney - totalCost;



            decimal quarters = change / 0.25m;
            decimal myQuarters = Math.Floor(quarters);

            decimal dimes = (change % 0.25m) / 0.1m;
            decimal myDimes = Math.Floor(dimes);

            decimal nickels = ((change % 0.25m) % 0.1m) / 0.05m;
            decimal myNickels = Math.Floor(nickels);

            decimal pennies = (((change % 0.25m) % 0.1m) % 0.05m) / 0.01m;
            decimal myPennies = Math.Floor(pennies);



            tbc1.Text = change.ToString();
            tbq.Text = myQuarters.ToString();
            tbd.Text = myDimes.ToString();
            tbn.Text = myNickels.ToString();
            tbp.Text = myPennies.ToString();

            //Console.ReadLine();


        }

    }
    }

