using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstract
{
    public interface IEntityManager<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        List<T> GetAll(bool active = true);
        T Get(int id);
        List<T> Find(object item);
    }
}
