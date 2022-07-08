using System.ComponentModel.DataAnnotations;

namespace ClassSchedule
{
    public class Class
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public int StudentID { get; set; }

        public int TeacherID { get; set; }

        public int RoomID { get; set; }


    }
}