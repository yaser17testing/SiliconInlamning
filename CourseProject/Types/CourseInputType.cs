using GraphQL.Types;

namespace CourseProject.Types
{
    public class CourseInputType : InputObjectGraphType

    {



        public CourseInputType()
        {
            Field<IntGraphType>("courseId");
            Field<StringGraphType>("title");
            Field<IntGraphType>("hourse");
            Field<StringGraphType>("description");
        }



    }
}
