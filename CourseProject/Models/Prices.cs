using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    public class Prices
    {

        [Key]
        public int PriceId { get; set; } // Primary Key

        [ForeignKey("Course")]
        public int CourseId { get; set; } // Foreign Key

        public string Currency { get; set; }
        public float Amount { get; set; }
        public int? Discount { get; set; }

        // Navigation property
        public Course Courses { get; set; }
    }
}
