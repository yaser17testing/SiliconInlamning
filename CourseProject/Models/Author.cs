using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        public string Name { get; set; }


        public ICollection<Course> courses { get; set; }


    }
}
