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
using System.Windows.Shapes;

namespace MyWPF
{
    /// <summary>
    /// Логика взаимодействия для Film1.xaml
    /// </summary>
    public partial class Film3 : Window
    {


        string[] day =
        {    "1 апреля ",
             "2 апреля ",
             "3 апреля ",
             "4 апреля ",
             "5 апреля ",
             "6 апреля ",
             "7 апреля ",
             "8 апреля ",
             "9 апреля ",
             "10 апреля ",




        };

        string[] time =
            {
            "9:10",
            "10:50",
            "12:30",
            "14:40",
            "16:20",
            "17:50",
            "19:10",
            "22:20"

        };





        public Film3()
        {
            InitializeComponent();


            int i;

            for (i = 0; i < 9; i++)
            {
                comboBoxDate.Items.Add(day[i]);

            }

            for (i = 0; i < 7; i++)
            {
                comboBoxTime.Items.Add(time[i]);
            }

        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void buttonBuy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
