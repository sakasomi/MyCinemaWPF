using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MyWPF
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        public Enter()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_enter_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            if ((pwBox.Password == "admin" || tBox.Text == "admin") && login.Text == "admin")
            {

                mainWindow.Show();
                this.Close();

            }
            else
            {

                MessageBox.Show("Вы ввели неправильно логин или пароль", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            
         
            }


        }

        private void chBox_Checked(object sender, RoutedEventArgs e)
        {
           
                pwBox.Visibility = Visibility.Collapsed;
                tBox.Visibility = Visibility.Visible;

                tBox.Text = new NetworkCredential(string.Empty, pwBox.SecurePassword).Password;
                tBox.Focus();

            
         


           
        }

        private void chBox_Unchecked(object sender, RoutedEventArgs e)
        {

           
                pwBox.Visibility = Visibility.Visible;
                tBox.Visibility = Visibility.Collapsed;

                pwBox.Password = tBox.Text;
                pwBox.Focus();
           
            
           
        }
    }
    
}
