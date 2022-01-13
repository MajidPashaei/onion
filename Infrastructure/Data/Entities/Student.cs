using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Data.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
 
    }
}