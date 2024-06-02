using CourseProject.InterFaces;
using CourseProject.Types;
using GraphQL;
using GraphQL.Types;

namespace CourseProject.Query
{
    public class CourseQuery : ObjectGraphType
    {

        public CourseQuery(ICourseRepository courseRepository)
        {

            Field<ListGraphType<CourseType>>("Courses").Resolve(context =>
            {

                return courseRepository.GetAll();

            });


            Field<CourseType>("Menu").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "courseId" })).Resolve(context =>
            {
                return courseRepository.GetById(context.GetArgument<int>("courseId"));


            });


        }



    }
}
