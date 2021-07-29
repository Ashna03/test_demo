using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_DAL.Interface
{
    public interface IRepository<T>
    {
        public Task<T> Add(T obj);
        public T DisplayById(int Id);
        public IEnumerable<T> DisplayAll(string company);
        public void Update(T obj);
    }
}
