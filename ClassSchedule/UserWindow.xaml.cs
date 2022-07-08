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

namespace ClassSchedule
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public List<User> DBUsers { get; private set; }

        public UserWindow()
        {
            InitializeComponent();
            Read();

        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Create();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }


        //Read
        public void Read()
        {
            using (DataContext context = new DataContext())
            {
                DBUsers = context.Users.ToList();
                UserList.ItemsSource = DBUsers;
            }
        }
        //Create
        public void Create()
        {
            using (DataContext context = new DataContext())
            {
                var UsernameInput = UsernameTextBox.Text;
                var PasswordInput = PasswordTextBox.Text;


                if (UsernameInput.Trim() != "" && PasswordInput.Trim() != "")

                {
                    context.Users.Add(new User() { Username = UsernameInput, Password = PasswordInput });
                    context.SaveChanges();
                    Read();
                }
                else
                {
                    MessageBox.Show("You have to fill all mandatory fields.");
                }
            }


        }

        //Update 

        public void Update()
        {

            using (DataContext context = new DataContext())
            {

                User selectedUser = UserList.SelectedItem as User;

                if (selectedUser.ID != 1)
                {

                    if (selectedUser != null)
                    {
                        var UsernameInput = UsernameTextBox.Text;
                        var PasswordInput = PasswordTextBox.Text;

                        if (UsernameInput.Trim() != "" && PasswordInput.Trim() != "")
                        {
                            User user = context.Users.Find(selectedUser.ID);
                            user.Username = UsernameInput;
                            user.Password = PasswordInput;

                            context.SaveChanges();
                            Read();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You have to select a User record to perform an update.");
                    }
                }
                else
                {
                    MessageBox.Show("You can not change admin user");
                }
            }
        }


        //Delete 

        public void Delete()
        {
            using (DataContext context = new DataContext())
            {

                User selectedUser = UserList.SelectedItem as User;
                if (selectedUser.ID != 1)
                {

                    if (selectedUser != null)
                    {
                        User user = context.Users.Single(x => x.ID == selectedUser.ID);
                        context.Remove(user);
                        context.SaveChanges();
                        Read();
                    }
                    else
                    {
                        MessageBox.Show("No User record selected.");
                    }
                }
                else
                {
                    MessageBox.Show("You can not delete admin user");
                }
            }


        }
    }
}