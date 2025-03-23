using System.Collections;

namespace CustomFindAllEven
{
    public class RefatList<T> : IEnumerable<T>
    {
        private List<T> Value;

        public RefatList()
        {
            Value = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // need for non-generic collection
            //return GetEnumerator();
            throw new NotImplementedException();
        }

        //access index
        public T this[int index]
        {
            get
            {
                return Value[index];
            }
            set
            {
                Value[index] = value;
            }
        }

        public void Add(T item)
        {
            Value.Add(item);
        }

        public void Remove(T item)
        {
            Value.Remove(item);
        }

        public List<T> GetAll()
        {
            return Value;
        }

        public int Count()
        {
            return Value.Count;
        }
    }
}
