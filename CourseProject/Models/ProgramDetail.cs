using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CourseProject.Models
{
    public class ProgramDetail
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [ForeignKey("Content")]
        public int ContentId { get; set; } // Foreign Key

        public string Title { get; set; }
        public string Description { get; set; }

        // Navigation property
        public Content Content { get; set; }



    }
}
