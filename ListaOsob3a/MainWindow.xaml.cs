using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ListaOsob3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {
        public ObservableCollection<Osoba> ListaOsob { get; set; }
        public Osoba WybranaOsoba { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            ListaOsob = new ObservableCollection<Osoba>();
            ListaOsob.Add(new Osoba("Jaś", "Gruszka", 12, "Zabrze"));
            ListaOsob.Add(new Osoba("Gosia", "Śliwka", 12, "Zabrze"));
            ListaOsob.Add(new Osoba("Zosia", "Malina", 12, "Zabrze"));
            ListaOsob.Add(new Osoba("Ela", "Czereśnia", 12, "Zabrze"));
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Czy na pewno chcesz usunąć " + WybranaOsoba);
        }
    }
}
