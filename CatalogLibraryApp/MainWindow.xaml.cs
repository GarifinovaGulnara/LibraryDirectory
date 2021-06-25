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
    public partial class TaskWindow : Window
    {
        public string ViewModel { get; set; }

        public TaskWindow()
        {
            //InitializeComponent();
        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Pazzle
        {
            var Pazzle = new Window1();
            Pazzle.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //TableGame
        {
            Window TableGame = new Window();
            TableGame.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Book
        {
            Window form4 = new Window();
            form4.Show();
        }
    }
}
