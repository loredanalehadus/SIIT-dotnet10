using System.Collections;

namespace StudentManagementSystem
{
    // Generic Repository Class
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }

        public T Remove(int index)
        {
            T itemToRemove = items[index];
            items.RemoveAt(index);
            return itemToRemove;
        }

        public bool Contains(T item)
        {
            return items.Contains(item);
        }
    }
}
