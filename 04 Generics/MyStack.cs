using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    internal class MyStack<T> where T : class
    {
        LinkedList<T> list;
        public MyStack(){
            list = new LinkedList<T>();
        }

        public int Count()
        {
            return list.Count;
        }

        public T? Pop()
        {
            if(list.Count == 0)
            {
                return null;
            }
            T tmp = list.Last();
            return tmp ;
        }
        public void Push(T item)
        {
            list.AddLast(item);
        }
    }
}
