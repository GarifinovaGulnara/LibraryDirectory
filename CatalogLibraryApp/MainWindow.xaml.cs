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

namespace CatalogLibraryApp
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

        private void Button_Click(object sender, RoutedEventArgs e) //Pazzle
        {
            Window form2 = new Window();
            form2.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //TableGame
        {
            Window form3 = new Window();
            form3.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Book
        {
            Window form4 = new Window();
            form4.Show();
        }
    }
}
