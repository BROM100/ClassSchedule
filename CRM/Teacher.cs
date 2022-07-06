using System.ComponentModel.DataAnnotations;

namespace ClassSchedule
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }


    }
}