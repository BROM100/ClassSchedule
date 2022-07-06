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

namespace ClassSchedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ItemList.ItemsSource = ListViewItems;
        }


        public class listviewdata
        {
            public string Class_name { get; set; }
            public string Student_name { get; set; }
            public string Teacher_name { get; set; }
            public string Room_name { get; set; }


        }

        public List<listviewdata> ListViewItems { get; set; } = new List<listviewdata>();
        public void Read()
        {
            using (DataContext context = new DataContext())
            {
                foreach (var item in context.Classes.ToList())
                {
                    ListViewItems.Add(new listviewdata()
                    {
                        Class_name = item.Name,
                        Student_name = context.Students.Single(Student => Student.ID == item.StudentID).Name,
                        Teacher_name = context.Teachers.Single(Teacher => Teacher.ID == item.TeacherID).Name,
                        Room_name = context.Rooms.Single(Room => Room.ID == item.RoomID).Name
                    });
                }
                
            }
            ItemList.Items.Refresh();
        }


        private void CreateButton_Click(object sender, RoutedEventArgs e)

        {
            Create();

        }

        private void ReadButton_Click(object sender, RoutedEventArgs e)
        {
            Read();

        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)

        {


        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)

        {


        }


        public void Create()
        {

            using (DataContext context = new DataContext())
            {
                var studentname = StudentTextBox.Text;
                var teachername = TeacherTextBox.Text;
                var classname = ClassesTextBox.Text;
                var roomname = RoomTextBox.Text;

                var newstudent = new Student { Name = StudentTextBox.Text };
                var newteacher = new Teacher { Name = TeacherTextBox.Text };
                var newroom  = new Room { Name = RoomTextBox.Text };
                

                if (studentname != null && teachername != null  && roomname != null && classname != null)
               {
                    context.Students.Add(newstudent);
                    context.SaveChanges();
                    int IDstudent = newstudent.ID;


                    context.Teachers.Add(newteacher);
                    context.SaveChanges();
                    int IDteacher = newteacher.ID;



                    context.Rooms.Add(newroom);
                    context.SaveChanges();
                    int IDroom = newroom.ID;
                    
                    
                    context.Classes.Add(new Class() { Name = classname, StudentID = IDstudent, RoomID = IDroom, TeacherID = IDteacher});
                    context.SaveChanges();

                }
                else
                {
                    MessageBox.Show("You have to fill all mandatory fields.");
                }

                

            }
        }

        
     
    }
}

