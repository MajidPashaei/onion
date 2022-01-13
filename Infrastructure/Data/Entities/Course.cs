using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }
        
        
    }
}