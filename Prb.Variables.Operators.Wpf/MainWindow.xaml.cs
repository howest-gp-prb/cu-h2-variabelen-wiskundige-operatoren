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

namespace Prb.WiskOperatoren.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstOperations.Items.Add("Optelling: 29 + 7 = " + (29 + 7));
            lstOperations.Items.Add("Aftrekking: 29 - 7 = " + (29 - 7));
            lstOperations.Items.Add("Vermenigvuldiging: 29 * 7 = " + (29 * 7));
            lstOperations.Items.Add("Deling: 29 / 7 = " + (29F / 7F));
            lstOperations.Items.Add("Modulo : 29 % 7 = " + (29 % 7));

            int number = 0;
            lstOperations.Items.Add("Waarde van getal: " + number);
            lstOperations.Items.Add("Verhogen met 1 : ++getal = " + ++number);
            lstOperations.Items.Add("Verlagen met 1 : --getal = " + --number);
            lstOperations.Items.Add("2 tot de 3de macht: " + Math.Pow(2, 3));
            lstOperations.Items.Add("De vierkantswortel van 16: " + Math.Sqrt(16));

            int numberOfStudents;
            numberOfStudents = 10;

            numberOfStudents = 10 + 5;

            numberOfStudents = numberOfStudents + 8;
            numberOfStudents = numberOfStudents - 2;
            numberOfStudents = numberOfStudents * 3;
            numberOfStudents = numberOfStudents / 3;
            numberOfStudents = numberOfStudents % 4;

            numberOfStudents += 8;
            numberOfStudents -= 2;
            numberOfStudents *= 3;
            numberOfStudents /= 3;
            numberOfStudents %= 4;

            lstOperations.Items.Add("Aantal leerlingen is: " + numberOfStudents);

            string name = "Kenji";
            string lastName = "Minogue";
            name += " " + lastName;

            lstOperations.Items.Add("De naam is: " + name);
        }
    }
}
