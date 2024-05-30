using System.Collections;

namespace StudentManagementSystem
{
    // Generic Repository Class
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        // TODO: add the missing methods
        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        //TODO: implement missing methods
        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public T Remove(int index)
        {
            throw new NotImplementedException();
        }
    }
}
