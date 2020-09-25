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
            lstBewerkingen.Items.Add("Optelling: 29 + 7 = " + (29 + 7));
            lstBewerkingen.Items.Add("Aftrekking: 29 - 7 = " + (29 - 7));
            lstBewerkingen.Items.Add("Vermenigvuldiging: 29 * 7 = " + (29 * 7));
            lstBewerkingen.Items.Add("Deling: 29 / 7 = " + (29F / 7F));
            lstBewerkingen.Items.Add("Modulo : 29 % 7 = " + (29 % 7));
            int getal = 0;
            lstBewerkingen.Items.Add("Waarde van getal: " + getal);
            lstBewerkingen.Items.Add("Verhogen met 1 : ++getal = " + ++getal);
            lstBewerkingen.Items.Add("Verlagen met 1 : --getal = " + --getal);
            lstBewerkingen.Items.Add("2 tot de 3de macht: " + Math.Pow(2, 3));
            lstBewerkingen.Items.Add("De vierkantswortel van 16: " + Math.Sqrt(16));

            int aantalLeerlingen;
            aantalLeerlingen = 10;

            aantalLeerlingen = 10 + 5;

            aantalLeerlingen = aantalLeerlingen + 8;
            aantalLeerlingen = aantalLeerlingen - 2;
            aantalLeerlingen = aantalLeerlingen * 3;
            aantalLeerlingen = aantalLeerlingen / 3;
            aantalLeerlingen = aantalLeerlingen % 4;

            aantalLeerlingen += 8;
            aantalLeerlingen -= 2;
            aantalLeerlingen *= 3;
            aantalLeerlingen /= 3;
            aantalLeerlingen %= 4;

            lstBewerkingen.Items.Add("Aantal leerlingen is: " + aantalLeerlingen);

            string naam = "Kenji";
            string voornaam = "Minogue";
            naam += " " + voornaam;

            lstBewerkingen.Items.Add("De naam is: " + naam);
        }
    }
}
