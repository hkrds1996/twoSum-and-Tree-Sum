using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{

    public interface IInterface
    {
        int Id { get; }
    }
    public interface IRepository<T> where T: IInterface
    {
        public void Add(T item);
        public void Remove(T item);

        public void Save();

        public IEnumerable<T> GetAll()
        ;

        public T GetById(int id)
        ;
    }
    internal class GenericRepository<T> : IRepository<T> where T: IInterface
    {
        private List<T> table;
        public GenericRepository()
        {
            table = new List<T>();
        }

        void IRepository<T>.Add(T item)
        {
            table.Add(item);
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return table;
        }

        T IRepository<T>.GetById(int id)
        {
            return table[id];
        }

        void IRepository<T>.Remove(T item)
        {
            table.Remove(item);
        }

        void IRepository<T>.Save()
        {

        }
    }
}
