using System.ComponentModel.DataAnnotations;

namespace ClassSchedule
{
    public class User
    {
        [Key]
        public int ID { get; set; } 
        
        public string Username { get; set; }

        public string Password { get; set; }
    }
}