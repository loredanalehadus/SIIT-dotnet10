using Cupcakes.Data;
using Cupcakes.Entities;

namespace EFCore.Repositories
{
    public class CupcakeRepository : ICupcakeRepository
    {
        private CupcakeContext context;

        public CupcakeRepository(CupcakeContext context)
        {
            this.context = context;
        }

        public IEnumerable<Cupcake> GetAll()
        {
            return context.Cupcakes.ToList();
        }

        public void Create(Cupcake cupcake)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

   
        public Cupcake GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(Cupcake cupcake)
        {
            throw new NotImplementedException();
        }
    }
}
