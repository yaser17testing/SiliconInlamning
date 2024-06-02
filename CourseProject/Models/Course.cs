using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; } // Primary Key

        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool? IsBestSeller { get; set; }
        public bool? IsDigital { get; set; }
        
        public int? StarRating { get; set; }
        public string Reviews { get; set; }
        public string Likes { get; set; }
        public string LikesInPercent { get; set; }
        public int Hours { get; set; }


        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Navigation properties
        public Prices Price { get; set; }

       




        public ICollection<Content> Contents { get; set; }
        

        

    }
}
