using CourseProject.Models;

namespace CourseProject.InterFaces
{
    public interface ICourseRepository
    {

        List<Course> GetAll();

        Course GetById(int id);

        Course AddCourse(Course course);

        Course UpDateCourse (int id , Course course);

        void DeleteCourse (int id);

    }
}
