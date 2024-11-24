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

namespace ProjectC.Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            //< !--< Button Grid.Row = "3" Grid.Column = "0"  Margin = "10" > ЗАБЫЛИ ПАРОЛЬ ?</ Button >
            //< Button Grid.Row = "3" Grid.Column = "1"  Margin = "10" Width = "250" > РЕГИСТРАЦИЯ </ Button > -->

           var buttonOne = new Button()
            {
                Content = "ЗАБЫЛИ ПАРОЛЬ ?",
                Margin = new Thickness(10),
            };
            var buttonTwo = new Button()
            {
                Content = "РЕГИСТРАЦИЯ",
                Margin = new Thickness(10),

            };
            mainGrid.Children.Add(buttonOne);
            Grid.SetColumn(buttonOne, 0);
            Grid.SetRow(buttonOne, 3);
            mainGrid.Children.Add(buttonTwo);
            Grid.SetColumn(buttonTwo, 1);
            Grid.SetRow(buttonTwo, 3);
        }

        //private void ButtonClick(object sender, RoutedEventArgs e)
        //{
            
        //    var result = MessageBox.Show("Привет, мир!", "Приветственное окно", MessageBoxButton.YesNo, MessageBoxImage.Error);
        //    if (result == MessageBoxResult.Yes)
        //    {
        //        MessageBox.Show("Да", startButton.Content.ToString());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Нет", startButton.Content.ToString());
        //    }

            //test commnt

        //}
    }
}
