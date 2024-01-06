using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoHuyHoang781.Models
{
    public class Subject
    {
        [Key]
        public string SubjectID { get; set; }
        public int SubjectName { get; set; }
        public string StudentID {get; set;}
        [ForeignKey("StudentID")]
        public Student? Student {get; set;}
    }
}