using System;
using System.Collections.Generic;
using System.IO;
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

namespace ClassSchedule
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

       
       

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var Usernamevar = UsernameTextBox.Text;
            var Passwordvar = PasswordBox.Password;


            using (DataContext context = new DataContext())
            {

                bool userexist = context.Users.Any(user => user.Username == Usernamevar && user.Password == Passwordvar);


                if (userexist)
                {
                    GrantAcces();
                    Close();
                    
                }
                else
                {
                    MessageBox.Show("User not found.");
                    
                }
            }
        }


        public void GrantAcces()
        {
            MainWindow main = new MainWindow(UsernameTextBox.Text.Trim());
            main.Show();
        }

        
    }
}
