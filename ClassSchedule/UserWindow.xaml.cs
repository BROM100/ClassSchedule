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
           // Update();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
           // Delete();
        }
       

       
        public void Read()
        {
            using (DataContext context = new DataContext())
            {
                DBUsers = context.Users.ToList();
                UserList.ItemsSource = DBUsers;
            }
        }

        public void Create()
        {

        }

    }
}
