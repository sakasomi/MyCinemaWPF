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
using System.Drawing;
using System.Data;
using System.ComponentModel;



namespace MyWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_film1_Click(object sender, RoutedEventArgs e)
        {
           
            Film1 f2 = new Film1();
            f2.Show();
            this.Close();
        }

        private void button_film2_Click(object sender, RoutedEventArgs e)
        {
            Film2 f2 = new Film2(); 
            f2.Show();
            this.Close();
        }

        private void button_film3_Click(object sender, RoutedEventArgs e)
        {
            Film3 f2 = new Film3();
            f2.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Необходимо выбрать фильм!", "Справка!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
           Enter enter = new Enter();
            enter.Show();
            this.Close();
        }
    }
}
