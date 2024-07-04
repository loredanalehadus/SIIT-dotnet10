using Cupcakes.Entities;

namespace EFCore.Repositories
{
    public interface ICupcakeRepository
    {
        // CRUD operations
        IEnumerable<Cupcake> GetAll();
        Cupcake GetById(int id);
        void Create(Cupcake cupcake);
        void Update(Cupcake cupcake);
        void Delete(int id);

        void SaveChanges();

    }
}
