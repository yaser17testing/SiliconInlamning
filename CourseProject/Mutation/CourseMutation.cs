using CourseProject.InterFaces;
using CourseProject.Models;
using CourseProject.Types;
using GraphQL;
using GraphQL.Types;

namespace CourseProject.Mutation
{
    public class CourseMutation : ObjectGraphType
    {


        public CourseMutation(ICourseRepository courseRepository)
        {



            Field<CourseType>("CreateCourse").Arguments(new QueryArguments(new QueryArgument<CourseInputType> { Name = "course" })).Resolve(context =>
            {
                return courseRepository.AddCourse(context.GetArgument<Course>("course"));


            });



            Field<CourseType>("UpdateCourse").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "courseId" }, new QueryArgument<CourseInputType> { Name = "course" })).Resolve(context =>
            {

                var course = context.GetArgument<Course>("course");
                var courseId = context.GetArgument<int>("courseId");


                return courseRepository.UpDateCourse(courseId, course);


            });



            Field<StringGraphType>("DeleteCourse").Arguments(new QueryArguments(new QueryArgument<IntGraphType> { Name = "courseId" })).Resolve(context => 
            {

                var courseId = context.GetArgument<int>("courseId");

                courseRepository.DeleteCourse(courseId);

                return "The course against this ID" + courseId + " Has ben removed";


            });






        }


    }
}
