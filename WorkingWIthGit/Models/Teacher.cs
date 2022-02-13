using System.ComponentModel.DataAnnotations;

namespace WorkingWIthGit.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        
    }
}
