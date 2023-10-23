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

namespace aplikacja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

        public partial class MainWindow : Window
        {
        SystemyLiczbowe systemyL = new SystemyLiczbowe();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = systemyL;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wciśnięto menu kopiuj");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            systemyL.zDznaB();
        }
    }
    }

