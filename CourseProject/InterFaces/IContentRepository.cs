using CourseProject.Models;

namespace CourseProject.InterFaces
{
    public interface IContentRepository
    {

        List<Content> GetAll();

        Content GetContentById(Guid id);

        Content AddContent(Content content);

        Content UpDateContent(Guid id, Content content);

       void DeleteCourse(Guid id);


    }
}
