using CourseProject.InterFaces;
using CourseProject.Mutation;
using CourseProject.Query;
using CourseProject.Schema;
using CourseProject.Services;
using CourseProject.Types;
using GraphiQl;
using GraphQL;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();




builder.Services.AddTransient<ICourseRepository, CourseRepository>();

builder.Services.AddTransient<CourseType>();
builder.Services.AddTransient<CourseQuery>();
builder.Services.AddTransient<CourseMutation>();
builder.Services.AddTransient<CourseInputType>();


builder.Services.AddTransient<ISchema, CourseSchema>();


builder.Services.AddGraphQL(b => b.AddAutoSchema<ISchema>().AddSystemTextJson());

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();


app.UseAuthorization();

app.MapControllers();

app.Run();
