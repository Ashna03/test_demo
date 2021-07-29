using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_DAL.Interface
{
    public interface IRepository<T>             //T is passed so any object of class can be used and these fnctions can be implemented by that class
    {
        public Task<T> Add(T obj);              //Task is used to do asynchronous function without waiting
        public void Update(T obj);
        public void Remove(T obj);
        public T DisplayByID(int id);
        public IEnumerable<T> DisplayAll();

    }
}
