using System.ComponentModel.DataAnnotations;

namespace DoHuyHoang781.Models
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }
    }
}