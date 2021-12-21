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
            if (WybranaOsoba != null)
            {
                var zgoda = MessageBox.Show("Czy na pewno chcesz usunąć " + WybranaOsoba, "usuwanie", MessageBoxButton.YesNo);
                if (zgoda == MessageBoxResult.Yes)
                {
                    ListaOsob.Remove(WybranaOsoba);
                }
            }
            else
            {
                MessageBox.Show("wybierz osobę z listy");
            }
        }

        private void Button_Click_Dodaj(object sender, RoutedEventArgs e)
        {
            if (imietxt.Text != null && wiektxt.Text != null)//nie działa sprawdzanie formularza
            {
                var imie = imietxt.Text;
                var nazwisko = nazwiskotxt.Text;
                int wiek;
                if (!int.TryParse(wiektxt.Text, out wiek))
                {
                    wiek = 0;
                }
                var miasto = miastotxt.Text;
                Osoba osoba = new Osoba(imie, nazwisko, wiek, miasto);
                ListaOsob.Add(osoba);
            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Osoba osoba = listView.SelectedItem as Osoba;
            formularz.DataContext = osoba;
        }

        private void Button_Click_Modyfikuj(object sender, RoutedEventArgs e)
        {
            var imie = imietxt.Text;
            var nazwisko = nazwiskotxt.Text;
            int wiek;
            if(!int.TryParse(wiektxt.Text,out wiek))
            {
                wiek = 0;
            }
            var miasto = miastotxt.Text;
            Osoba osoba = new Osoba(imie, nazwisko, wiek, miasto);
            ListaOsob.Add(osoba);
            ListaOsob.Remove(WybranaOsoba);
        }
    }
}
