using CourseProject.InterFaces;
using CourseProject.Models;

namespace CourseProject.Services
{
    public class CourseRepository : ICourseRepository
    {


        private static List<Course> CourseList = new List<Course>
    {
        new Course {CourseId=1, Title = "Introduction to C#", Description = "Learn the basics of C# programming.", Hours = 12},
        new Course {CourseId = 2, Title = "Advanced C#", Description = "Deep dive into advanced C# topics." , Hours = 12 },
        new Course {CourseId = 3, Title = "Introduction to GraphQL", Description = "Learn the basics of GraphQL." , Hours = 12 },
        new Course {CourseId = 4, Title = "Advanced GraphQL", Description = "Deep dive into advanced GraphQL topics.", Hours = 12 }
    };

        public Course AddCourse(Course course)
        {
            CourseList.Add(course);
            return course;
        }

        

        public void DeleteCourse(int id)
        {

var course = CourseList.Find(c => c.CourseId == id);

            CourseList.Remove(course);

        }

        public List<Course> GetAll()
        {
            return CourseList;
        }

       

        public Course GetById(int id)
        {
            return CourseList.Find(c => c.CourseId == id);
        }

       

        public Course UpDateCourse(int id, Course course)
        {


            var existingCourse = CourseList.Find(c => c.CourseId == id);

            existingCourse.Title = course.Title;
            existingCourse.Description = course.Description;
            existingCourse.Hours = course.Hours;


            return course;
        }
    }
}
