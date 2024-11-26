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
    /// Interaction logic for ElemCalcWindow.xaml
    /// </summary>
    public partial class ElemCalcWindow : Window
    {
        public ElemCalcWindow()
        {
            InitializeComponent();
            var buttonOne = new TextBox()
            {
                Text = "Введите логин",
                Margin = new Thickness(10),
                
                
            };
            var buttonTwo = new TextBox()
            {
                Text = "Введите пароль",
                Margin = new Thickness(10),

            };
            mainGrid.Children.Add(buttonOne);
            Grid.SetColumn(buttonOne, 0);
            Grid.SetRow(buttonOne, 0);
            mainGrid.Children.Add(buttonTwo);
            Grid.SetColumn(buttonTwo, 1);
            Grid.SetRow(buttonTwo, 0);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new CalculatorWindow();
            window.Title = "Привет юзер";
            window.Owner = this;
            window.Show();
            //this.Close();
        }
    }

    
    }
