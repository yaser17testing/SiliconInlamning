using CourseProject.Models;

namespace CourseProject.InterFaces
{
    public interface IProgramDetailRepository
    {

        List<ProgramDetail> GetAlProgram();

        ProgramDetail GetById(Guid id);

        ProgramDetail AddProgram(ProgramDetail programDetail);

                ProgramDetail UpDateProgram (Guid id , ProgramDetail programDetail);

        void DeleteProgram (Guid id);

    }
}
