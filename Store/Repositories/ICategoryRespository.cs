using Store.Entities;

namespace Store.Controllers
{
    public interface ICategoryRespository
    {
        IEnumerable<Category> GetAll();
    }
}
