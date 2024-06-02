using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    public class Content
    {

        [Key]
        public int ContentId { get; set; } // Primary Key

        [ForeignKey("Course")]
        public int CourseId { get; set; } // Foreign Key

        public string Includes { get; set; }

        // Navigation properties
        public Course Courses { get; set; }
        public ICollection<ProgramDetail> ProgramDetails { get; set; }

    }
}
