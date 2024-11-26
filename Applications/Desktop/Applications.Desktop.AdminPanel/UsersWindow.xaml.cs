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
using ProjectC.SharedEntities;

namespace ProjectC.Applications.Desktop.AdminPanel
{
    /// <summary>
    /// Interaction logic for UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        //User user = new User()
        //{
        //    Id = 1,
        //    FirstName = "Test",
        //    SecondName = "TestTest",
        //    Age = 20,
        //    Gender = null

        //};
        User[] users = new User[3]
        {
          new User()
          {
            Id = 1,
            FirstName = "Test",
            SecondName = "TestTest",
            Age = 20,
            Gender = null

          },
          new User()
          {
            Id = 2,
            FirstName = "Ivan",
            SecondName = "Ivanov",
            Age = 45,
            Gender = true

          },
          new User()
          {
            Id = 3,
            FirstName = "Irina",
            SecondName = "Petrova",
            Age = 23,
            Gender = false

          },
        };

        public UsersWindow()
        {
            InitializeComponent();
            usersDataGrid.ItemsSource = users;

            //this.DataContext = user;
        }

        private void GetUserDataClick(object sender, RoutedEventArgs e)
        {
            var user = usersDataGrid.SelectedItem as User;
            if  (user != null)
            {
                MessageBox.Show($"Id:{user.Id}, FirstName:{user.FirstName}, SecondName:{user.SecondName}");
            }
            //MessageBox.Show($"Id:{user.Id}, FirstName:{user.FirstName}, SecondName:{user.SecondName}");
        }
    }
}
