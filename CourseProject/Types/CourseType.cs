using CourseProject.Models;
using GraphQL.Types;

namespace CourseProject.Types
{
    public class CourseType : ObjectGraphType<Course>
    {

        public CourseType()
        {
            Field(m => m.CourseId);
            Field(m => m.Title);
            Field(m => m.Hours);
            Field(m => m.Description);
            





        }





    }
}
