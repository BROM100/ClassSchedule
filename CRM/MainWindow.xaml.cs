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

        //Create
        public void Create()
        {
            var studentname = StudentTextBox.Text;
            var teachername = TeacherTextBox.Text;
            var classname = ClassesTextBox.Text;
            var roomname = RoomTextBox.Text;

            using (DataContext context = new DataContext())
            {
                

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

                    Read();
                }
                else
                {
                    MessageBox.Show("You have to fill all mandatory fields.");
                }

                

            }
        }

        //Read 
        public class listviewdata
        {
            public int Class_id { get; set; }
            public string Class_name { get; set; }
            public string Student_name { get; set; }
            public string Teacher_name { get; set; }
            public string Room_name { get; set; }


        }

        public List<listviewdata> ListViewItems { get; set; } = new List<listviewdata>();
        public void Read()
        {
            ListViewItems.Clear();
            using (DataContext context = new DataContext())
            {
                foreach (var item in context.Classes.ToList())
                {
                    ListViewItems.Add(new listviewdata()
                    {   
                        Class_id = item.ID,
                        Class_name = item.Name,
                        Student_name = context.Students.Single(Student => Student.ID == item.StudentID).Name,
                        Teacher_name = context.Teachers.Single(Teacher => Teacher.ID == item.TeacherID).Name,
                        Room_name = context.Rooms.Single(Room => Room.ID == item.RoomID).Name
                    });
                }

            }
            ItemList.Items.Refresh();
        }


        //Update


        public void Update()
        {


            var selected_row = ItemList.SelectedItem as listviewdata;

            using (DataContext context = new DataContext())
            {
                if(selected_row != null)
                {

                    if (ClassesTextBox.Text.Trim() != "")
                    {
                        var classupdate = context.Classes.Where(x => x.ID.Equals(selected_row.Class_id)).Single();
                        classupdate.Name = ClassesTextBox.Text;
                        context.Update(classupdate);

                    }
                    if (StudentTextBox.Text.Trim() != "")
                    {
                        var classupdate = context.Classes.Where(x => x.ID.Equals(selected_row.Class_id)).Single();
                        var studentupdate = context.Students.Where(x => x.ID == classupdate.StudentID).Single();
                        studentupdate.Name = StudentTextBox.Text;
                        context.Update(studentupdate);
                    }
                    if (RoomTextBox.Text.Trim() != "")
                    {
                        var classupdate = context.Classes.Where(x => x.ID.Equals(selected_row.Class_id)).Single();
                        var roomupdate = context.Rooms.Where(x => x.ID == classupdate.RoomID).Single();
                        roomupdate.Name = RoomTextBox.Text;
                        context.Update(roomupdate);
                    }
                    if (TeacherTextBox.Text.Trim() != "")
                    {
                        var classupdate = context.Classes.Where(x => x.ID.Equals(selected_row.Class_id)).Single();
                        var teacherupdate = context.Teachers.Where(x => x.ID == classupdate.RoomID).Single();
                        teacherupdate.Name = RoomTextBox.Text;
                        context.Update(teacherupdate);
                    }

                    context.SaveChanges();
                    Read();



                }
                else
                {
                    MessageBox.Show("You have to select a row to perform an update.");
                }
            }
        }



        //Delete
        public void Delete( )
        {
            var selected_row = ItemList.SelectedItem as listviewdata;
            using (DataContext context = new DataContext())
            {

                if (selected_row != null)
                {
                    Class selectedclass = context.Classes.Single(x => x.ID == selected_row.Class_id);

                    context.Remove(selectedclass);
                    context.SaveChanges();
                    Read();

                }
            }
        }


        }
}

