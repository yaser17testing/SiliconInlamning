using CourseProject.Mutation;
using CourseProject.Query;

namespace CourseProject.Schema
{
    public class CourseSchema : GraphQL.Types.Schema
    {

        public CourseSchema(CourseQuery courseQuery,CourseMutation courseMutation)
        {
            Query = courseQuery;
            Mutation = courseMutation;
        }


    }
}
