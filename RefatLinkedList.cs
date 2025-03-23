using System.Collections;

namespace CustomFindAllEven
{
    public class RefatLinkedList<T> : IEnumerable<T>
    {
        private Node<T> head = default!;
        private Node<T> current = default!;

        public RefatLinkedList()
        {

        }

        /// <summary>
        /// initialize from another collection (List<T>, Array, IEnumerable<T>, API response).
        /// </summary>
        /// <param name="collections"></param>
        //public RefatLinkedList(IEnumerable<T> collections)
        //{
        //    foreach (var collection in collections)
        //    {
        //        this.Add(collection);
        //    }
        //}

        public IEnumerator<T> GetEnumerator()
        {
            Node<T>? temp = head;
            while (temp != null)
            {
                yield return temp.Value;
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // need for non-generic collection
            //return GetEnumerator();
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            Node<T> temp = new Node<T>();
            temp.Value = item;

            if (head == null)
            {
                head = temp;
                current = temp;
            }
            else
            {
                current.Next = temp;
                current = current.Next;
            }
        }

        public IEnumerable<T> GetAll()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                yield return temp.Value;
                temp = temp.Next;
            }
        }

        public T? FirstOrDefault(Func<T, bool>? expression = null)
        {
            Node<T> temp = head;
            T? result = default(T);

            if (expression == null || temp == null)
            {
                return temp != null ? temp.Value : default(T);
            }

            while (temp != null)
            {
                if (expression(temp.Value))
                {
                    result = temp.Value;
                    break;
                }
                temp = temp.Next;
            }

            return result;
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
    }
}
