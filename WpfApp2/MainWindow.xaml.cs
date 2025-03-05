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

namespace WpfApp2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        List<string> lista = new List<string>() {
            "első","második","harmadik"
        };
        List<string> lista2 = new List<string>() {
            "asdfasd","hhdfhfgh","xcvbxcvbcv"
        };
        Dictionary<string, int> szotar1 = new Dictionary<string, int>() {
            {"asdfasd",     1 },
            {"hhdfhfgh",    2 },
            {"xcvbxcvbcv",  3 }
        };
        //Dictionary<string, string> angolSzotar = new Dictionary<string, string>() {
        //    {"én", "I" },
        //    {"te", "you" },
        //    {"ő",  "he" }
        //};
        public MainWindow() {
            InitializeComponent();
            listbox1.ItemsSource = lista;
            combobox1.ItemsSource = szotar1.Keys;
            //listbox1.Items.Add("negyedik");
            //combobox1.Items.Add("negyedik");
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            var eredmeny = (checkbox1.IsChecked == true) ? int.Parse(textbox1.Text) * 3 : int.Parse(textbox1.Text) * 2;
            label1.Content = eredmeny;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            label1.Content = listbox1.SelectedItem;
        }

        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            label1.Content = sender.ToString();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e) {
            label1.Content = sender.ToString();
        }
    }
}
