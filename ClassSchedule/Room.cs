using System.ComponentModel.DataAnnotations;

namespace ClassSchedule
{
    public class Room
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

       
    }
}