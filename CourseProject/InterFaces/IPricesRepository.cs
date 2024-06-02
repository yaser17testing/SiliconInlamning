using CourseProject.Models;

namespace CourseProject.InterFaces
{
    public interface IPricesRepository
    {

        List<Prices> GetAllPrice();

        Prices GetById(Guid id);

        Prices AddPrice(Prices prices);

        Prices UpDatePrice (Guid id , Prices prices);

       void DeletePrice (Guid id);

    }
}
