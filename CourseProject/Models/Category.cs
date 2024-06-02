using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    public class Category
    {


        [Key]
        public int CategoryId { get; set; } // Foreign Key

        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }



    }
}
